namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceSourceControlSlotState<'SlotId> = { assignments: ResizeArray<azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot">azurerm_app_service_source_control_slot</a>.
    /// </summary>
    type AppServiceSourceControlSlotBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceSourceControlSlotState<Missing> =
            ({ assignments = ResizeArray() } : AppServiceSourceControlSlotState<Missing>)

        member _.Zero(()) : AppServiceSourceControlSlotState<Missing> =
            ({ assignments = ResizeArray() } : AppServiceSourceControlSlotState<Missing>)

        /// <summary>
        /// The ID of the Linux or Windows Web App Slot. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#slot_id-1">AppServiceSourceControlSlot#slot_id</a>
        /// </summary>
        [<CustomOperation "slot_id">]
        member _.SlotId(state: AppServiceSourceControlSlotState<Missing>, value: string) : AppServiceSourceControlSlotState<Present> =
            state.assignments.Add(fun config -> config.SlotId <- value)
            ({ assignments = state.assignments } : AppServiceSourceControlSlotState<Present>)

        /// <summary>
        /// The URL for the repository. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#branch-1">AppServiceSourceControlSlot#branch</a>
        /// </summary>
        [<CustomOperation "branch">]
        member _.Branch(state: AppServiceSourceControlSlotState<'SlotId>, value: string) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Branch <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// github_action_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#github_action_configuration-1">AppServiceSourceControlSlot#github_action_configuration</a>
        /// </summary>
        [<CustomOperation "github_action_configuration">]
        member _.GithubActionConfiguration(state: AppServiceSourceControlSlotState<'SlotId>, value: azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlotGithubActionConfiguration) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.GithubActionConfiguration <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#id-1">AppServiceSourceControlSlot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceSourceControlSlotState<'SlotId>, value: string) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// The branch name to use for deployments. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#repo_url-1">AppServiceSourceControlSlot#repo_url</a>
        /// </summary>
        [<CustomOperation "repo_url">]
        member _.RepoUrl(state: AppServiceSourceControlSlotState<'SlotId>, value: string) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.RepoUrl <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Should the Deployment Rollback be enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#rollback_enabled-1">AppServiceSourceControlSlot#rollback_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "rollback_enabled">]
        member _.RollbackEnabled(state: AppServiceSourceControlSlotState<'SlotId>, value: bool) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.RollbackEnabled <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Should the Deployment Rollback be enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#rollback_enabled-1">AppServiceSourceControlSlot#rollback_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "rollback_enabled">]
        member _.RollbackEnabled(state: AppServiceSourceControlSlotState<'SlotId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.RollbackEnabled <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#timeouts-1">AppServiceSourceControlSlot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceSourceControlSlotState<'SlotId>, value: azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlotTimeouts) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Should the Slot use local Git configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_local_git-1">AppServiceSourceControlSlot#use_local_git</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_local_git">]
        member _.UseLocalGit(state: AppServiceSourceControlSlotState<'SlotId>, value: bool) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.UseLocalGit <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Should the Slot use local Git configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_local_git-1">AppServiceSourceControlSlot#use_local_git</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_local_git">]
        member _.UseLocalGit(state: AppServiceSourceControlSlotState<'SlotId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.UseLocalGit <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false` Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_manual_integration-1">AppServiceSourceControlSlot#use_manual_integration</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_manual_integration">]
        member _.UseManualIntegration(state: AppServiceSourceControlSlotState<'SlotId>, value: bool) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.UseManualIntegration <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false` Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_manual_integration-1">AppServiceSourceControlSlot#use_manual_integration</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_manual_integration">]
        member _.UseManualIntegration(state: AppServiceSourceControlSlotState<'SlotId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.UseManualIntegration <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// The repository specified is Mercurial. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_mercurial-1">AppServiceSourceControlSlot#use_mercurial</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_mercurial">]
        member _.UseMercurial(state: AppServiceSourceControlSlotState<'SlotId>, value: bool) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.UseMercurial <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        /// <summary>
        /// The repository specified is Mercurial. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_slot#use_mercurial-1">AppServiceSourceControlSlot#use_mercurial</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_mercurial">]
        member _.UseMercurial(state: AppServiceSourceControlSlotState<'SlotId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlSlotState<'SlotId> =
            state.assignments.Add(fun config -> config.UseMercurial <- value)
            state : AppServiceSourceControlSlotState<'SlotId>

        member _.Run(state: AppServiceSourceControlSlotState<Present>) : azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlot =
            let config = azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlotConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceSourceControlSlot: missing required arguments. Must call: slot_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceSourceControlSlotState<_>) : azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlot =
            Unchecked.defaultof<azurerm.AppServiceSourceControlSlot.AppServiceSourceControlSlot>
