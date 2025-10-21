namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsInstanceStateState<'Identifier, 'State> = { assignments: ResizeArray<aws.RdsInstanceState.RdsInstanceStateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_instance_state">aws_rds_instance_state</a>.
    /// </summary>
    type RdsInstanceStateBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsInstanceStateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsInstanceStateState<Missing, Missing>)

        member _.Zero(()) : RdsInstanceStateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsInstanceStateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_instance_state#identifier-1">RdsInstanceState#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: RdsInstanceStateState<Missing, 'State>, value: string) : RdsInstanceStateState<Present, 'State> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : RdsInstanceStateState<Present, 'State>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_instance_state#state-1">RdsInstanceState#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: RdsInstanceStateState<'Identifier, Missing>, value: string) : RdsInstanceStateState<'Identifier, Present> =
            state.assignments.Add(fun config -> config.State <- value)
            ({ assignments = state.assignments } : RdsInstanceStateState<'Identifier, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_instance_state#timeouts-1">RdsInstanceState#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsInstanceStateState<'Identifier, 'State>, value: aws.RdsInstanceState.RdsInstanceStateTimeouts) : RdsInstanceStateState<'Identifier, 'State> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsInstanceStateState<'Identifier, 'State>

        member _.Run(state: RdsInstanceStateState<Present, Present>) : aws.RdsInstanceState.RdsInstanceState =
            let config = aws.RdsInstanceState.RdsInstanceStateConfig()
            for setter in state.assignments do
                setter config
            aws.RdsInstanceState.RdsInstanceState(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsInstanceState: missing required arguments. Must call: identifier, state.", 9999, IsError = true)>]
        member _.Run(_: RdsInstanceStateState<_, _>) : aws.RdsInstanceState.RdsInstanceState =
            Unchecked.defaultof<aws.RdsInstanceState.RdsInstanceState>
