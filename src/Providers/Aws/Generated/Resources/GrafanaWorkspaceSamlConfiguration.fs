namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> = { assignments: ResizeArray<aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration">aws_grafana_workspace_saml_configuration</a>.
    /// </summary>
    type GrafanaWorkspaceSamlConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaWorkspaceSamlConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceSamlConfigurationState<Missing, Missing>)

        member _.Zero(()) : GrafanaWorkspaceSamlConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceSamlConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#editor_role_values-1">GrafanaWorkspaceSamlConfiguration#editor_role_values</a>.
        /// </summary>
        [<CustomOperation "editor_role_values">]
        member _.EditorRoleValues(state: GrafanaWorkspaceSamlConfigurationState<Missing, 'WorkspaceId>, value: seq<string>) : GrafanaWorkspaceSamlConfigurationState<Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.EditorRoleValues <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : GrafanaWorkspaceSamlConfigurationState<Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#workspace_id-1">GrafanaWorkspaceSamlConfiguration#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, Missing>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#admin_role_values-1">GrafanaWorkspaceSamlConfiguration#admin_role_values</a>.
        /// </summary>
        [<CustomOperation "admin_role_values">]
        member _.AdminRoleValues(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: seq<string>) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AdminRoleValues <- (value |> Seq.toArray))
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#allowed_organizations-1">GrafanaWorkspaceSamlConfiguration#allowed_organizations</a>.
        /// </summary>
        [<CustomOperation "allowed_organizations">]
        member _.AllowedOrganizations(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: seq<string>) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AllowedOrganizations <- (value |> Seq.toArray))
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#email_assertion-1">GrafanaWorkspaceSamlConfiguration#email_assertion</a>.
        /// </summary>
        [<CustomOperation "email_assertion">]
        member _.EmailAssertion(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.EmailAssertion <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#groups_assertion-1">GrafanaWorkspaceSamlConfiguration#groups_assertion</a>.
        /// </summary>
        [<CustomOperation "groups_assertion">]
        member _.GroupsAssertion(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.GroupsAssertion <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#id-1">GrafanaWorkspaceSamlConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#idp_metadata_url-1">GrafanaWorkspaceSamlConfiguration#idp_metadata_url</a>.
        /// </summary>
        [<CustomOperation "idp_metadata_url">]
        member _.IdpMetadataUrl(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.IdpMetadataUrl <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#idp_metadata_xml-1">GrafanaWorkspaceSamlConfiguration#idp_metadata_xml</a>.
        /// </summary>
        [<CustomOperation "idp_metadata_xml">]
        member _.IdpMetadataXml(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.IdpMetadataXml <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#login_assertion-1">GrafanaWorkspaceSamlConfiguration#login_assertion</a>.
        /// </summary>
        [<CustomOperation "login_assertion">]
        member _.LoginAssertion(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.LoginAssertion <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#login_validity_duration-1">GrafanaWorkspaceSamlConfiguration#login_validity_duration</a>.
        /// </summary>
        [<CustomOperation "login_validity_duration">]
        member _.LoginValidityDuration(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: double) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.LoginValidityDuration <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#name_assertion-1">GrafanaWorkspaceSamlConfiguration#name_assertion</a>.
        /// </summary>
        [<CustomOperation "name_assertion">]
        member _.NameAssertion(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.NameAssertion <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#org_assertion-1">GrafanaWorkspaceSamlConfiguration#org_assertion</a>.
        /// </summary>
        [<CustomOperation "org_assertion">]
        member _.OrgAssertion(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.OrgAssertion <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#role_assertion-1">GrafanaWorkspaceSamlConfiguration#role_assertion</a>.
        /// </summary>
        [<CustomOperation "role_assertion">]
        member _.RoleAssertion(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: string) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.RoleAssertion <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace_saml_configuration#timeouts-1">GrafanaWorkspaceSamlConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>, value: aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfigurationTimeouts) : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GrafanaWorkspaceSamlConfigurationState<'EditorRoleValues, 'WorkspaceId>

        member _.Run(state: GrafanaWorkspaceSamlConfigurationState<Present, Present>) : aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfiguration =
            let config = aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaWorkspaceSamlConfiguration: missing required arguments. Must call: editor_role_values, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: GrafanaWorkspaceSamlConfigurationState<_, _>) : aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfiguration =
            Unchecked.defaultof<aws.GrafanaWorkspaceSamlConfiguration.GrafanaWorkspaceSamlConfiguration>
