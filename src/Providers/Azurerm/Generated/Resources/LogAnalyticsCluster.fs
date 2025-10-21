namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogAnalyticsCluster.LogAnalyticsClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster">azurerm_log_analytics_cluster</a>.
    /// </summary>
    type LogAnalyticsClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#identity-1">LogAnalyticsCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LogAnalyticsClusterState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogAnalyticsCluster.LogAnalyticsClusterIdentity) : LogAnalyticsClusterState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : LogAnalyticsClusterState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#location-1">LogAnalyticsCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogAnalyticsClusterState<'Identity, Missing, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsClusterState<'Identity, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogAnalyticsClusterState<'Identity, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#name-1">LogAnalyticsCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsClusterState<'Identity, 'Location, Missing, 'ResourceGroupName>, value: string) : LogAnalyticsClusterState<'Identity, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsClusterState<'Identity, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#resource_group_name-1">LogAnalyticsCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsClusterState<'Identity, 'Location, 'Name, Missing>, value: string) : LogAnalyticsClusterState<'Identity, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsClusterState<'Identity, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#id-1">LogAnalyticsCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#size_gb-1">LogAnalyticsCluster#size_gb</a>.
        /// </summary>
        [<CustomOperation "size_gb">]
        member _.SizeGb(state: LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: double) : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SizeGb <- value)
            state : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#tags-1">LogAnalyticsCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_cluster#timeouts-1">LogAnalyticsCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogAnalyticsCluster.LogAnalyticsClusterTimeouts) : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsClusterState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LogAnalyticsClusterState<Present, Present, Present, Present>) : azurerm.LogAnalyticsCluster.LogAnalyticsCluster =
            let config = azurerm.LogAnalyticsCluster.LogAnalyticsClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsCluster.LogAnalyticsCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsCluster: missing required arguments. Must call: identity, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsClusterState<_, _, _, _>) : azurerm.LogAnalyticsCluster.LogAnalyticsCluster =
            Unchecked.defaultof<azurerm.LogAnalyticsCluster.LogAnalyticsCluster>
