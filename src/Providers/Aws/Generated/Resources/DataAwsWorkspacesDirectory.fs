namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsWorkspacesDirectoryState<'DirectoryId> = { assignments: ResizeArray<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory">aws_workspaces_directory</a>.
    /// </summary>
    type DataAwsWorkspacesDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsWorkspacesDirectoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWorkspacesDirectoryState<Missing>)

        member _.Zero(()) : DataAwsWorkspacesDirectoryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsWorkspacesDirectoryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory#directory_id-1">DataAwsWorkspacesDirectory#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DataAwsWorkspacesDirectoryState<Missing>, value: string) : DataAwsWorkspacesDirectoryState<Present> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DataAwsWorkspacesDirectoryState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory#id-1">DataAwsWorkspacesDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsWorkspacesDirectoryState<'DirectoryId>, value: string) : DataAwsWorkspacesDirectoryState<'DirectoryId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsWorkspacesDirectoryState<'DirectoryId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/workspaces_directory#tags-1">DataAwsWorkspacesDirectory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsWorkspacesDirectoryState<'DirectoryId>, value: seq<string * string>) : DataAwsWorkspacesDirectoryState<'DirectoryId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsWorkspacesDirectoryState<'DirectoryId>

        member _.Run(state: DataAwsWorkspacesDirectoryState<Present>) : aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory =
            let config = aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectoryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsWorkspacesDirectory: missing required arguments. Must call: directory_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsWorkspacesDirectoryState<_>) : aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory =
            Unchecked.defaultof<aws.DataAwsWorkspacesDirectory.DataAwsWorkspacesDirectory>
