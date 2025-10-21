namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspaceswebDataProtectionSettingsState<'DisplayName> = { assignments: ResizeArray<aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings">aws_workspacesweb_data_protection_settings</a>.
    /// </summary>
    type WorkspaceswebDataProtectionSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspaceswebDataProtectionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebDataProtectionSettingsState<Missing>)

        member _.Zero(()) : WorkspaceswebDataProtectionSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebDataProtectionSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#display_name-1">WorkspaceswebDataProtectionSettings#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: WorkspaceswebDataProtectionSettingsState<Missing>, value: string) : WorkspaceswebDataProtectionSettingsState<Present> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : WorkspaceswebDataProtectionSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#additional_encryption_context-1">WorkspaceswebDataProtectionSettings#additional_encryption_context</a>.
        /// </summary>
        [<CustomOperation "additional_encryption_context">]
        member _.AdditionalEncryptionContext(state: WorkspaceswebDataProtectionSettingsState<'DisplayName>, value: seq<string * string>) : WorkspaceswebDataProtectionSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.AdditionalEncryptionContext <- dict value)
            state : WorkspaceswebDataProtectionSettingsState<'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#customer_managed_key-1">WorkspaceswebDataProtectionSettings#customer_managed_key</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: WorkspaceswebDataProtectionSettingsState<'DisplayName>, value: string) : WorkspaceswebDataProtectionSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : WorkspaceswebDataProtectionSettingsState<'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#description-1">WorkspaceswebDataProtectionSettings#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: WorkspaceswebDataProtectionSettingsState<'DisplayName>, value: string) : WorkspaceswebDataProtectionSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : WorkspaceswebDataProtectionSettingsState<'DisplayName>

        /// <summary>
        /// inline_redaction_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#inline_redaction_configuration-1">WorkspaceswebDataProtectionSettings#inline_redaction_configuration</a> Accepts: aws.IResolvable | aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettingsInlineRedactionConfiguration[]
        /// </summary>
        [<CustomOperation "inline_redaction_configuration">]
        member _.InlineRedactionConfiguration(state: WorkspaceswebDataProtectionSettingsState<'DisplayName>, value: HashiCorp.Cdktf.IResolvable) : WorkspaceswebDataProtectionSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.InlineRedactionConfiguration <- value)
            state : WorkspaceswebDataProtectionSettingsState<'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_data_protection_settings#tags-1">WorkspaceswebDataProtectionSettings#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspaceswebDataProtectionSettingsState<'DisplayName>, value: seq<string * string>) : WorkspaceswebDataProtectionSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspaceswebDataProtectionSettingsState<'DisplayName>

        member _.Run(state: WorkspaceswebDataProtectionSettingsState<Present>) : aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettings =
            let config = aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspaceswebDataProtectionSettings: missing required arguments. Must call: display_name.", 9999, IsError = true)>]
        member _.Run(_: WorkspaceswebDataProtectionSettingsState<_>) : aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettings =
            Unchecked.defaultof<aws.WorkspaceswebDataProtectionSettings.WorkspaceswebDataProtectionSettings>
