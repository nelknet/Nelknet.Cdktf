namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> = { assignments: ResizeArray<azurerm.KustoEventgridDataConnection.KustoEventgridDataConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection">azurerm_kusto_eventgrid_data_connection</a>.
    /// </summary>
    type KustoEventgridDataConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoEventgridDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoEventgridDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoEventgridDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoEventgridDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#cluster_name-1">KustoEventgridDataConnection#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoEventgridDataConnectionState<Missing, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<Present, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<Present, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#database_name-1">KustoEventgridDataConnection#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: KustoEventgridDataConnectionState<'ClusterName, Missing, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, Present, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, Present, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#eventhub_consumer_group_name-1">KustoEventgridDataConnection#eventhub_consumer_group_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_consumer_group_name">]
        member _.EventhubConsumerGroupName(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, Missing, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, Present, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.EventhubConsumerGroupName <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, Present, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#eventhub_id-1">KustoEventgridDataConnection#eventhub_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_id">]
        member _.EventhubId(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, Missing, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.EventhubId <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, Present, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#location-1">KustoEventgridDataConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, Missing, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, Present, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, Present, 'Name, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#name-1">KustoEventgridDataConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, Missing, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, Present, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, Present, 'ResourceGroupName, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#resource_group_name-1">KustoEventgridDataConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, Missing, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#storage_account_id-1">KustoEventgridDataConnection#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#blob_storage_event_type-1">KustoEventgridDataConnection#blob_storage_event_type</a>.
        /// </summary>
        [<CustomOperation "blob_storage_event_type">]
        member _.BlobStorageEventType(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.BlobStorageEventType <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#database_routing_type-1">KustoEventgridDataConnection#database_routing_type</a>.
        /// </summary>
        [<CustomOperation "database_routing_type">]
        member _.DatabaseRoutingType(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.DatabaseRoutingType <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#data_format-1">KustoEventgridDataConnection#data_format</a>.
        /// </summary>
        [<CustomOperation "data_format">]
        member _.DataFormat(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.DataFormat <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#eventgrid_resource_id-1">KustoEventgridDataConnection#eventgrid_resource_id</a>.
        /// </summary>
        [<CustomOperation "eventgrid_resource_id">]
        member _.EventgridResourceId(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.EventgridResourceId <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#id-1">KustoEventgridDataConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#managed_identity_resource_id-1">KustoEventgridDataConnection#managed_identity_resource_id</a>.
        /// </summary>
        [<CustomOperation "managed_identity_resource_id">]
        member _.ManagedIdentityResourceId(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ManagedIdentityResourceId <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#mapping_rule_name-1">KustoEventgridDataConnection#mapping_rule_name</a>.
        /// </summary>
        [<CustomOperation "mapping_rule_name">]
        member _.MappingRuleName(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.MappingRuleName <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#skip_first_record-1">KustoEventgridDataConnection#skip_first_record</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_first_record">]
        member _.SkipFirstRecord(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: bool) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SkipFirstRecord <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#skip_first_record-1">KustoEventgridDataConnection#skip_first_record</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "skip_first_record">]
        member _.SkipFirstRecord(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.SkipFirstRecord <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#table_name-1">KustoEventgridDataConnection#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: string) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventgrid_data_connection#timeouts-1">KustoEventgridDataConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>, value: azurerm.KustoEventgridDataConnection.KustoEventgridDataConnectionTimeouts) : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoEventgridDataConnectionState<'ClusterName, 'DatabaseName, 'EventhubConsumerGroupName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName, 'StorageAccountId>

        member _.Run(state: KustoEventgridDataConnectionState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.KustoEventgridDataConnection.KustoEventgridDataConnection =
            let config = azurerm.KustoEventgridDataConnection.KustoEventgridDataConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoEventgridDataConnection.KustoEventgridDataConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoEventgridDataConnection: missing required arguments. Must call: cluster_name, database_name, eventhub_consumer_group_name, eventhub_id, location, name, resource_group_name, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: KustoEventgridDataConnectionState<_, _, _, _, _, _, _, _>) : azurerm.KustoEventgridDataConnection.KustoEventgridDataConnection =
            Unchecked.defaultof<azurerm.KustoEventgridDataConnection.KustoEventgridDataConnection>
