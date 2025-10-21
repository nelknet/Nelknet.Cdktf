namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxGatewayAssociationState<'DxGatewayId> = { assignments: ResizeArray<aws.DxGatewayAssociation.DxGatewayAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association">aws_dx_gateway_association</a>.
    /// </summary>
    type DxGatewayAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxGatewayAssociationState<Missing> =
            ({ assignments = ResizeArray() } : DxGatewayAssociationState<Missing>)

        member _.Zero(()) : DxGatewayAssociationState<Missing> =
            ({ assignments = ResizeArray() } : DxGatewayAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#dx_gateway_id-1">DxGatewayAssociation#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DxGatewayAssociationState<Missing>, value: string) : DxGatewayAssociationState<Present> =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            ({ assignments = state.assignments } : DxGatewayAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#allowed_prefixes-1">DxGatewayAssociation#allowed_prefixes</a>.
        /// </summary>
        [<CustomOperation "allowed_prefixes">]
        member _.AllowedPrefixes(state: DxGatewayAssociationState<'DxGatewayId>, value: seq<string>) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.AllowedPrefixes <- (value |> Seq.toArray))
            state : DxGatewayAssociationState<'DxGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#associated_gateway_id-1">DxGatewayAssociation#associated_gateway_id</a>.
        /// </summary>
        [<CustomOperation "associated_gateway_id">]
        member _.AssociatedGatewayId(state: DxGatewayAssociationState<'DxGatewayId>, value: string) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.AssociatedGatewayId <- value)
            state : DxGatewayAssociationState<'DxGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#associated_gateway_owner_account_id-1">DxGatewayAssociation#associated_gateway_owner_account_id</a>.
        /// </summary>
        [<CustomOperation "associated_gateway_owner_account_id">]
        member _.AssociatedGatewayOwnerAccountId(state: DxGatewayAssociationState<'DxGatewayId>, value: string) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.AssociatedGatewayOwnerAccountId <- value)
            state : DxGatewayAssociationState<'DxGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#id-1">DxGatewayAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxGatewayAssociationState<'DxGatewayId>, value: string) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxGatewayAssociationState<'DxGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#proposal_id-1">DxGatewayAssociation#proposal_id</a>.
        /// </summary>
        [<CustomOperation "proposal_id">]
        member _.ProposalId(state: DxGatewayAssociationState<'DxGatewayId>, value: string) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.ProposalId <- value)
            state : DxGatewayAssociationState<'DxGatewayId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#timeouts-1">DxGatewayAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxGatewayAssociationState<'DxGatewayId>, value: aws.DxGatewayAssociation.DxGatewayAssociationTimeouts) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxGatewayAssociationState<'DxGatewayId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association#vpn_gateway_id-1">DxGatewayAssociation#vpn_gateway_id</a>.
        /// </summary>
        [<CustomOperation "vpn_gateway_id">]
        member _.VpnGatewayId(state: DxGatewayAssociationState<'DxGatewayId>, value: string) : DxGatewayAssociationState<'DxGatewayId> =
            state.assignments.Add(fun config -> config.VpnGatewayId <- value)
            state : DxGatewayAssociationState<'DxGatewayId>

        member _.Run(state: DxGatewayAssociationState<Present>) : aws.DxGatewayAssociation.DxGatewayAssociation =
            let config = aws.DxGatewayAssociation.DxGatewayAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DxGatewayAssociation.DxGatewayAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxGatewayAssociation: missing required arguments. Must call: dx_gateway_id.", 9999, IsError = true)>]
        member _.Run(_: DxGatewayAssociationState<_>) : aws.DxGatewayAssociation.DxGatewayAssociation =
            Unchecked.defaultof<aws.DxGatewayAssociation.DxGatewayAssociation>
