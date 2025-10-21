namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> = { assignments: ResizeArray<azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log">azurerm_network_watcher_flow_log</a>.
    /// </summary>
    type NetworkWatcherFlowLogBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkWatcherFlowLogState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkWatcherFlowLogState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkWatcherFlowLogState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkWatcherFlowLogState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#enabled-1">NetworkWatcherFlowLog#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NetworkWatcherFlowLogState<Missing, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: bool) : NetworkWatcherFlowLogState<Present, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<Present, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#enabled-1">NetworkWatcherFlowLog#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: NetworkWatcherFlowLogState<Missing, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: HashiCorp.Cdktf.IResolvable) : NetworkWatcherFlowLogState<Present, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<Present, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#name-1">NetworkWatcherFlowLog#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkWatcherFlowLogState<'Enabled, Missing, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: string) : NetworkWatcherFlowLogState<'Enabled, Present, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<'Enabled, Present, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#network_security_group_id-1">NetworkWatcherFlowLog#network_security_group_id</a>.
        /// </summary>
        [<CustomOperation "network_security_group_id">]
        member _.NetworkSecurityGroupId(state: NetworkWatcherFlowLogState<'Enabled, 'Name, Missing, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: string) : NetworkWatcherFlowLogState<'Enabled, 'Name, Present, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.NetworkSecurityGroupId <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<'Enabled, 'Name, Present, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#network_watcher_name-1">NetworkWatcherFlowLog#network_watcher_name</a>.
        /// </summary>
        [<CustomOperation "network_watcher_name">]
        member _.NetworkWatcherName(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, Missing, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: string) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, Present, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.NetworkWatcherName <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, Present, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#resource_group_name-1">NetworkWatcherFlowLog#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, Missing, 'RetentionPolicy, 'StorageAccountId>, value: string) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, Present, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, Present, 'RetentionPolicy, 'StorageAccountId>)

        /// <summary>
        /// retention_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#retention_policy-1">NetworkWatcherFlowLog#retention_policy</a>
        /// </summary>
        [<CustomOperation "retention_policy">]
        member _.RetentionPolicy(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, Missing, 'StorageAccountId>, value: azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLogRetentionPolicy) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, Present, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.RetentionPolicy <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, Present, 'StorageAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#storage_account_id-1">NetworkWatcherFlowLog#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, Missing>, value: string) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, Present> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            ({ assignments = state.assignments } : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#id-1">NetworkWatcherFlowLog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: string) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#location-1">NetworkWatcherFlowLog#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: string) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#tags-1">NetworkWatcherFlowLog#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: seq<string * string>) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#timeouts-1">NetworkWatcherFlowLog#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLogTimeouts) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>

        /// <summary>
        /// traffic_analytics block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#traffic_analytics-1">NetworkWatcherFlowLog#traffic_analytics</a>
        /// </summary>
        [<CustomOperation "traffic_analytics">]
        member _.TrafficAnalytics(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLogTrafficAnalytics) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.TrafficAnalytics <- value)
            state : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_watcher_flow_log#version-1">NetworkWatcherFlowLog#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>, value: double) : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : NetworkWatcherFlowLogState<'Enabled, 'Name, 'NetworkSecurityGroupId, 'NetworkWatcherName, 'ResourceGroupName, 'RetentionPolicy, 'StorageAccountId>

        member _.Run(state: NetworkWatcherFlowLogState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLog =
            let config = azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLogConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLog(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkWatcherFlowLog: missing required arguments. Must call: enabled, name, network_security_group_id, network_watcher_name, resource_group_name, retention_policy, storage_account_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkWatcherFlowLogState<_, _, _, _, _, _, _>) : azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLog =
            Unchecked.defaultof<azurerm.NetworkWatcherFlowLog.NetworkWatcherFlowLog>
