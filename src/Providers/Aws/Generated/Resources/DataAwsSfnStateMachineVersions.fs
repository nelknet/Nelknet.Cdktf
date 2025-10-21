namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSfnStateMachineVersionsState<'StatemachineArn> = { assignments: ResizeArray<aws.DataAwsSfnStateMachineVersions.DataAwsSfnStateMachineVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_state_machine_versions">aws_sfn_state_machine_versions</a>.
    /// </summary>
    type DataAwsSfnStateMachineVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSfnStateMachineVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSfnStateMachineVersionsState<Missing>)

        member _.Zero(()) : DataAwsSfnStateMachineVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSfnStateMachineVersionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_state_machine_versions#statemachine_arn-1">DataAwsSfnStateMachineVersions#statemachine_arn</a>.
        /// </summary>
        [<CustomOperation "statemachine_arn">]
        member _.StatemachineArn(state: DataAwsSfnStateMachineVersionsState<Missing>, value: string) : DataAwsSfnStateMachineVersionsState<Present> =
            state.assignments.Add(fun config -> config.StatemachineArn <- value)
            ({ assignments = state.assignments } : DataAwsSfnStateMachineVersionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_state_machine_versions#id-1">DataAwsSfnStateMachineVersions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSfnStateMachineVersionsState<'StatemachineArn>, value: string) : DataAwsSfnStateMachineVersionsState<'StatemachineArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSfnStateMachineVersionsState<'StatemachineArn>

        member _.Run(state: DataAwsSfnStateMachineVersionsState<Present>) : aws.DataAwsSfnStateMachineVersions.DataAwsSfnStateMachineVersions =
            let config = aws.DataAwsSfnStateMachineVersions.DataAwsSfnStateMachineVersionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSfnStateMachineVersions.DataAwsSfnStateMachineVersions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSfnStateMachineVersions: missing required arguments. Must call: statemachine_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSfnStateMachineVersionsState<_>) : aws.DataAwsSfnStateMachineVersions.DataAwsSfnStateMachineVersions =
            Unchecked.defaultof<aws.DataAwsSfnStateMachineVersions.DataAwsSfnStateMachineVersions>
