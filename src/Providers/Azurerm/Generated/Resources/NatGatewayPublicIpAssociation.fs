namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId> = { assignments: ResizeArray<azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_association">azurerm_nat_gateway_public_ip_association</a>.
    /// </summary>
    type NatGatewayPublicIpAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : NatGatewayPublicIpAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NatGatewayPublicIpAssociationState<Missing, Missing>)

        member _.Zero(()) : NatGatewayPublicIpAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : NatGatewayPublicIpAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_association#nat_gateway_id-1">NatGatewayPublicIpAssociation#nat_gateway_id</a>.
        /// </summary>
        [<CustomOperation "nat_gateway_id">]
        member _.NatGatewayId(state: NatGatewayPublicIpAssociationState<Missing, 'PublicIpAddressId>, value: string) : NatGatewayPublicIpAssociationState<Present, 'PublicIpAddressId> =
            state.assignments.Add(fun config -> config.NatGatewayId <- value)
            ({ assignments = state.assignments } : NatGatewayPublicIpAssociationState<Present, 'PublicIpAddressId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_association#public_ip_address_id-1">NatGatewayPublicIpAssociation#public_ip_address_id</a>.
        /// </summary>
        [<CustomOperation "public_ip_address_id">]
        member _.PublicIpAddressId(state: NatGatewayPublicIpAssociationState<'NatGatewayId, Missing>, value: string) : NatGatewayPublicIpAssociationState<'NatGatewayId, Present> =
            state.assignments.Add(fun config -> config.PublicIpAddressId <- value)
            ({ assignments = state.assignments } : NatGatewayPublicIpAssociationState<'NatGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_association#id-1">NatGatewayPublicIpAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId>, value: string) : NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_association#timeouts-1">NatGatewayPublicIpAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId>, value: azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociationTimeouts) : NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NatGatewayPublicIpAssociationState<'NatGatewayId, 'PublicIpAddressId>

        member _.Run(state: NatGatewayPublicIpAssociationState<Present, Present>) : azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociation =
            let config = azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.natGatewayPublicIpAssociation: missing required arguments. Must call: nat_gateway_id, public_ip_address_id.", 9999, IsError = true)>]
        member _.Run(_: NatGatewayPublicIpAssociationState<_, _>) : azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociation =
            Unchecked.defaultof<azurerm.NatGatewayPublicIpAssociation.NatGatewayPublicIpAssociation>
