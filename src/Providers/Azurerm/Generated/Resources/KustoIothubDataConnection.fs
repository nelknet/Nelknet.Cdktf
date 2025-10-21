namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> = { assignments: ResizeArray<azurerm.KustoIothubDataConnection.KustoIothubDataConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection">azurerm_kusto_iothub_data_connection</a>.
    /// </summary>
    type KustoIothubDataConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoIothubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoIothubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoIothubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoIothubDataConnectionState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#cluster_name-1">KustoIothubDataConnection#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoIothubDataConnectionState<Missing, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<Present, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<Present, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#consumer_group-1">KustoIothubDataConnection#consumer_group</a>.
        /// </summary>
        [<CustomOperation "consumer_group">]
        member _.ConsumerGroup(state: KustoIothubDataConnectionState<'ClusterName, Missing, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, Present, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.ConsumerGroup <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, Present, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#database_name-1">KustoIothubDataConnection#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, Missing, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, Present, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, Present, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#iothub_id-1">KustoIothubDataConnection#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, Missing, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, Present, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, Present, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#location-1">KustoIothubDataConnection#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, Missing, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, Present, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, Present, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#name-1">KustoIothubDataConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, Missing, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, Present, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, Present, 'ResourceGroupName, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#resource_group_name-1">KustoIothubDataConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, Missing, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, Present, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, Present, 'SharedAccessPolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#shared_access_policy_name-1">KustoIothubDataConnection#shared_access_policy_name</a>.
        /// </summary>
        [<CustomOperation "shared_access_policy_name">]
        member _.SharedAccessPolicyName(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SharedAccessPolicyName <- value)
            ({ assignments = state.assignments } : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#database_routing_type-1">KustoIothubDataConnection#database_routing_type</a>.
        /// </summary>
        [<CustomOperation "database_routing_type">]
        member _.DatabaseRoutingType(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.DatabaseRoutingType <- value)
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#data_format-1">KustoIothubDataConnection#data_format</a>.
        /// </summary>
        [<CustomOperation "data_format">]
        member _.DataFormat(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.DataFormat <- value)
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#event_system_properties-1">KustoIothubDataConnection#event_system_properties</a>.
        /// </summary>
        [<CustomOperation "event_system_properties">]
        member _.EventSystemProperties(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: seq<string>) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.EventSystemProperties <- (value |> Seq.toArray))
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#id-1">KustoIothubDataConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#mapping_rule_name-1">KustoIothubDataConnection#mapping_rule_name</a>.
        /// </summary>
        [<CustomOperation "mapping_rule_name">]
        member _.MappingRuleName(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.MappingRuleName <- value)
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#table_name-1">KustoIothubDataConnection#table_name</a>.
        /// </summary>
        [<CustomOperation "table_name">]
        member _.TableName(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: string) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.TableName <- value)
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_iothub_data_connection#timeouts-1">KustoIothubDataConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>, value: azurerm.KustoIothubDataConnection.KustoIothubDataConnectionTimeouts) : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoIothubDataConnectionState<'ClusterName, 'ConsumerGroup, 'DatabaseName, 'IothubId, 'Location, 'Name, 'ResourceGroupName, 'SharedAccessPolicyName>

        member _.Run(state: KustoIothubDataConnectionState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.KustoIothubDataConnection.KustoIothubDataConnection =
            let config = azurerm.KustoIothubDataConnection.KustoIothubDataConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoIothubDataConnection.KustoIothubDataConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoIothubDataConnection: missing required arguments. Must call: cluster_name, consumer_group, database_name, iothub_id, location, name, resource_group_name, shared_access_policy_name.", 9999, IsError = true)>]
        member _.Run(_: KustoIothubDataConnectionState<_, _, _, _, _, _, _, _>) : azurerm.KustoIothubDataConnection.KustoIothubDataConnection =
            Unchecked.defaultof<azurerm.KustoIothubDataConnection.KustoIothubDataConnection>
