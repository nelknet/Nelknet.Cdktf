namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId> = { assignments: ResizeArray<azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association">azurerm_nat_gateway_public_ip_prefix_association</a>.
    /// </summary>
    type NatGatewayPublicIpPrefixAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NatGatewayPublicIpPrefixAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NatGatewayPublicIpPrefixAssociationState<Missing, Missing>)

        member _.Zero(()) : NatGatewayPublicIpPrefixAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NatGatewayPublicIpPrefixAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#nat_gateway_id-1">NatGatewayPublicIpPrefixAssociation#nat_gateway_id</a>.
        /// </summary>
        [<CustomOperation "nat_gateway_id">]
        member _.NatGatewayId(state: NatGatewayPublicIpPrefixAssociationState<Missing, 'PublicIpPrefixId>, value: string) : NatGatewayPublicIpPrefixAssociationState<Present, 'PublicIpPrefixId> =
            state.assignments.Add(fun config -> config.NatGatewayId <- value)
            ({ assignments = state.assignments } : NatGatewayPublicIpPrefixAssociationState<Present, 'PublicIpPrefixId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#public_ip_prefix_id-1">NatGatewayPublicIpPrefixAssociation#public_ip_prefix_id</a>.
        /// </summary>
        [<CustomOperation "public_ip_prefix_id">]
        member _.PublicIpPrefixId(state: NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, Missing>, value: string) : NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, Present> =
            state.assignments.Add(fun config -> config.PublicIpPrefixId <- value)
            ({ assignments = state.assignments } : NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#id-1">NatGatewayPublicIpPrefixAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId>, value: string) : NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#timeouts-1">NatGatewayPublicIpPrefixAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId>, value: azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociationTimeouts) : NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NatGatewayPublicIpPrefixAssociationState<'NatGatewayId, 'PublicIpPrefixId>

        member _.Run(state: NatGatewayPublicIpPrefixAssociationState<Present, Present>) : azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociation =
            let config = azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.natGatewayPublicIpPrefixAssociation: missing required arguments. Must call: nat_gateway_id, public_ip_prefix_id.", 9999, IsError = true)>]
        member _.Run(_: NatGatewayPublicIpPrefixAssociationState<_, _>) : azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociation =
            Unchecked.defaultof<azurerm.NatGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociation>
