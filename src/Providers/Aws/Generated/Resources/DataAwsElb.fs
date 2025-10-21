namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElbState<'Name> = { assignments: ResizeArray<aws.DataAwsElb.DataAwsElbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb">aws_elb</a>.
    /// </summary>
    type DataAwsElbBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElbState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElbState<Missing>)

        member _.Zero(()) : DataAwsElbState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElbState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb#name-1">DataAwsElb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsElbState<Missing>, value: string) : DataAwsElbState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsElbState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb#id-1">DataAwsElb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElbState<'Name>, value: string) : DataAwsElbState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElbState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elb#tags-1">DataAwsElb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsElbState<'Name>, value: seq<string * string>) : DataAwsElbState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsElbState<'Name>

        member _.Run(state: DataAwsElbState<Present>) : aws.DataAwsElb.DataAwsElb =
            let config = aws.DataAwsElb.DataAwsElbConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElb.DataAwsElb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElb: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElbState<_>) : aws.DataAwsElb.DataAwsElb =
            Unchecked.defaultof<aws.DataAwsElb.DataAwsElb>
