namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbsState = { assignments: ResizeArray<aws.DataAwsLbs.DataAwsLbsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lbs">aws_lbs</a>.
    /// </summary>
    type DataAwsLbsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lbs#id-1">DataAwsLbs#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLbsState, value: string) : DataAwsLbsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLbsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lbs#tags-1">DataAwsLbs#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLbsState, value: seq<string * string>) : DataAwsLbsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLbsState

        member _.Run(state: DataAwsLbsState) : aws.DataAwsLbs.DataAwsLbs =
            let config = aws.DataAwsLbs.DataAwsLbsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLbs.DataAwsLbs(StackContext.get (), logicalId, config)
