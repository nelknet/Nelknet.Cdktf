namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns> = { assignments: ResizeArray<aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system">aws_datasync_location_fsx_openzfs_file_system</a>.
    /// </summary>
    type DatasyncLocationFsxOpenzfsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationFsxOpenzfsFileSystemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxOpenzfsFileSystemState<Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationFsxOpenzfsFileSystemState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxOpenzfsFileSystemState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#fsx_filesystem_arn-1">DatasyncLocationFsxOpenzfsFileSystem#fsx_filesystem_arn</a>.
        /// </summary>
        [<CustomOperation "fsx_filesystem_arn">]
        member _.FsxFilesystemArn(state: DatasyncLocationFsxOpenzfsFileSystemState<Missing, 'Protocol, 'SecurityGroupArns>, value: string) : DatasyncLocationFsxOpenzfsFileSystemState<Present, 'Protocol, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.FsxFilesystemArn <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxOpenzfsFileSystemState<Present, 'Protocol, 'SecurityGroupArns>)

        /// <summary>
        /// protocol block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#protocol-1">DatasyncLocationFsxOpenzfsFileSystem#protocol</a>
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, Missing, 'SecurityGroupArns>, value: aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemProtocol) : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, Present, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, Present, 'SecurityGroupArns>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#security_group_arns-1">DatasyncLocationFsxOpenzfsFileSystem#security_group_arns</a>.
        /// </summary>
        [<CustomOperation "security_group_arns">]
        member _.SecurityGroupArns(state: DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, Missing>, value: seq<string>) : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, Present> =
            state.assignments.Add(fun config -> config.SecurityGroupArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#id-1">DatasyncLocationFsxOpenzfsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>, value: string) : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#subdirectory-1">DatasyncLocationFsxOpenzfsFileSystem#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>, value: string) : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#tags-1">DatasyncLocationFsxOpenzfsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>, value: seq<string * string>) : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_openzfs_file_system#tags_all-1">DatasyncLocationFsxOpenzfsFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>, value: seq<string * string>) : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationFsxOpenzfsFileSystemState<'FsxFilesystemArn, 'Protocol, 'SecurityGroupArns>

        member _.Run(state: DatasyncLocationFsxOpenzfsFileSystemState<Present, Present, Present>) : aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystem =
            let config = aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationFsxOpenzfsFileSystem: missing required arguments. Must call: fsx_filesystem_arn, protocol, security_group_arns.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationFsxOpenzfsFileSystemState<_, _, _>) : aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystem =
            Unchecked.defaultof<aws.DatasyncLocationFsxOpenzfsFileSystem.DatasyncLocationFsxOpenzfsFileSystem>
