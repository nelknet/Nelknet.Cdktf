namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> = { assignments: ResizeArray<aws.WorkspacesWorkspace.WorkspacesWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace">aws_workspaces_workspace</a>.
    /// </summary>
    type WorkspacesWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspacesWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkspacesWorkspaceState<Missing, Missing, Missing>)

        member _.Zero(()) : WorkspacesWorkspaceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkspacesWorkspaceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#bundle_id-1">WorkspacesWorkspace#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: WorkspacesWorkspaceState<Missing, 'DirectoryId, 'UserName>, value: string) : WorkspacesWorkspaceState<Present, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            ({ assignments = state.assignments } : WorkspacesWorkspaceState<Present, 'DirectoryId, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#directory_id-1">WorkspacesWorkspace#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: WorkspacesWorkspaceState<'BundleId, Missing, 'UserName>, value: string) : WorkspacesWorkspaceState<'BundleId, Present, 'UserName> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : WorkspacesWorkspaceState<'BundleId, Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#user_name-1">WorkspacesWorkspace#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, Missing>, value: string) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#id-1">WorkspacesWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: string) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#root_volume_encryption_enabled-1">WorkspacesWorkspace#root_volume_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "root_volume_encryption_enabled">]
        member _.RootVolumeEncryptionEnabled(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: bool) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.RootVolumeEncryptionEnabled <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#root_volume_encryption_enabled-1">WorkspacesWorkspace#root_volume_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "root_volume_encryption_enabled">]
        member _.RootVolumeEncryptionEnabled(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.RootVolumeEncryptionEnabled <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#tags-1">WorkspacesWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: seq<string * string>) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#tags_all-1">WorkspacesWorkspace#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: seq<string * string>) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#timeouts-1">WorkspacesWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: aws.WorkspacesWorkspace.WorkspacesWorkspaceTimeouts) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#user_volume_encryption_enabled-1">WorkspacesWorkspace#user_volume_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_volume_encryption_enabled">]
        member _.UserVolumeEncryptionEnabled(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: bool) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.UserVolumeEncryptionEnabled <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#user_volume_encryption_enabled-1">WorkspacesWorkspace#user_volume_encryption_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "user_volume_encryption_enabled">]
        member _.UserVolumeEncryptionEnabled(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: HashiCorp.Cdktf.IResolvable) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.UserVolumeEncryptionEnabled <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#volume_encryption_key-1">WorkspacesWorkspace#volume_encryption_key</a>.
        /// </summary>
        [<CustomOperation "volume_encryption_key">]
        member _.VolumeEncryptionKey(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: string) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.VolumeEncryptionKey <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        /// <summary>
        /// workspace_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_workspace#workspace_properties-1">WorkspacesWorkspace#workspace_properties</a>
        /// </summary>
        [<CustomOperation "workspace_properties">]
        member _.WorkspaceProperties(state: WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>, value: aws.WorkspacesWorkspace.WorkspacesWorkspaceWorkspaceProperties) : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName> =
            state.assignments.Add(fun config -> config.WorkspaceProperties <- value)
            state : WorkspacesWorkspaceState<'BundleId, 'DirectoryId, 'UserName>

        member _.Run(state: WorkspacesWorkspaceState<Present, Present, Present>) : aws.WorkspacesWorkspace.WorkspacesWorkspace =
            let config = aws.WorkspacesWorkspace.WorkspacesWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspacesWorkspace.WorkspacesWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspacesWorkspace: missing required arguments. Must call: bundle_id, directory_id, user_name.", 9999, IsError = true)>]
        member _.Run(_: WorkspacesWorkspaceState<_, _, _>) : aws.WorkspacesWorkspace.WorkspacesWorkspace =
            Unchecked.defaultof<aws.WorkspacesWorkspace.WorkspacesWorkspace>
