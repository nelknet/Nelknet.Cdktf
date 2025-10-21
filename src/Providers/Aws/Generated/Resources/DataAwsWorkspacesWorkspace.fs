namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWorkspacesWorkspaceState = { assignments: ResizeArray<aws.DataAwsWorkspacesWorkspace.DataAwsWorkspacesWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_workspace">aws_workspaces_workspace</a>.
    /// </summary>
    type DataAwsWorkspacesWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWorkspacesWorkspaceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsWorkspacesWorkspaceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_workspace#directory_id-1">DataAwsWorkspacesWorkspace#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DataAwsWorkspacesWorkspaceState, value: string) : DataAwsWorkspacesWorkspaceState =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            state : DataAwsWorkspacesWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_workspace#id-1">DataAwsWorkspacesWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWorkspacesWorkspaceState, value: string) : DataAwsWorkspacesWorkspaceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWorkspacesWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_workspace#tags-1">DataAwsWorkspacesWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsWorkspacesWorkspaceState, value: seq<string * string>) : DataAwsWorkspacesWorkspaceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsWorkspacesWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_workspace#user_name-1">DataAwsWorkspacesWorkspace#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: DataAwsWorkspacesWorkspaceState, value: string) : DataAwsWorkspacesWorkspaceState =
            state.assignments.Add(fun config -> config.UserName <- value)
            state : DataAwsWorkspacesWorkspaceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_workspace#workspace_id-1">DataAwsWorkspacesWorkspace#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: DataAwsWorkspacesWorkspaceState, value: string) : DataAwsWorkspacesWorkspaceState =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            state : DataAwsWorkspacesWorkspaceState

        member _.Run(state: DataAwsWorkspacesWorkspaceState) : aws.DataAwsWorkspacesWorkspace.DataAwsWorkspacesWorkspace =
            let config = aws.DataAwsWorkspacesWorkspace.DataAwsWorkspacesWorkspaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWorkspacesWorkspace.DataAwsWorkspacesWorkspace(StackContext.get (), logicalId, config)
