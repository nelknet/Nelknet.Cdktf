namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbState = { assignments: ResizeArray<aws.DataAwsLb.DataAwsLbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb">aws_lb</a>.
    /// </summary>
    type DataAwsLbBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb#arn-1">DataAwsLb#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLbState, value: string) : DataAwsLbState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsLbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb#id-1">DataAwsLb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLbState, value: string) : DataAwsLbState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb#name-1">DataAwsLb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLbState, value: string) : DataAwsLbState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsLbState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb#tags-1">DataAwsLb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLbState, value: seq<string * string>) : DataAwsLbState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLbState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb#timeouts-1">DataAwsLb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsLbState, value: aws.DataAwsLb.DataAwsLbTimeouts) : DataAwsLbState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsLbState

        member _.Run(state: DataAwsLbState) : aws.DataAwsLb.DataAwsLb =
            let config = aws.DataAwsLb.DataAwsLbConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLb.DataAwsLb(StackContext.get (), logicalId, config)
