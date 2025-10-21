namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsSnapshotImportState<'DiskContainer> = { assignments: ResizeArray<aws.EbsSnapshotImport.EbsSnapshotImportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import">aws_ebs_snapshot_import</a>.
    /// </summary>
    type EbsSnapshotImportBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsSnapshotImportState<Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotImportState<Missing>)

        member _.Zero(()) : EbsSnapshotImportState<Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotImportState<Missing>)

        /// <summary>
        /// disk_container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#disk_container-1">EbsSnapshotImport#disk_container</a>
        /// </summary>
        [<CustomOperation "disk_container">]
        member _.DiskContainer(state: EbsSnapshotImportState<Missing>, value: aws.EbsSnapshotImport.EbsSnapshotImportDiskContainer) : EbsSnapshotImportState<Present> =
            state.assignments.Add(fun config -> config.DiskContainer <- value)
            ({ assignments = state.assignments } : EbsSnapshotImportState<Present>)

        /// <summary>
        /// client_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#client_data-1">EbsSnapshotImport#client_data</a>
        /// </summary>
        [<CustomOperation "client_data">]
        member _.ClientData(state: EbsSnapshotImportState<'DiskContainer>, value: aws.EbsSnapshotImport.EbsSnapshotImportClientData) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.ClientData <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#description-1">EbsSnapshotImport#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EbsSnapshotImportState<'DiskContainer>, value: string) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#encrypted-1">EbsSnapshotImport#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EbsSnapshotImportState<'DiskContainer>, value: bool) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#encrypted-1">EbsSnapshotImport#encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "encrypted">]
        member _.Encrypted(state: EbsSnapshotImportState<'DiskContainer>, value: HashiCorp.Cdktf.IResolvable) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.Encrypted <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#id-1">EbsSnapshotImport#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsSnapshotImportState<'DiskContainer>, value: string) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#kms_key_id-1">EbsSnapshotImport#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: EbsSnapshotImportState<'DiskContainer>, value: string) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#permanent_restore-1">EbsSnapshotImport#permanent_restore</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "permanent_restore">]
        member _.PermanentRestore(state: EbsSnapshotImportState<'DiskContainer>, value: bool) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.PermanentRestore <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#permanent_restore-1">EbsSnapshotImport#permanent_restore</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "permanent_restore">]
        member _.PermanentRestore(state: EbsSnapshotImportState<'DiskContainer>, value: HashiCorp.Cdktf.IResolvable) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.PermanentRestore <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#role_name-1">EbsSnapshotImport#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: EbsSnapshotImportState<'DiskContainer>, value: string) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#storage_tier-1">EbsSnapshotImport#storage_tier</a>.
        /// </summary>
        [<CustomOperation "storage_tier">]
        member _.StorageTier(state: EbsSnapshotImportState<'DiskContainer>, value: string) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.StorageTier <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#tags-1">EbsSnapshotImport#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EbsSnapshotImportState<'DiskContainer>, value: seq<string * string>) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#tags_all-1">EbsSnapshotImport#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EbsSnapshotImportState<'DiskContainer>, value: seq<string * string>) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#temporary_restore_days-1">EbsSnapshotImport#temporary_restore_days</a>.
        /// </summary>
        [<CustomOperation "temporary_restore_days">]
        member _.TemporaryRestoreDays(state: EbsSnapshotImportState<'DiskContainer>, value: double) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.TemporaryRestoreDays <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_import#timeouts-1">EbsSnapshotImport#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EbsSnapshotImportState<'DiskContainer>, value: aws.EbsSnapshotImport.EbsSnapshotImportTimeouts) : EbsSnapshotImportState<'DiskContainer> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EbsSnapshotImportState<'DiskContainer>

        member _.Run(state: EbsSnapshotImportState<Present>) : aws.EbsSnapshotImport.EbsSnapshotImport =
            let config = aws.EbsSnapshotImport.EbsSnapshotImportConfig()
            for setter in state.assignments do
                setter config
            aws.EbsSnapshotImport.EbsSnapshotImport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsSnapshotImport: missing required arguments. Must call: disk_container.", 9999, IsError = true)>]
        member _.Run(_: EbsSnapshotImportState<_>) : aws.EbsSnapshotImport.EbsSnapshotImport =
            Unchecked.defaultof<aws.EbsSnapshotImport.EbsSnapshotImport>
