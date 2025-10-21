namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceSourceControlAState<'AppId> = { assignments: ResizeArray<azurerm.AppServiceSourceControl.AppServiceSourceControlAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control">azurerm_app_service_source_control</a>.
    /// </summary>
    type AppServiceSourceControlABuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceSourceControlAState<Missing> =
            ({ assignments = ResizeArray() } : AppServiceSourceControlAState<Missing>)

        member _.Zero(()) : AppServiceSourceControlAState<Missing> =
            ({ assignments = ResizeArray() } : AppServiceSourceControlAState<Missing>)

        /// <summary>
        /// The ID of the Windows or Linux Web App. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#app_id-1">AppServiceSourceControlA#app_id</a>
        /// </summary>
        [<CustomOperation "app_id">]
        member _.AppId(state: AppServiceSourceControlAState<Missing>, value: string) : AppServiceSourceControlAState<Present> =
            state.assignments.Add(fun config -> config.AppId <- value)
            ({ assignments = state.assignments } : AppServiceSourceControlAState<Present>)

        /// <summary>
        /// The branch name to use for deployments. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#branch-1">AppServiceSourceControlA#branch</a>
        /// </summary>
        [<CustomOperation "branch">]
        member _.Branch(state: AppServiceSourceControlAState<'AppId>, value: string) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.Branch <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// github_action_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#github_action_configuration-1">AppServiceSourceControlA#github_action_configuration</a>
        /// </summary>
        [<CustomOperation "github_action_configuration">]
        member _.GithubActionConfiguration(state: AppServiceSourceControlAState<'AppId>, value: azurerm.AppServiceSourceControl.AppServiceSourceControlGithubActionConfiguration) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.GithubActionConfiguration <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#id-1">AppServiceSourceControlA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceSourceControlAState<'AppId>, value: string) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// The URL for the repository. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#repo_url-1">AppServiceSourceControlA#repo_url</a>
        /// </summary>
        [<CustomOperation "repo_url">]
        member _.RepoUrl(state: AppServiceSourceControlAState<'AppId>, value: string) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.RepoUrl <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Should the Deployment Rollback be enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#rollback_enabled-1">AppServiceSourceControlA#rollback_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "rollback_enabled">]
        member _.RollbackEnabled(state: AppServiceSourceControlAState<'AppId>, value: bool) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.RollbackEnabled <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Should the Deployment Rollback be enabled? Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#rollback_enabled-1">AppServiceSourceControlA#rollback_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "rollback_enabled">]
        member _.RollbackEnabled(state: AppServiceSourceControlAState<'AppId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.RollbackEnabled <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#timeouts-1">AppServiceSourceControlA#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceSourceControlAState<'AppId>, value: azurerm.AppServiceSourceControl.AppServiceSourceControlTimeouts) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Should the App use local Git configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#use_local_git-1">AppServiceSourceControlA#use_local_git</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_local_git">]
        member _.UseLocalGit(state: AppServiceSourceControlAState<'AppId>, value: bool) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.UseLocalGit <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Should the App use local Git configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#use_local_git-1">AppServiceSourceControlA#use_local_git</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_local_git">]
        member _.UseLocalGit(state: AppServiceSourceControlAState<'AppId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.UseLocalGit <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#use_manual_integration-1">AppServiceSourceControlA#use_manual_integration</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_manual_integration">]
        member _.UseManualIntegration(state: AppServiceSourceControlAState<'AppId>, value: bool) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.UseManualIntegration <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#use_manual_integration-1">AppServiceSourceControlA#use_manual_integration</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_manual_integration">]
        member _.UseManualIntegration(state: AppServiceSourceControlAState<'AppId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.UseManualIntegration <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// The repository specified is Mercurial. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#use_mercurial-1">AppServiceSourceControlA#use_mercurial</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_mercurial">]
        member _.UseMercurial(state: AppServiceSourceControlAState<'AppId>, value: bool) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.UseMercurial <- value)
            state : AppServiceSourceControlAState<'AppId>

        /// <summary>
        /// The repository specified is Mercurial. Defaults to `false`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control#use_mercurial-1">AppServiceSourceControlA#use_mercurial</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_mercurial">]
        member _.UseMercurial(state: AppServiceSourceControlAState<'AppId>, value: HashiCorp.Cdktf.IResolvable) : AppServiceSourceControlAState<'AppId> =
            state.assignments.Add(fun config -> config.UseMercurial <- value)
            state : AppServiceSourceControlAState<'AppId>

        member _.Run(state: AppServiceSourceControlAState<Present>) : azurerm.AppServiceSourceControl.AppServiceSourceControlA =
            let config = azurerm.AppServiceSourceControl.AppServiceSourceControlAConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceSourceControl.AppServiceSourceControlA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceSourceControlA: missing required arguments. Must call: app_id.", 9999, IsError = true)>]
        member _.Run(_: AppServiceSourceControlAState<_>) : azurerm.AppServiceSourceControl.AppServiceSourceControlA =
            Unchecked.defaultof<azurerm.AppServiceSourceControl.AppServiceSourceControlA>
