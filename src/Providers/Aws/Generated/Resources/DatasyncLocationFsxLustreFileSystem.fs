namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns> = { assignments: ResizeArray<aws.DatasyncLocationFsxLustreFileSystem.DatasyncLocationFsxLustreFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system">aws_datasync_location_fsx_lustre_file_system</a>.
    /// </summary>
    type DatasyncLocationFsxLustreFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationFsxLustreFileSystemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxLustreFileSystemState<Missing, Missing>)

        member _.Zero(()) : DatasyncLocationFsxLustreFileSystemState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxLustreFileSystemState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system#fsx_filesystem_arn-1">DatasyncLocationFsxLustreFileSystem#fsx_filesystem_arn</a>.
        /// </summary>
        [<CustomOperation "fsx_filesystem_arn">]
        member _.FsxFilesystemArn(state: DatasyncLocationFsxLustreFileSystemState<Missing, 'SecurityGroupArns>, value: string) : DatasyncLocationFsxLustreFileSystemState<Present, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.FsxFilesystemArn <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxLustreFileSystemState<Present, 'SecurityGroupArns>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system#security_group_arns-1">DatasyncLocationFsxLustreFileSystem#security_group_arns</a>.
        /// </summary>
        [<CustomOperation "security_group_arns">]
        member _.SecurityGroupArns(state: DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, Missing>, value: seq<string>) : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, Present> =
            state.assignments.Add(fun config -> config.SecurityGroupArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system#id-1">DatasyncLocationFsxLustreFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>, value: string) : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system#subdirectory-1">DatasyncLocationFsxLustreFileSystem#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>, value: string) : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system#tags-1">DatasyncLocationFsxLustreFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>, value: seq<string * string>) : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_lustre_file_system#tags_all-1">DatasyncLocationFsxLustreFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>, value: seq<string * string>) : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationFsxLustreFileSystemState<'FsxFilesystemArn, 'SecurityGroupArns>

        member _.Run(state: DatasyncLocationFsxLustreFileSystemState<Present, Present>) : aws.DatasyncLocationFsxLustreFileSystem.DatasyncLocationFsxLustreFileSystem =
            let config = aws.DatasyncLocationFsxLustreFileSystem.DatasyncLocationFsxLustreFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationFsxLustreFileSystem.DatasyncLocationFsxLustreFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationFsxLustreFileSystem: missing required arguments. Must call: fsx_filesystem_arn, security_group_arns.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationFsxLustreFileSystemState<_, _>) : aws.DatasyncLocationFsxLustreFileSystem.DatasyncLocationFsxLustreFileSystem =
            Unchecked.defaultof<aws.DatasyncLocationFsxLustreFileSystem.DatasyncLocationFsxLustreFileSystem>
