namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> = { assignments: ResizeArray<azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection">azurerm_digital_twins_time_series_database_connection</a>.
    /// </summary>
    type DigitalTwinsTimeSeriesDatabaseConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DigitalTwinsTimeSeriesDatabaseConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsTimeSeriesDatabaseConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DigitalTwinsTimeSeriesDatabaseConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsTimeSeriesDatabaseConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#digital_twins_id-1">DigitalTwinsTimeSeriesDatabaseConnection#digital_twins_id</a>.
        /// </summary>
        [<CustomOperation "digital_twins_id">]
        member _.DigitalTwinsId(state: DigitalTwinsTimeSeriesDatabaseConnectionState<Missing, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<Present, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.DigitalTwinsId <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<Present, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#eventhub_name-1">DigitalTwinsTimeSeriesDatabaseConnection#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, Missing, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, Present, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, Present, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#eventhub_namespace_endpoint_uri-1">DigitalTwinsTimeSeriesDatabaseConnection#eventhub_namespace_endpoint_uri</a>.
        /// </summary>
        [<CustomOperation "eventhub_namespace_endpoint_uri">]
        member _.EventhubNamespaceEndpointUri(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, Missing, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, Present, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.EventhubNamespaceEndpointUri <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, Present, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#eventhub_namespace_id-1">DigitalTwinsTimeSeriesDatabaseConnection#eventhub_namespace_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_namespace_id">]
        member _.EventhubNamespaceId(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, Missing, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, Present, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.EventhubNamespaceId <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, Present, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#kusto_cluster_id-1">DigitalTwinsTimeSeriesDatabaseConnection#kusto_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kusto_cluster_id">]
        member _.KustoClusterId(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, Missing, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, Present, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.KustoClusterId <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, Present, 'KustoClusterUri, 'KustoDatabaseName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#kusto_cluster_uri-1">DigitalTwinsTimeSeriesDatabaseConnection#kusto_cluster_uri</a>.
        /// </summary>
        [<CustomOperation "kusto_cluster_uri">]
        member _.KustoClusterUri(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, Missing, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, Present, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.KustoClusterUri <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, Present, 'KustoDatabaseName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#kusto_database_name-1">DigitalTwinsTimeSeriesDatabaseConnection#kusto_database_name</a>.
        /// </summary>
        [<CustomOperation "kusto_database_name">]
        member _.KustoDatabaseName(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, Missing, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, Present, 'Name> =
            state.assignments.Add(fun config -> config.KustoDatabaseName <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#name-1">DigitalTwinsTimeSeriesDatabaseConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, Missing>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#eventhub_consumer_group_name-1">DigitalTwinsTimeSeriesDatabaseConnection#eventhub_consumer_group_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_consumer_group_name">]
        member _.EventhubConsumerGroupName(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.EventhubConsumerGroupName <- value)
            state : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#id-1">DigitalTwinsTimeSeriesDatabaseConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#kusto_table_name-1">DigitalTwinsTimeSeriesDatabaseConnection#kusto_table_name</a>.
        /// </summary>
        [<CustomOperation "kusto_table_name">]
        member _.KustoTableName(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: string) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.KustoTableName <- value)
            state : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_time_series_database_connection#timeouts-1">DigitalTwinsTimeSeriesDatabaseConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>, value: azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionTimeouts) : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DigitalTwinsTimeSeriesDatabaseConnectionState<'DigitalTwinsId, 'EventhubName, 'EventhubNamespaceEndpointUri, 'EventhubNamespaceId, 'KustoClusterId, 'KustoClusterUri, 'KustoDatabaseName, 'Name>

        member _.Run(state: DigitalTwinsTimeSeriesDatabaseConnectionState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnection =
            let config = azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.digitalTwinsTimeSeriesDatabaseConnection: missing required arguments. Must call: digital_twins_id, eventhub_name, eventhub_namespace_endpoint_uri, eventhub_namespace_id, kusto_cluster_id, kusto_cluster_uri, kusto_database_name, name.", 9999, IsError = true)>]
        member _.Run(_: DigitalTwinsTimeSeriesDatabaseConnectionState<_, _, _, _, _, _, _, _>) : azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnection =
            Unchecked.defaultof<azurerm.DigitalTwinsTimeSeriesDatabaseConnection.DigitalTwinsTimeSeriesDatabaseConnection>
