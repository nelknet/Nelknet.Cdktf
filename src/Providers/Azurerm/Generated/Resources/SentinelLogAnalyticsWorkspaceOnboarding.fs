namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId> = { assignments: ResizeArray<azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboardingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_log_analytics_workspace_onboarding">azurerm_sentinel_log_analytics_workspace_onboarding</a>.
    /// </summary>
    type SentinelLogAnalyticsWorkspaceOnboardingBuilder(logicalId: string) =
        member _.Yield(_: unit) : SentinelLogAnalyticsWorkspaceOnboardingState<Missing> =
            ({ assignments = ResizeArray() } : SentinelLogAnalyticsWorkspaceOnboardingState<Missing>)

        member _.Zero(()) : SentinelLogAnalyticsWorkspaceOnboardingState<Missing> =
            ({ assignments = ResizeArray() } : SentinelLogAnalyticsWorkspaceOnboardingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_log_analytics_workspace_onboarding#workspace_id-1">SentinelLogAnalyticsWorkspaceOnboarding#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: SentinelLogAnalyticsWorkspaceOnboardingState<Missing>, value: string) : SentinelLogAnalyticsWorkspaceOnboardingState<Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : SentinelLogAnalyticsWorkspaceOnboardingState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_log_analytics_workspace_onboarding#customer_managed_key_enabled-1">SentinelLogAnalyticsWorkspaceOnboarding#customer_managed_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "customer_managed_key_enabled">]
        member _.CustomerManagedKeyEnabled(state: SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>, value: bool) : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyEnabled <- value)
            state : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_log_analytics_workspace_onboarding#customer_managed_key_enabled-1">SentinelLogAnalyticsWorkspaceOnboarding#customer_managed_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "customer_managed_key_enabled">]
        member _.CustomerManagedKeyEnabled(state: SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyEnabled <- value)
            state : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_log_analytics_workspace_onboarding#id-1">SentinelLogAnalyticsWorkspaceOnboarding#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>, value: string) : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_log_analytics_workspace_onboarding#timeouts-1">SentinelLogAnalyticsWorkspaceOnboarding#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>, value: azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboardingTimeouts) : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SentinelLogAnalyticsWorkspaceOnboardingState<'WorkspaceId>

        member _.Run(state: SentinelLogAnalyticsWorkspaceOnboardingState<Present>) : azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboarding =
            let config = azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboardingConfig()
            for setter in state.assignments do
                setter config
            azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboarding(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sentinelLogAnalyticsWorkspaceOnboarding: missing required arguments. Must call: workspace_id.", 9999, IsError = true)>]
        member _.Run(_: SentinelLogAnalyticsWorkspaceOnboardingState<_>) : azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboarding =
            Unchecked.defaultof<azurerm.SentinelLogAnalyticsWorkspaceOnboarding.SentinelLogAnalyticsWorkspaceOnboarding>
