namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSfnStateMachineState<'Name> = { assignments: ResizeArray<aws.DataAwsSfnStateMachine.DataAwsSfnStateMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_state_machine">aws_sfn_state_machine</a>.
    /// </summary>
    type DataAwsSfnStateMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSfnStateMachineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSfnStateMachineState<Missing>)

        member _.Zero(()) : DataAwsSfnStateMachineState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSfnStateMachineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_state_machine#name-1">DataAwsSfnStateMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSfnStateMachineState<Missing>, value: string) : DataAwsSfnStateMachineState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsSfnStateMachineState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/sfn_state_machine#id-1">DataAwsSfnStateMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSfnStateMachineState<'Name>, value: string) : DataAwsSfnStateMachineState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSfnStateMachineState<'Name>

        member _.Run(state: DataAwsSfnStateMachineState<Present>) : aws.DataAwsSfnStateMachine.DataAwsSfnStateMachine =
            let config = aws.DataAwsSfnStateMachine.DataAwsSfnStateMachineConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSfnStateMachine.DataAwsSfnStateMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSfnStateMachine: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSfnStateMachineState<_>) : aws.DataAwsSfnStateMachine.DataAwsSfnStateMachine =
            Unchecked.defaultof<aws.DataAwsSfnStateMachine.DataAwsSfnStateMachine>
