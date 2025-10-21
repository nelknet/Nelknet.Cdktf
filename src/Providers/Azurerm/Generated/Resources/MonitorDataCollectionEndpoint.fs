namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint">azurerm_monitor_data_collection_endpoint</a>.
    /// </summary>
    type MonitorDataCollectionEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorDataCollectionEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorDataCollectionEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : MonitorDataCollectionEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MonitorDataCollectionEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#location-1">MonitorDataCollectionEndpoint#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MonitorDataCollectionEndpointState<Missing, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionEndpointState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionEndpointState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#name-1">MonitorDataCollectionEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorDataCollectionEndpointState<'Location, Missing, 'ResourceGroupName>, value: string) : MonitorDataCollectionEndpointState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionEndpointState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#resource_group_name-1">MonitorDataCollectionEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MonitorDataCollectionEndpointState<'Location, 'Name, Missing>, value: string) : MonitorDataCollectionEndpointState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionEndpointState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#description-1">MonitorDataCollectionEndpoint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#id-1">MonitorDataCollectionEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#kind-1">MonitorDataCollectionEndpoint#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: string) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#public_network_access_enabled-1">MonitorDataCollectionEndpoint#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: bool) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#public_network_access_enabled-1">MonitorDataCollectionEndpoint#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#tags-1">MonitorDataCollectionEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_endpoint#timeouts-1">MonitorDataCollectionEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpointTimeouts) : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorDataCollectionEndpointState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: MonitorDataCollectionEndpointState<Present, Present, Present>) : azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpoint =
            let config = azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorDataCollectionEndpoint: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MonitorDataCollectionEndpointState<_, _, _>) : azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpoint =
            Unchecked.defaultof<azurerm.MonitorDataCollectionEndpoint.MonitorDataCollectionEndpoint>
