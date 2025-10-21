namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> = { assignments: ResizeArray<azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeeringConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering">azurerm_databricks_virtual_network_peering</a>.
    /// </summary>
    type DatabricksVirtualNetworkPeeringBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabricksVirtualNetworkPeeringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksVirtualNetworkPeeringState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatabricksVirtualNetworkPeeringState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksVirtualNetworkPeeringState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#name-1">DatabricksVirtualNetworkPeering#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatabricksVirtualNetworkPeeringState<Missing, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: string) : DatabricksVirtualNetworkPeeringState<Present, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatabricksVirtualNetworkPeeringState<Present, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#remote_address_space_prefixes-1">DatabricksVirtualNetworkPeering#remote_address_space_prefixes</a>.
        /// </summary>
        [<CustomOperation "remote_address_space_prefixes">]
        member _.RemoteAddressSpacePrefixes(state: DatabricksVirtualNetworkPeeringState<'Name, Missing, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: seq<string>) : DatabricksVirtualNetworkPeeringState<'Name, Present, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.RemoteAddressSpacePrefixes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatabricksVirtualNetworkPeeringState<'Name, Present, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#remote_virtual_network_id-1">DatabricksVirtualNetworkPeering#remote_virtual_network_id</a>.
        /// </summary>
        [<CustomOperation "remote_virtual_network_id">]
        member _.RemoteVirtualNetworkId(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, Missing, 'ResourceGroupName, 'WorkspaceId>, value: string) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, Present, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.RemoteVirtualNetworkId <- value)
            ({ assignments = state.assignments } : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, Present, 'ResourceGroupName, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#resource_group_name-1">DatabricksVirtualNetworkPeering#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, Missing, 'WorkspaceId>, value: string) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#workspace_id-1">DatabricksVirtualNetworkPeering#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, Missing>, value: string) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#allow_forwarded_traffic-1">DatabricksVirtualNetworkPeering#allow_forwarded_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_forwarded_traffic">]
        member _.AllowForwardedTraffic(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: bool) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowForwardedTraffic <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#allow_forwarded_traffic-1">DatabricksVirtualNetworkPeering#allow_forwarded_traffic</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_forwarded_traffic">]
        member _.AllowForwardedTraffic(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowForwardedTraffic <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#allow_gateway_transit-1">DatabricksVirtualNetworkPeering#allow_gateway_transit</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_gateway_transit">]
        member _.AllowGatewayTransit(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: bool) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowGatewayTransit <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#allow_gateway_transit-1">DatabricksVirtualNetworkPeering#allow_gateway_transit</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_gateway_transit">]
        member _.AllowGatewayTransit(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowGatewayTransit <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#allow_virtual_network_access-1">DatabricksVirtualNetworkPeering#allow_virtual_network_access</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_virtual_network_access">]
        member _.AllowVirtualNetworkAccess(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: bool) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowVirtualNetworkAccess <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#allow_virtual_network_access-1">DatabricksVirtualNetworkPeering#allow_virtual_network_access</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_virtual_network_access">]
        member _.AllowVirtualNetworkAccess(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowVirtualNetworkAccess <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#id-1">DatabricksVirtualNetworkPeering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: string) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#timeouts-1">DatabricksVirtualNetworkPeering#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeeringTimeouts) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#use_remote_gateways-1">DatabricksVirtualNetworkPeering#use_remote_gateways</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_remote_gateways">]
        member _.UseRemoteGateways(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: bool) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.UseRemoteGateways <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_virtual_network_peering#use_remote_gateways-1">DatabricksVirtualNetworkPeering#use_remote_gateways</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_remote_gateways">]
        member _.UseRemoteGateways(state: DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.UseRemoteGateways <- value)
            state : DatabricksVirtualNetworkPeeringState<'Name, 'RemoteAddressSpacePrefixes, 'RemoteVirtualNetworkId, 'ResourceGroupName, 'WorkspaceId>

        member _.Run(state: DatabricksVirtualNetworkPeeringState<Present, Present, Present, Present, Present>) : azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeering =
            let config = azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeeringConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databricksVirtualNetworkPeering: missing required arguments. Must call: name, remote_address_space_prefixes, remote_virtual_network_id, resource_group_name, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: DatabricksVirtualNetworkPeeringState<_, _, _, _, _>) : azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeering =
            Unchecked.defaultof<azurerm.DatabricksVirtualNetworkPeering.DatabricksVirtualNetworkPeering>
