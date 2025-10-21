namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxBackupState = { assignments: ResizeArray<aws.FsxBackup.FsxBackupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup">aws_fsx_backup</a>.
    /// </summary>
    type FsxBackupBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxBackupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : FsxBackupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup#file_system_id-1">FsxBackup#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: FsxBackupState, value: string) : FsxBackupState =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            state : FsxBackupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup#id-1">FsxBackup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxBackupState, value: string) : FsxBackupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxBackupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup#tags-1">FsxBackup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxBackupState, value: seq<string * string>) : FsxBackupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxBackupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup#tags_all-1">FsxBackup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxBackupState, value: seq<string * string>) : FsxBackupState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxBackupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup#timeouts-1">FsxBackup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxBackupState, value: aws.FsxBackup.FsxBackupTimeouts) : FsxBackupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxBackupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_backup#volume_id-1">FsxBackup#volume_id</a>.
        /// </summary>
        [<CustomOperation "volume_id">]
        member _.VolumeId(state: FsxBackupState, value: string) : FsxBackupState =
            state.assignments.Add(fun config -> config.VolumeId <- value)
            state : FsxBackupState

        member _.Run(state: FsxBackupState) : aws.FsxBackup.FsxBackup =
            let config = aws.FsxBackup.FsxBackupConfig()
            for setter in state.assignments do
                setter config
            aws.FsxBackup.FsxBackup(StackContext.get (), logicalId, config)
