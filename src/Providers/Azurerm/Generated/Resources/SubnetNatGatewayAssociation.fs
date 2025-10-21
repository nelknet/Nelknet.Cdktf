namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId> = { assignments: ResizeArray<azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_nat_gateway_association">azurerm_subnet_nat_gateway_association</a>.
    /// </summary>
    type SubnetNatGatewayAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubnetNatGatewayAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetNatGatewayAssociationState<Missing, Missing>)

        member _.Zero(()) : SubnetNatGatewayAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetNatGatewayAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_nat_gateway_association#nat_gateway_id-1">SubnetNatGatewayAssociation#nat_gateway_id</a>.
        /// </summary>
        [<CustomOperation "nat_gateway_id">]
        member _.NatGatewayId(state: SubnetNatGatewayAssociationState<Missing, 'SubnetId>, value: string) : SubnetNatGatewayAssociationState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.NatGatewayId <- value)
            ({ assignments = state.assignments } : SubnetNatGatewayAssociationState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_nat_gateway_association#subnet_id-1">SubnetNatGatewayAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: SubnetNatGatewayAssociationState<'NatGatewayId, Missing>, value: string) : SubnetNatGatewayAssociationState<'NatGatewayId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : SubnetNatGatewayAssociationState<'NatGatewayId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_nat_gateway_association#id-1">SubnetNatGatewayAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId>, value: string) : SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_nat_gateway_association#timeouts-1">SubnetNatGatewayAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId>, value: azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociationTimeouts) : SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubnetNatGatewayAssociationState<'NatGatewayId, 'SubnetId>

        member _.Run(state: SubnetNatGatewayAssociationState<Present, Present>) : azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociation =
            let config = azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subnetNatGatewayAssociation: missing required arguments. Must call: nat_gateway_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: SubnetNatGatewayAssociationState<_, _>) : azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociation =
            Unchecked.defaultof<azurerm.SubnetNatGatewayAssociation.SubnetNatGatewayAssociation>
