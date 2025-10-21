namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApplicationInsights.ApplicationInsightsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights">azurerm_application_insights</a>.
    /// </summary>
    type ApplicationInsightsBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationInsightsState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationInsightsState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationInsightsState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#application_type-1">ApplicationInsights#application_type</a>.
        /// </summary>
        [<CustomOperation "application_type">]
        member _.ApplicationType(state: ApplicationInsightsState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ApplicationType <- value)
            ({ assignments = state.assignments } : ApplicationInsightsState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#location-1">ApplicationInsights#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationInsightsState<'ApplicationType, Missing, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsState<'ApplicationType, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationInsightsState<'ApplicationType, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#name-1">ApplicationInsights#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationInsightsState<'ApplicationType, 'Location, Missing, 'ResourceGroupName>, value: string) : ApplicationInsightsState<'ApplicationType, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationInsightsState<'ApplicationType, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#resource_group_name-1">ApplicationInsights#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, Missing>, value: string) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#daily_data_cap_in_gb-1">ApplicationInsights#daily_data_cap_in_gb</a>.
        /// </summary>
        [<CustomOperation "daily_data_cap_in_gb">]
        member _.DailyDataCapInGb(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: double) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DailyDataCapInGb <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#daily_data_cap_notifications_disabled-1">ApplicationInsights#daily_data_cap_notifications_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "daily_data_cap_notifications_disabled">]
        member _.DailyDataCapNotificationsDisabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DailyDataCapNotificationsDisabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#daily_data_cap_notifications_disabled-1">ApplicationInsights#daily_data_cap_notifications_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "daily_data_cap_notifications_disabled">]
        member _.DailyDataCapNotificationsDisabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DailyDataCapNotificationsDisabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#disable_ip_masking-1">ApplicationInsights#disable_ip_masking</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_ip_masking">]
        member _.DisableIpMasking(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisableIpMasking <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#disable_ip_masking-1">ApplicationInsights#disable_ip_masking</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disable_ip_masking">]
        member _.DisableIpMasking(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DisableIpMasking <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#force_customer_storage_for_profiler-1">ApplicationInsights#force_customer_storage_for_profiler</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "force_customer_storage_for_profiler">]
        member _.ForceCustomerStorageForProfiler(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ForceCustomerStorageForProfiler <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#force_customer_storage_for_profiler-1">ApplicationInsights#force_customer_storage_for_profiler</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "force_customer_storage_for_profiler">]
        member _.ForceCustomerStorageForProfiler(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ForceCustomerStorageForProfiler <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#id-1">ApplicationInsights#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#internet_ingestion_enabled-1">ApplicationInsights#internet_ingestion_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_ingestion_enabled">]
        member _.InternetIngestionEnabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetIngestionEnabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#internet_ingestion_enabled-1">ApplicationInsights#internet_ingestion_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_ingestion_enabled">]
        member _.InternetIngestionEnabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetIngestionEnabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#internet_query_enabled-1">ApplicationInsights#internet_query_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_query_enabled">]
        member _.InternetQueryEnabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetQueryEnabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#internet_query_enabled-1">ApplicationInsights#internet_query_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_query_enabled">]
        member _.InternetQueryEnabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetQueryEnabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#local_authentication_disabled-1">ApplicationInsights#local_authentication_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_disabled">]
        member _.LocalAuthenticationDisabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: bool) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationDisabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#local_authentication_disabled-1">ApplicationInsights#local_authentication_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_disabled">]
        member _.LocalAuthenticationDisabled(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationDisabled <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#retention_in_days-1">ApplicationInsights#retention_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_in_days">]
        member _.RetentionInDays(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: double) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RetentionInDays <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#sampling_percentage-1">ApplicationInsights#sampling_percentage</a>.
        /// </summary>
        [<CustomOperation "sampling_percentage">]
        member _.SamplingPercentage(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: double) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SamplingPercentage <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#tags-1">ApplicationInsights#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#timeouts-1">ApplicationInsights#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ApplicationInsights.ApplicationInsightsTimeouts) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights#workspace_id-1">ApplicationInsights#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            state : ApplicationInsightsState<'ApplicationType, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ApplicationInsightsState<Present, Present, Present, Present>) : azurerm.ApplicationInsights.ApplicationInsights =
            let config = azurerm.ApplicationInsights.ApplicationInsightsConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationInsights.ApplicationInsights(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationInsights: missing required arguments. Must call: application_type, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationInsightsState<_, _, _, _>) : azurerm.ApplicationInsights.ApplicationInsights =
            Unchecked.defaultof<azurerm.ApplicationInsights.ApplicationInsights>
