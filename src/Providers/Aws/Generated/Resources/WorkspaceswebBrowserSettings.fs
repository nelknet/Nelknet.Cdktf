namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspaceswebBrowserSettingsState<'BrowserPolicy> = { assignments: ResizeArray<aws.WorkspaceswebBrowserSettings.WorkspaceswebBrowserSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_browser_settings">aws_workspacesweb_browser_settings</a>.
    /// </summary>
    type WorkspaceswebBrowserSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspaceswebBrowserSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebBrowserSettingsState<Missing>)

        member _.Zero(()) : WorkspaceswebBrowserSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebBrowserSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_browser_settings#browser_policy-1">WorkspaceswebBrowserSettings#browser_policy</a>.
        /// </summary>
        [<CustomOperation "browser_policy">]
        member _.BrowserPolicy(state: WorkspaceswebBrowserSettingsState<Missing>, value: string) : WorkspaceswebBrowserSettingsState<Present> =
            state.assignments.Add(fun config -> config.BrowserPolicy <- value)
            ({ assignments = state.assignments } : WorkspaceswebBrowserSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_browser_settings#additional_encryption_context-1">WorkspaceswebBrowserSettings#additional_encryption_context</a>.
        /// </summary>
        [<CustomOperation "additional_encryption_context">]
        member _.AdditionalEncryptionContext(state: WorkspaceswebBrowserSettingsState<'BrowserPolicy>, value: seq<string * string>) : WorkspaceswebBrowserSettingsState<'BrowserPolicy> =
            state.assignments.Add(fun config -> config.AdditionalEncryptionContext <- dict value)
            state : WorkspaceswebBrowserSettingsState<'BrowserPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_browser_settings#customer_managed_key-1">WorkspaceswebBrowserSettings#customer_managed_key</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: WorkspaceswebBrowserSettingsState<'BrowserPolicy>, value: string) : WorkspaceswebBrowserSettingsState<'BrowserPolicy> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : WorkspaceswebBrowserSettingsState<'BrowserPolicy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_browser_settings#tags-1">WorkspaceswebBrowserSettings#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspaceswebBrowserSettingsState<'BrowserPolicy>, value: seq<string * string>) : WorkspaceswebBrowserSettingsState<'BrowserPolicy> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspaceswebBrowserSettingsState<'BrowserPolicy>

        member _.Run(state: WorkspaceswebBrowserSettingsState<Present>) : aws.WorkspaceswebBrowserSettings.WorkspaceswebBrowserSettings =
            let config = aws.WorkspaceswebBrowserSettings.WorkspaceswebBrowserSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspaceswebBrowserSettings.WorkspaceswebBrowserSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspaceswebBrowserSettings: missing required arguments. Must call: browser_policy.", 9999, IsError = true)>]
        member _.Run(_: WorkspaceswebBrowserSettingsState<_>) : aws.WorkspaceswebBrowserSettings.WorkspaceswebBrowserSettings =
            Unchecked.defaultof<aws.WorkspaceswebBrowserSettings.WorkspaceswebBrowserSettings>
