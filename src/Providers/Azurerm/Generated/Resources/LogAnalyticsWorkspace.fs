namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace">azurerm_log_analytics_workspace</a>.
    /// </summary>
    type LogAnalyticsWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogAnalyticsWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsWorkspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : LogAnalyticsWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogAnalyticsWorkspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#location-1">LogAnalyticsWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogAnalyticsWorkspaceState<Missing, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsWorkspaceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogAnalyticsWorkspaceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#name-1">LogAnalyticsWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogAnalyticsWorkspaceState<'Location, Missing, 'ResourceGroupName>, value: string) : LogAnalyticsWorkspaceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogAnalyticsWorkspaceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#resource_group_name-1">LogAnalyticsWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogAnalyticsWorkspaceState<'Location, 'Name, Missing>, value: string) : LogAnalyticsWorkspaceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogAnalyticsWorkspaceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#allow_resource_only_permissions-1">LogAnalyticsWorkspace#allow_resource_only_permissions</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_resource_only_permissions">]
        member _.AllowResourceOnlyPermissions(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowResourceOnlyPermissions <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#allow_resource_only_permissions-1">LogAnalyticsWorkspace#allow_resource_only_permissions</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_resource_only_permissions">]
        member _.AllowResourceOnlyPermissions(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowResourceOnlyPermissions <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#cmk_for_query_forced-1">LogAnalyticsWorkspace#cmk_for_query_forced</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cmk_for_query_forced">]
        member _.CmkForQueryForced(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CmkForQueryForced <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#cmk_for_query_forced-1">LogAnalyticsWorkspace#cmk_for_query_forced</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cmk_for_query_forced">]
        member _.CmkForQueryForced(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CmkForQueryForced <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#daily_quota_gb-1">LogAnalyticsWorkspace#daily_quota_gb</a>.
        /// </summary>
        [<CustomOperation "daily_quota_gb">]
        member _.DailyQuotaGb(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: double) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DailyQuotaGb <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#data_collection_rule_id-1">LogAnalyticsWorkspace#data_collection_rule_id</a>.
        /// </summary>
        [<CustomOperation "data_collection_rule_id">]
        member _.DataCollectionRuleId(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DataCollectionRuleId <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#id-1">LogAnalyticsWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#identity-1">LogAnalyticsWorkspace#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspaceIdentity) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#immediate_data_purge_on_30_days_enabled-1">LogAnalyticsWorkspace#immediate_data_purge_on_30_days_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "immediate_data_purge_on30_days_enabled">]
        member _.ImmediateDataPurgeOn30DaysEnabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImmediateDataPurgeOn30DaysEnabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#immediate_data_purge_on_30_days_enabled-1">LogAnalyticsWorkspace#immediate_data_purge_on_30_days_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "immediate_data_purge_on30_days_enabled">]
        member _.ImmediateDataPurgeOn30DaysEnabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImmediateDataPurgeOn30DaysEnabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#internet_ingestion_enabled-1">LogAnalyticsWorkspace#internet_ingestion_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_ingestion_enabled">]
        member _.InternetIngestionEnabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetIngestionEnabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#internet_ingestion_enabled-1">LogAnalyticsWorkspace#internet_ingestion_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_ingestion_enabled">]
        member _.InternetIngestionEnabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetIngestionEnabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#internet_query_enabled-1">LogAnalyticsWorkspace#internet_query_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_query_enabled">]
        member _.InternetQueryEnabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetQueryEnabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#internet_query_enabled-1">LogAnalyticsWorkspace#internet_query_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_query_enabled">]
        member _.InternetQueryEnabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetQueryEnabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#local_authentication_disabled-1">LogAnalyticsWorkspace#local_authentication_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_disabled">]
        member _.LocalAuthenticationDisabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationDisabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#local_authentication_disabled-1">LogAnalyticsWorkspace#local_authentication_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_disabled">]
        member _.LocalAuthenticationDisabled(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationDisabled <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#reservation_capacity_in_gb_per_day-1">LogAnalyticsWorkspace#reservation_capacity_in_gb_per_day</a>.
        /// </summary>
        [<CustomOperation "reservation_capacity_in_gb_per_day">]
        member _.ReservationCapacityInGbPerDay(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: double) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ReservationCapacityInGbPerDay <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#retention_in_days-1">LogAnalyticsWorkspace#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: double) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#sku-1">LogAnalyticsWorkspace#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: string) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#tags-1">LogAnalyticsWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/log_analytics_workspace#timeouts-1">LogAnalyticsWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspaceTimeouts) : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogAnalyticsWorkspaceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: LogAnalyticsWorkspaceState<Present, Present, Present>) : azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspace =
            let config = azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logAnalyticsWorkspace: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogAnalyticsWorkspaceState<_, _, _>) : azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspace =
            Unchecked.defaultof<azurerm.LogAnalyticsWorkspace.LogAnalyticsWorkspace>
