namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> = { assignments: ResizeArray<aws.WorkspaceswebUserSettings.WorkspaceswebUserSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings">aws_workspacesweb_user_settings</a>.
    /// </summary>
    type WorkspaceswebUserSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspaceswebUserSettingsState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebUserSettingsState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : WorkspaceswebUserSettingsState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebUserSettingsState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#copy_allowed-1">WorkspaceswebUserSettings#copy_allowed</a>.
        /// </summary>
        [<CustomOperation "copy_allowed">]
        member _.CopyAllowed(state: WorkspaceswebUserSettingsState<Missing, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: string) : WorkspaceswebUserSettingsState<Present, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.CopyAllowed <- value)
            ({ assignments = state.assignments } : WorkspaceswebUserSettingsState<Present, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#download_allowed-1">WorkspaceswebUserSettings#download_allowed</a>.
        /// </summary>
        [<CustomOperation "download_allowed">]
        member _.DownloadAllowed(state: WorkspaceswebUserSettingsState<'CopyAllowed, Missing, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: string) : WorkspaceswebUserSettingsState<'CopyAllowed, Present, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.DownloadAllowed <- value)
            ({ assignments = state.assignments } : WorkspaceswebUserSettingsState<'CopyAllowed, Present, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#paste_allowed-1">WorkspaceswebUserSettings#paste_allowed</a>.
        /// </summary>
        [<CustomOperation "paste_allowed">]
        member _.PasteAllowed(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, Missing, 'PrintAllowed, 'UploadAllowed>, value: string) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, Present, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.PasteAllowed <- value)
            ({ assignments = state.assignments } : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, Present, 'PrintAllowed, 'UploadAllowed>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#print_allowed-1">WorkspaceswebUserSettings#print_allowed</a>.
        /// </summary>
        [<CustomOperation "print_allowed">]
        member _.PrintAllowed(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, Missing, 'UploadAllowed>, value: string) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, Present, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.PrintAllowed <- value)
            ({ assignments = state.assignments } : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, Present, 'UploadAllowed>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#upload_allowed-1">WorkspaceswebUserSettings#upload_allowed</a>.
        /// </summary>
        [<CustomOperation "upload_allowed">]
        member _.UploadAllowed(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, Missing>, value: string) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, Present> =
            state.assignments.Add(fun config -> config.UploadAllowed <- value)
            ({ assignments = state.assignments } : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#additional_encryption_context-1">WorkspaceswebUserSettings#additional_encryption_context</a>.
        /// </summary>
        [<CustomOperation "additional_encryption_context">]
        member _.AdditionalEncryptionContext(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: seq<string * string>) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.AdditionalEncryptionContext <- dict value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// cookie_synchronization_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#cookie_synchronization_configuration-1">WorkspaceswebUserSettings#cookie_synchronization_configuration</a> Accepts: aws.IResolvable | aws.WorkspaceswebUserSettings.WorkspaceswebUserSettingsCookieSynchronizationConfiguration[]
        /// </summary>
        [<CustomOperation "cookie_synchronization_configuration">]
        member _.CookieSynchronizationConfiguration(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: HashiCorp.Cdktf.IResolvable) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.CookieSynchronizationConfiguration <- value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#customer_managed_key-1">WorkspaceswebUserSettings#customer_managed_key</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: string) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#deep_link_allowed-1">WorkspaceswebUserSettings#deep_link_allowed</a>.
        /// </summary>
        [<CustomOperation "deep_link_allowed">]
        member _.DeepLinkAllowed(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: string) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.DeepLinkAllowed <- value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#disconnect_timeout_in_minutes-1">WorkspaceswebUserSettings#disconnect_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "disconnect_timeout_in_minutes">]
        member _.DisconnectTimeoutInMinutes(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: double) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.DisconnectTimeoutInMinutes <- value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#idle_disconnect_timeout_in_minutes-1">WorkspaceswebUserSettings#idle_disconnect_timeout_in_minutes</a>.
        /// </summary>
        [<CustomOperation "idle_disconnect_timeout_in_minutes">]
        member _.IdleDisconnectTimeoutInMinutes(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: double) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.IdleDisconnectTimeoutInMinutes <- value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#tags-1">WorkspaceswebUserSettings#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: seq<string * string>) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        /// <summary>
        /// toolbar_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_user_settings#toolbar_configuration-1">WorkspaceswebUserSettings#toolbar_configuration</a> Accepts: aws.IResolvable | aws.WorkspaceswebUserSettings.WorkspaceswebUserSettingsToolbarConfiguration[]
        /// </summary>
        [<CustomOperation "toolbar_configuration">]
        member _.ToolbarConfiguration(state: WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>, value: HashiCorp.Cdktf.IResolvable) : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed> =
            state.assignments.Add(fun config -> config.ToolbarConfiguration <- value)
            state : WorkspaceswebUserSettingsState<'CopyAllowed, 'DownloadAllowed, 'PasteAllowed, 'PrintAllowed, 'UploadAllowed>

        member _.Run(state: WorkspaceswebUserSettingsState<Present, Present, Present, Present, Present>) : aws.WorkspaceswebUserSettings.WorkspaceswebUserSettings =
            let config = aws.WorkspaceswebUserSettings.WorkspaceswebUserSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspaceswebUserSettings.WorkspaceswebUserSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspaceswebUserSettings: missing required arguments. Must call: copy_allowed, download_allowed, paste_allowed, print_allowed, upload_allowed.", 9999, IsError = true)>]
        member _.Run(_: WorkspaceswebUserSettingsState<_, _, _, _, _>) : aws.WorkspaceswebUserSettings.WorkspaceswebUserSettings =
            Unchecked.defaultof<aws.WorkspaceswebUserSettings.WorkspaceswebUserSettings>
