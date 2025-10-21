namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId> = { assignments: ResizeArray<azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_route_table_association">azurerm_subnet_route_table_association</a>.
    /// </summary>
    type SubnetRouteTableAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubnetRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetRouteTableAssociationState<Missing, Missing>)

        member _.Zero(()) : SubnetRouteTableAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SubnetRouteTableAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_route_table_association#route_table_id-1">SubnetRouteTableAssociation#route_table_id</a>.
        /// </summary>
        [<CustomOperation "route_table_id">]
        member _.RouteTableId(state: SubnetRouteTableAssociationState<Missing, 'SubnetId>, value: string) : SubnetRouteTableAssociationState<Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.RouteTableId <- value)
            ({ assignments = state.assignments } : SubnetRouteTableAssociationState<Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_route_table_association#subnet_id-1">SubnetRouteTableAssociation#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: SubnetRouteTableAssociationState<'RouteTableId, Missing>, value: string) : SubnetRouteTableAssociationState<'RouteTableId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : SubnetRouteTableAssociationState<'RouteTableId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_route_table_association#id-1">SubnetRouteTableAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId>, value: string) : SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subnet_route_table_association#timeouts-1">SubnetRouteTableAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId>, value: azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociationTimeouts) : SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubnetRouteTableAssociationState<'RouteTableId, 'SubnetId>

        member _.Run(state: SubnetRouteTableAssociationState<Present, Present>) : azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociation =
            let config = azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subnetRouteTableAssociation: missing required arguments. Must call: route_table_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: SubnetRouteTableAssociationState<_, _>) : azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociation =
            Unchecked.defaultof<azurerm.SubnetRouteTableAssociation.SubnetRouteTableAssociation>
