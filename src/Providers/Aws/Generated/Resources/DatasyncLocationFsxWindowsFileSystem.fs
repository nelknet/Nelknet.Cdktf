namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User> = { assignments: ResizeArray<aws.DatasyncLocationFsxWindowsFileSystem.DatasyncLocationFsxWindowsFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system">aws_datasync_location_fsx_windows_file_system</a>.
    /// </summary>
    type DatasyncLocationFsxWindowsFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationFsxWindowsFileSystemState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxWindowsFileSystemState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationFsxWindowsFileSystemState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationFsxWindowsFileSystemState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#fsx_filesystem_arn-1">DatasyncLocationFsxWindowsFileSystem#fsx_filesystem_arn</a>.
        /// </summary>
        [<CustomOperation "fsx_filesystem_arn">]
        member _.FsxFilesystemArn(state: DatasyncLocationFsxWindowsFileSystemState<Missing, 'Password, 'SecurityGroupArns, 'User>, value: string) : DatasyncLocationFsxWindowsFileSystemState<Present, 'Password, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.FsxFilesystemArn <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxWindowsFileSystemState<Present, 'Password, 'SecurityGroupArns, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#password-1">DatasyncLocationFsxWindowsFileSystem#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, Missing, 'SecurityGroupArns, 'User>, value: string) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, Present, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, Present, 'SecurityGroupArns, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#security_group_arns-1">DatasyncLocationFsxWindowsFileSystem#security_group_arns</a>.
        /// </summary>
        [<CustomOperation "security_group_arns">]
        member _.SecurityGroupArns(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, Missing, 'User>, value: seq<string>) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, Present, 'User> =
            state.assignments.Add(fun config -> config.SecurityGroupArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, Present, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#user-1">DatasyncLocationFsxWindowsFileSystem#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, Missing>, value: string) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#domain-1">DatasyncLocationFsxWindowsFileSystem#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>, value: string) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#id-1">DatasyncLocationFsxWindowsFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>, value: string) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#subdirectory-1">DatasyncLocationFsxWindowsFileSystem#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>, value: string) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            state : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#tags-1">DatasyncLocationFsxWindowsFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>, value: seq<string * string>) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_fsx_windows_file_system#tags_all-1">DatasyncLocationFsxWindowsFileSystem#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>, value: seq<string * string>) : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationFsxWindowsFileSystemState<'FsxFilesystemArn, 'Password, 'SecurityGroupArns, 'User>

        member _.Run(state: DatasyncLocationFsxWindowsFileSystemState<Present, Present, Present, Present>) : aws.DatasyncLocationFsxWindowsFileSystem.DatasyncLocationFsxWindowsFileSystem =
            let config = aws.DatasyncLocationFsxWindowsFileSystem.DatasyncLocationFsxWindowsFileSystemConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationFsxWindowsFileSystem.DatasyncLocationFsxWindowsFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationFsxWindowsFileSystem: missing required arguments. Must call: fsx_filesystem_arn, password, security_group_arns, user.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationFsxWindowsFileSystemState<_, _, _, _>) : aws.DatasyncLocationFsxWindowsFileSystem.DatasyncLocationFsxWindowsFileSystem =
            Unchecked.defaultof<aws.DatasyncLocationFsxWindowsFileSystem.DatasyncLocationFsxWindowsFileSystem>
