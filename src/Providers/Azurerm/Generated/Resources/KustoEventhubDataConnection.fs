namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.KustoEventhubDataConnection.KustoEventhubDataConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection">azurerm_kusto_eventhub_data_connection</a>.
    /// </summary>
    type KustoEventhubDataConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoEventhubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoEventhubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoEventhubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoEventhubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#cluster_name-1">KustoEventhubDataConnection#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoEventhubDataConnectionState<Missing, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<Present, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<Present, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#consumer_group-1">KustoEventhubDataConnection#consumer_group</a>.
        /// </summary>
        [<CustomOperation "consumer_group">]
        member _.ConsumerGroup(state: KustoEventhubDataConnectionState<'ClusterName, Missing, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, Present, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConsumerGroup <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<'ClusterName, Present, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#database_name-1">KustoEventhubDataConnection#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, Missing, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, Present, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, Present, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#eventhub_id-1">KustoEventhubDataConnection#eventhub_id</a>.
        /// </summary>
        [<CustomOperation "eventhub_id">]
        member _.EventhubId(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventhubId <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#location-1">KustoEventhubDataConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, Missing, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#name-1">KustoEventhubDataConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, Missing, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#resource_group_name-1">KustoEventhubDataConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, Missing>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#compression-1">KustoEventhubDataConnection#compression</a>.
        /// </summary>
        [<CustomOperation "compression">]
        member _.Compression(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Compression <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#database_routing_type-1">KustoEventhubDataConnection#database_routing_type</a>.
        /// </summary>
        [<CustomOperation "database_routing_type">]
        member _.DatabaseRoutingType(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseRoutingType <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#data_format-1">KustoEventhubDataConnection#data_format</a>.
        /// </summary>
        [<CustomOperation "data_format">]
        member _.DataFormat(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataFormat <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#event_system_properties-1">KustoEventhubDataConnection#event_system_properties</a>.
        /// </summary>
        [<CustomOperation "event_system_properties">]
        member _.EventSystemProperties(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventSystemProperties <- (value |> Seq.toArray))
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#id-1">KustoEventhubDataConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#identity_id-1">KustoEventhubDataConnection#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#mapping_rule_name-1">KustoEventhubDataConnection#mapping_rule_name</a>.
        /// </summary>
        [<CustomOperation "mapping_rule_name">]
        member _.MappingRuleName(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MappingRuleName <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#table_name-1">KustoEventhubDataConnection#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_eventhub_data_connection#timeouts-1">KustoEventhubDataConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KustoEventhubDataConnection.KustoEventhubDataConnectionTimeouts) : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoEventhubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'EventhubId, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: KustoEventhubDataConnectionState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.KustoEventhubDataConnection.KustoEventhubDataConnection =
            let config = azurerm.KustoEventhubDataConnection.KustoEventhubDataConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoEventhubDataConnection.KustoEventhubDataConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoEventhubDataConnection: missing required arguments. Must call: cluster_name, consumer_group, database_name, eventhub_id, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: KustoEventhubDataConnectionState<_, _, _, _, _, _, _>) : azurerm.KustoEventhubDataConnection.KustoEventhubDataConnection =
            Unchecked.defaultof<azurerm.KustoEventhubDataConnection.KustoEventhubDataConnection>
