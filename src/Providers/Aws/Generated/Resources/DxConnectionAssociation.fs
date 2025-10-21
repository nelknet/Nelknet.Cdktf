namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxConnectionAssociationState<'ConnectionId, 'LagId> = { assignments: ResizeArray<aws.DxConnectionAssociation.DxConnectionAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_association">aws_dx_connection_association</a>.
    /// </summary>
    type DxConnectionAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxConnectionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DxConnectionAssociationState<Missing, Missing>)

        member _.Zero(()) : DxConnectionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DxConnectionAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_association#connection_id-1">DxConnectionAssociation#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxConnectionAssociationState<Missing, 'LagId>, value: string) : DxConnectionAssociationState<Present, 'LagId> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            ({ assignments = state.assignments } : DxConnectionAssociationState<Present, 'LagId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_association#lag_id-1">DxConnectionAssociation#lag_id</a>.
        /// </summary>
        [<CustomOperation "lag_id">]
        member _.LagId(state: DxConnectionAssociationState<'ConnectionId, Missing>, value: string) : DxConnectionAssociationState<'ConnectionId, Present> =
            state.assignments.Add(fun config -> config.LagId <- value)
            ({ assignments = state.assignments } : DxConnectionAssociationState<'ConnectionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_connection_association#id-1">DxConnectionAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxConnectionAssociationState<'ConnectionId, 'LagId>, value: string) : DxConnectionAssociationState<'ConnectionId, 'LagId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxConnectionAssociationState<'ConnectionId, 'LagId>

        member _.Run(state: DxConnectionAssociationState<Present, Present>) : aws.DxConnectionAssociation.DxConnectionAssociation =
            let config = aws.DxConnectionAssociation.DxConnectionAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DxConnectionAssociation.DxConnectionAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxConnectionAssociation: missing required arguments. Must call: connection_id, lag_id.", 9999, IsError = true)>]
        member _.Run(_: DxConnectionAssociationState<_, _>) : aws.DxConnectionAssociation.DxConnectionAssociation =
            Unchecked.defaultof<aws.DxConnectionAssociation.DxConnectionAssociation>
