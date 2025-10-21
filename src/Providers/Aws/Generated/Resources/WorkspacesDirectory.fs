namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspacesDirectoryState = { assignments: ResizeArray<aws.WorkspacesDirectory.WorkspacesDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory">aws_workspaces_directory</a>.
    /// </summary>
    type WorkspacesDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspacesDirectoryState =
            { assignments = ResizeArray() }

        member _.Zero(()) : WorkspacesDirectoryState =
            { assignments = ResizeArray() }

        /// <summary>
        /// active_directory_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#active_directory_config-1">WorkspacesDirectory#active_directory_config</a>
        /// </summary>
        [<CustomOperation "active_directory_config">]
        member _.ActiveDirectoryConfig(state: WorkspacesDirectoryState, value: aws.WorkspacesDirectory.WorkspacesDirectoryActiveDirectoryConfig) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.ActiveDirectoryConfig <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// certificate_based_auth_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#certificate_based_auth_properties-1">WorkspacesDirectory#certificate_based_auth_properties</a>
        /// </summary>
        [<CustomOperation "certificate_based_auth_properties">]
        member _.CertificateBasedAuthProperties(state: WorkspacesDirectoryState, value: aws.WorkspacesDirectory.WorkspacesDirectoryCertificateBasedAuthProperties) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.CertificateBasedAuthProperties <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#directory_id-1">WorkspacesDirectory#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: WorkspacesDirectoryState, value: string) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#id-1">WorkspacesDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorkspacesDirectoryState, value: string) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#ip_group_ids-1">WorkspacesDirectory#ip_group_ids</a>.
        /// </summary>
        [<CustomOperation "ip_group_ids">]
        member _.IpGroupIds(state: WorkspacesDirectoryState, value: seq<string>) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.IpGroupIds <- (value |> Seq.toArray))
            state : WorkspacesDirectoryState

        /// <summary>
        /// saml_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#saml_properties-1">WorkspacesDirectory#saml_properties</a>
        /// </summary>
        [<CustomOperation "saml_properties">]
        member _.SamlProperties(state: WorkspacesDirectoryState, value: aws.WorkspacesDirectory.WorkspacesDirectorySamlProperties) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.SamlProperties <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// self_service_permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#self_service_permissions-1">WorkspacesDirectory#self_service_permissions</a>
        /// </summary>
        [<CustomOperation "self_service_permissions">]
        member _.SelfServicePermissions(state: WorkspacesDirectoryState, value: aws.WorkspacesDirectory.WorkspacesDirectorySelfServicePermissions) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.SelfServicePermissions <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#subnet_ids-1">WorkspacesDirectory#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: WorkspacesDirectoryState, value: seq<string>) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#tags-1">WorkspacesDirectory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspacesDirectoryState, value: seq<string * string>) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#tags_all-1">WorkspacesDirectory#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WorkspacesDirectoryState, value: seq<string * string>) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#user_identity_type-1">WorkspacesDirectory#user_identity_type</a>.
        /// </summary>
        [<CustomOperation "user_identity_type">]
        member _.UserIdentityType(state: WorkspacesDirectoryState, value: string) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.UserIdentityType <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// workspace_access_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_access_properties-1">WorkspacesDirectory#workspace_access_properties</a>
        /// </summary>
        [<CustomOperation "workspace_access_properties">]
        member _.WorkspaceAccessProperties(state: WorkspacesDirectoryState, value: aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceAccessProperties) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.WorkspaceAccessProperties <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// workspace_creation_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_creation_properties-1">WorkspacesDirectory#workspace_creation_properties</a>
        /// </summary>
        [<CustomOperation "workspace_creation_properties">]
        member _.WorkspaceCreationProperties(state: WorkspacesDirectoryState, value: aws.WorkspacesDirectory.WorkspacesDirectoryWorkspaceCreationProperties) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.WorkspaceCreationProperties <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_directory_description-1">WorkspacesDirectory#workspace_directory_description</a>.
        /// </summary>
        [<CustomOperation "workspace_directory_description">]
        member _.WorkspaceDirectoryDescription(state: WorkspacesDirectoryState, value: string) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.WorkspaceDirectoryDescription <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_directory_name-1">WorkspacesDirectory#workspace_directory_name</a>.
        /// </summary>
        [<CustomOperation "workspace_directory_name">]
        member _.WorkspaceDirectoryName(state: WorkspacesDirectoryState, value: string) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.WorkspaceDirectoryName <- value)
            state : WorkspacesDirectoryState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#workspace_type-1">WorkspacesDirectory#workspace_type</a>.
        /// </summary>
        [<CustomOperation "workspace_type">]
        member _.WorkspaceType(state: WorkspacesDirectoryState, value: string) : WorkspacesDirectoryState =
            state.assignments.Add(fun config -> config.WorkspaceType <- value)
            state : WorkspacesDirectoryState

        member _.Run(state: WorkspacesDirectoryState) : aws.WorkspacesDirectory.WorkspacesDirectory =
            let config = aws.WorkspacesDirectory.WorkspacesDirectoryConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspacesDirectory.WorkspacesDirectory(StackContext.get (), logicalId, config)
