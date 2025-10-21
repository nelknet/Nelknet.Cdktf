namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEfsFileSystemState = { assignments: ResizeArray<aws.DataAwsEfsFileSystem.DataAwsEfsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_file_system">aws_efs_file_system</a>.
    /// </summary>
    type DataAwsEfsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEfsFileSystemState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEfsFileSystemState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_file_system#creation_token-1">DataAwsEfsFileSystem#creation_token</a>.
        /// </summary>
        [<CustomOperation "creation_token">]
        member _.CreationToken(state: DataAwsEfsFileSystemState, value: string) : DataAwsEfsFileSystemState =
            state.assignments.Add(fun config -> config.CreationToken <- value)
            state : DataAwsEfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_file_system#file_system_id-1">DataAwsEfsFileSystem#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: DataAwsEfsFileSystemState, value: string) : DataAwsEfsFileSystemState =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            state : DataAwsEfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_file_system#id-1">DataAwsEfsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEfsFileSystemState, value: string) : DataAwsEfsFileSystemState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEfsFileSystemState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/efs_file_system#tags-1">DataAwsEfsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEfsFileSystemState, value: seq<string * string>) : DataAwsEfsFileSystemState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEfsFileSystemState

        member _.Run(state: DataAwsEfsFileSystemState) : aws.DataAwsEfsFileSystem.DataAwsEfsFileSystem =
            let config = aws.DataAwsEfsFileSystem.DataAwsEfsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEfsFileSystem.DataAwsEfsFileSystem(StackContext.get (), logicalId, config)
