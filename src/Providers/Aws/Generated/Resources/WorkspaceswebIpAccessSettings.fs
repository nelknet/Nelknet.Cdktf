namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspaceswebIpAccessSettingsState<'DisplayName> = { assignments: ResizeArray<aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings">aws_workspacesweb_ip_access_settings</a>.
    /// </summary>
    type WorkspaceswebIpAccessSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspaceswebIpAccessSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebIpAccessSettingsState<Missing>)

        member _.Zero(()) : WorkspaceswebIpAccessSettingsState<Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebIpAccessSettingsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#display_name-1">WorkspaceswebIpAccessSettings#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: WorkspaceswebIpAccessSettingsState<Missing>, value: string) : WorkspaceswebIpAccessSettingsState<Present> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : WorkspaceswebIpAccessSettingsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#additional_encryption_context-1">WorkspaceswebIpAccessSettings#additional_encryption_context</a>.
        /// </summary>
        [<CustomOperation "additional_encryption_context">]
        member _.AdditionalEncryptionContext(state: WorkspaceswebIpAccessSettingsState<'DisplayName>, value: seq<string * string>) : WorkspaceswebIpAccessSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.AdditionalEncryptionContext <- dict value)
            state : WorkspaceswebIpAccessSettingsState<'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#customer_managed_key-1">WorkspaceswebIpAccessSettings#customer_managed_key</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: WorkspaceswebIpAccessSettingsState<'DisplayName>, value: string) : WorkspaceswebIpAccessSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : WorkspaceswebIpAccessSettingsState<'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#description-1">WorkspaceswebIpAccessSettings#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: WorkspaceswebIpAccessSettingsState<'DisplayName>, value: string) : WorkspaceswebIpAccessSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : WorkspaceswebIpAccessSettingsState<'DisplayName>

        /// <summary>
        /// ip_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#ip_rule-1">WorkspaceswebIpAccessSettings#ip_rule</a> Accepts: aws.IResolvable | aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettingsIpRule[]
        /// </summary>
        [<CustomOperation "ip_rule">]
        member _.IpRule(state: WorkspaceswebIpAccessSettingsState<'DisplayName>, value: HashiCorp.Cdktf.IResolvable) : WorkspaceswebIpAccessSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.IpRule <- value)
            state : WorkspaceswebIpAccessSettingsState<'DisplayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_ip_access_settings#tags-1">WorkspaceswebIpAccessSettings#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspaceswebIpAccessSettingsState<'DisplayName>, value: seq<string * string>) : WorkspaceswebIpAccessSettingsState<'DisplayName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspaceswebIpAccessSettingsState<'DisplayName>

        member _.Run(state: WorkspaceswebIpAccessSettingsState<Present>) : aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettings =
            let config = aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspaceswebIpAccessSettings: missing required arguments. Must call: display_name.", 9999, IsError = true)>]
        member _.Run(_: WorkspaceswebIpAccessSettingsState<_>) : aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettings =
            Unchecked.defaultof<aws.WorkspaceswebIpAccessSettings.WorkspaceswebIpAccessSettings>
