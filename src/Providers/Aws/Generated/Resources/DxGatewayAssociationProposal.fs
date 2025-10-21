namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId> = { assignments: ResizeArray<aws.DxGatewayAssociationProposal.DxGatewayAssociationProposalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association_proposal">aws_dx_gateway_association_proposal</a>.
    /// </summary>
    type DxGatewayAssociationProposalBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxGatewayAssociationProposalState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxGatewayAssociationProposalState<Missing, Missing, Missing>)

        member _.Zero(()) : DxGatewayAssociationProposalState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxGatewayAssociationProposalState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association_proposal#associated_gateway_id-1">DxGatewayAssociationProposal#associated_gateway_id</a>.
        /// </summary>
        [<CustomOperation "associated_gateway_id">]
        member _.AssociatedGatewayId(state: DxGatewayAssociationProposalState<Missing, 'DxGatewayId, 'DxGatewayOwnerAccountId>, value: string) : DxGatewayAssociationProposalState<Present, 'DxGatewayId, 'DxGatewayOwnerAccountId> =
            state.assignments.Add(fun config -> config.AssociatedGatewayId <- value)
            ({ assignments = state.assignments } : DxGatewayAssociationProposalState<Present, 'DxGatewayId, 'DxGatewayOwnerAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association_proposal#dx_gateway_id-1">DxGatewayAssociationProposal#dx_gateway_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_id">]
        member _.DxGatewayId(state: DxGatewayAssociationProposalState<'AssociatedGatewayId, Missing, 'DxGatewayOwnerAccountId>, value: string) : DxGatewayAssociationProposalState<'AssociatedGatewayId, Present, 'DxGatewayOwnerAccountId> =
            state.assignments.Add(fun config -> config.DxGatewayId <- value)
            ({ assignments = state.assignments } : DxGatewayAssociationProposalState<'AssociatedGatewayId, Present, 'DxGatewayOwnerAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association_proposal#dx_gateway_owner_account_id-1">DxGatewayAssociationProposal#dx_gateway_owner_account_id</a>.
        /// </summary>
        [<CustomOperation "dx_gateway_owner_account_id">]
        member _.DxGatewayOwnerAccountId(state: DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, Missing>, value: string) : DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, Present> =
            state.assignments.Add(fun config -> config.DxGatewayOwnerAccountId <- value)
            ({ assignments = state.assignments } : DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association_proposal#allowed_prefixes-1">DxGatewayAssociationProposal#allowed_prefixes</a>.
        /// </summary>
        [<CustomOperation "allowed_prefixes">]
        member _.AllowedPrefixes(state: DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId>, value: seq<string>) : DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId> =
            state.assignments.Add(fun config -> config.AllowedPrefixes <- (value |> Seq.toArray))
            state : DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway_association_proposal#id-1">DxGatewayAssociationProposal#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId>, value: string) : DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxGatewayAssociationProposalState<'AssociatedGatewayId, 'DxGatewayId, 'DxGatewayOwnerAccountId>

        member _.Run(state: DxGatewayAssociationProposalState<Present, Present, Present>) : aws.DxGatewayAssociationProposal.DxGatewayAssociationProposal =
            let config = aws.DxGatewayAssociationProposal.DxGatewayAssociationProposalConfig()
            for setter in state.assignments do
                setter config
            aws.DxGatewayAssociationProposal.DxGatewayAssociationProposal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxGatewayAssociationProposal: missing required arguments. Must call: associated_gateway_id, dx_gateway_id, dx_gateway_owner_account_id.", 9999, IsError = true)>]
        member _.Run(_: DxGatewayAssociationProposalState<_, _, _>) : aws.DxGatewayAssociationProposal.DxGatewayAssociationProposal =
            Unchecked.defaultof<aws.DxGatewayAssociationProposal.DxGatewayAssociationProposal>
