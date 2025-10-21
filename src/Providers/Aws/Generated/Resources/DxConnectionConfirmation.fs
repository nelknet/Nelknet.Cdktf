namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxConnectionConfirmationState<'ConnectionId> = { assignments: ResizeArray<aws.DxConnectionConfirmation.DxConnectionConfirmationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_confirmation">aws_dx_connection_confirmation</a>.
    /// </summary>
    type DxConnectionConfirmationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxConnectionConfirmationState<Missing> =
            ({ assignments = ResizeArray() } : DxConnectionConfirmationState<Missing>)

        member _.Zero(()) : DxConnectionConfirmationState<Missing> =
            ({ assignments = ResizeArray() } : DxConnectionConfirmationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_confirmation#connection_id-1">DxConnectionConfirmation#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxConnectionConfirmationState<Missing>, value: string) : DxConnectionConfirmationState<Present> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxConnectionConfirmationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_confirmation#id-1">DxConnectionConfirmation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxConnectionConfirmationState<'ConnectionId>, value: string) : DxConnectionConfirmationState<'ConnectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxConnectionConfirmationState<'ConnectionId>

        member _.Run(state: DxConnectionConfirmationState<Present>) : aws.DxConnectionConfirmation.DxConnectionConfirmation =
            let config = aws.DxConnectionConfirmation.DxConnectionConfirmationConfig()
            for setter in state.assignments do
                setter config
            aws.DxConnectionConfirmation.DxConnectionConfirmation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxConnectionConfirmation: missing required arguments. Must call: connection_id.", 9999, IsError = true)>]
        member _.Run(_: DxConnectionConfirmationState<_>) : aws.DxConnectionConfirmation.DxConnectionConfirmation =
            Unchecked.defaultof<aws.DxConnectionConfirmation.DxConnectionConfirmation>
