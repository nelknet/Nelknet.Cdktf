namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_endpoint">azurerm_monitor_data_collection_endpoint</a>.
    /// </summary>
    type DataAzurermMonitorDataCollectionEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorDataCollectionEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorDataCollectionEndpointState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMonitorDataCollectionEndpointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorDataCollectionEndpointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_endpoint#name-1">DataAzurermMonitorDataCollectionEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMonitorDataCollectionEndpointState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMonitorDataCollectionEndpointState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorDataCollectionEndpointState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_endpoint#resource_group_name-1">DataAzurermMonitorDataCollectionEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMonitorDataCollectionEndpointState<'Name, Missing>, value: string) : DataAzurermMonitorDataCollectionEndpointState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorDataCollectionEndpointState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_endpoint#id-1">DataAzurermMonitorDataCollectionEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_endpoint#timeouts-1">DataAzurermMonitorDataCollectionEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpointTimeouts) : DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorDataCollectionEndpointState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMonitorDataCollectionEndpointState<Present, Present>) : azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpoint =
            let config = azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorDataCollectionEndpoint: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorDataCollectionEndpointState<_, _>) : azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpoint =
            Unchecked.defaultof<azurerm.DataAzurermMonitorDataCollectionEndpoint.DataAzurermMonitorDataCollectionEndpoint>
