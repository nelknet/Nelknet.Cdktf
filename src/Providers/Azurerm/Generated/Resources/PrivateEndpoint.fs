namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> = { assignments: ResizeArray<azurerm.PrivateEndpoint.PrivateEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint">azurerm_private_endpoint</a>.
    /// </summary>
    type PrivateEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateEndpointState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PrivateEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateEndpointState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#location-1">PrivateEndpoint#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PrivateEndpointState<Missing, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: string) : PrivateEndpointState<Present, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PrivateEndpointState<Present, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name-1">PrivateEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PrivateEndpointState<'Location, Missing, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: string) : PrivateEndpointState<'Location, Present, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PrivateEndpointState<'Location, Present, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// private_service_connection block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_service_connection-1">PrivateEndpoint#private_service_connection</a>
        /// </summary>
        [<CustomOperation "private_service_connection">]
        member _.PrivateServiceConnection(state: PrivateEndpointState<'Location, 'Name, Missing, 'ResourceGroupName, 'SubnetId>, value: azurerm.PrivateEndpoint.PrivateEndpointPrivateServiceConnection) : PrivateEndpointState<'Location, 'Name, Present, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateServiceConnection <- value)
            ({ assignments = state.assignments } : PrivateEndpointState<'Location, 'Name, Present, 'ResourceGroupName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#resource_group_name-1">PrivateEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, Missing, 'SubnetId>, value: string) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#subnet_id-1">PrivateEndpoint#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, Missing>, value: string) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#custom_network_interface_name-1">PrivateEndpoint#custom_network_interface_name</a>.
        /// </summary>
        [<CustomOperation "custom_network_interface_name">]
        member _.CustomNetworkInterfaceName(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: string) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.CustomNetworkInterfaceName <- value)
            state : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#id-1">PrivateEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: string) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// ip_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#ip_configuration-1">PrivateEndpoint#ip_configuration</a> Accepts: azurerm.IResolvable | azurerm.PrivateEndpoint.PrivateEndpointIpConfiguration[]
        /// </summary>
        [<CustomOperation "ip_configuration">]
        member _.IpConfiguration(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.IpConfiguration <- value)
            state : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// private_dns_zone_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_dns_zone_group-1">PrivateEndpoint#private_dns_zone_group</a>
        /// </summary>
        [<CustomOperation "private_dns_zone_group">]
        member _.PrivateDnsZoneGroup(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: azurerm.PrivateEndpoint.PrivateEndpointPrivateDnsZoneGroup) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.PrivateDnsZoneGroup <- value)
            state : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#tags-1">PrivateEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: seq<string * string>) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#timeouts-1">PrivateEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>, value: azurerm.PrivateEndpoint.PrivateEndpointTimeouts) : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateEndpointState<'Location, 'Name, 'PrivateServiceConnection, 'ResourceGroupName, 'SubnetId>

        member _.Run(state: PrivateEndpointState<Present, Present, Present, Present, Present>) : azurerm.PrivateEndpoint.PrivateEndpoint =
            let config = azurerm.PrivateEndpoint.PrivateEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateEndpoint.PrivateEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateEndpoint: missing required arguments. Must call: location, name, private_service_connection, resource_group_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateEndpointState<_, _, _, _, _>) : azurerm.PrivateEndpoint.PrivateEndpoint =
            Unchecked.defaultof<azurerm.PrivateEndpoint.PrivateEndpoint>
