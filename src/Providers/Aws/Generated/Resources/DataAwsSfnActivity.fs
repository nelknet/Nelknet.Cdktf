namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSfnActivityState = { assignments: ResizeArray<aws.DataAwsSfnActivity.DataAwsSfnActivityConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_activity">aws_sfn_activity</a>.
    /// </summary>
    type DataAwsSfnActivityBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSfnActivityState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSfnActivityState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_activity#arn-1">DataAwsSfnActivity#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSfnActivityState, value: string) : DataAwsSfnActivityState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsSfnActivityState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_activity#id-1">DataAwsSfnActivity#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSfnActivityState, value: string) : DataAwsSfnActivityState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSfnActivityState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_activity#name-1">DataAwsSfnActivity#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSfnActivityState, value: string) : DataAwsSfnActivityState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsSfnActivityState

        member _.Run(state: DataAwsSfnActivityState) : aws.DataAwsSfnActivity.DataAwsSfnActivity =
            let config = aws.DataAwsSfnActivity.DataAwsSfnActivityConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSfnActivity.DataAwsSfnActivity(StackContext.get (), logicalId, config)
