namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> = { assignments: ResizeArray<aws.GrafanaWorkspace.GrafanaWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace">aws_grafana_workspace</a>.
    /// </summary>
    type GrafanaWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : GrafanaWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : GrafanaWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GrafanaWorkspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#account_access_type-1">GrafanaWorkspace#account_access_type</a>.
        /// </summary>
        [<CustomOperation "account_access_type">]
        member _.AccountAccessType(state: GrafanaWorkspaceState<Missing, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<Present, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.AccountAccessType <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceState<Present, 'AuthenticationProviders, 'PermissionType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#authentication_providers-1">GrafanaWorkspace#authentication_providers</a>.
        /// </summary>
        [<CustomOperation "authentication_providers">]
        member _.AuthenticationProviders(state: GrafanaWorkspaceState<'AccountAccessType, Missing, 'PermissionType>, value: seq<string>) : GrafanaWorkspaceState<'AccountAccessType, Present, 'PermissionType> =
            state.assignments.Add(fun config -> config.AuthenticationProviders <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : GrafanaWorkspaceState<'AccountAccessType, Present, 'PermissionType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#permission_type-1">GrafanaWorkspace#permission_type</a>.
        /// </summary>
        [<CustomOperation "permission_type">]
        member _.PermissionType(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, Missing>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, Present> =
            state.assignments.Add(fun config -> config.PermissionType <- value)
            ({ assignments = state.assignments } : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#configuration-1">GrafanaWorkspace#configuration</a>.
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#data_sources-1">GrafanaWorkspace#data_sources</a>.
        /// </summary>
        [<CustomOperation "data_sources">]
        member _.DataSources(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: seq<string>) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.DataSources <- (value |> Seq.toArray))
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#description-1">GrafanaWorkspace#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#grafana_version-1">GrafanaWorkspace#grafana_version</a>.
        /// </summary>
        [<CustomOperation "grafana_version">]
        member _.GrafanaVersion(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.GrafanaVersion <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#id-1">GrafanaWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#name-1">GrafanaWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// network_access_control block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#network_access_control-1">GrafanaWorkspace#network_access_control</a>
        /// </summary>
        [<CustomOperation "network_access_control">]
        member _.NetworkAccessControl(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: aws.GrafanaWorkspace.GrafanaWorkspaceNetworkAccessControl) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.NetworkAccessControl <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#notification_destinations-1">GrafanaWorkspace#notification_destinations</a>.
        /// </summary>
        [<CustomOperation "notification_destinations">]
        member _.NotificationDestinations(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: seq<string>) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.NotificationDestinations <- (value |> Seq.toArray))
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#organizational_units-1">GrafanaWorkspace#organizational_units</a>.
        /// </summary>
        [<CustomOperation "organizational_units">]
        member _.OrganizationalUnits(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: seq<string>) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.OrganizationalUnits <- (value |> Seq.toArray))
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#organization_role_name-1">GrafanaWorkspace#organization_role_name</a>.
        /// </summary>
        [<CustomOperation "organization_role_name">]
        member _.OrganizationRoleName(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.OrganizationRoleName <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#role_arn-1">GrafanaWorkspace#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#stack_set_name-1">GrafanaWorkspace#stack_set_name</a>.
        /// </summary>
        [<CustomOperation "stack_set_name">]
        member _.StackSetName(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: string) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.StackSetName <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#tags-1">GrafanaWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: seq<string * string>) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#tags_all-1">GrafanaWorkspace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: seq<string * string>) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#timeouts-1">GrafanaWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: aws.GrafanaWorkspace.GrafanaWorkspaceTimeouts) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        /// <summary>
        /// vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#vpc_configuration-1">GrafanaWorkspace#vpc_configuration</a>
        /// </summary>
        [<CustomOperation "vpc_configuration">]
        member _.VpcConfiguration(state: GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>, value: aws.GrafanaWorkspace.GrafanaWorkspaceVpcConfiguration) : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType> =
            state.assignments.Add(fun config -> config.VpcConfiguration <- value)
            state : GrafanaWorkspaceState<'AccountAccessType, 'AuthenticationProviders, 'PermissionType>

        member _.Run(state: GrafanaWorkspaceState<Present, Present, Present>) : aws.GrafanaWorkspace.GrafanaWorkspace =
            let config = aws.GrafanaWorkspace.GrafanaWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.GrafanaWorkspace.GrafanaWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.grafanaWorkspace: missing required arguments. Must call: account_access_type, authentication_providers, permission_type.", 9999, IsError = true)>]
        member _.Run(_: GrafanaWorkspaceState<_, _, _>) : aws.GrafanaWorkspace.GrafanaWorkspace =
            Unchecked.defaultof<aws.GrafanaWorkspace.GrafanaWorkspace>
