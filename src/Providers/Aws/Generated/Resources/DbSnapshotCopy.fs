namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> = { assignments: ResizeArray<aws.DbSnapshotCopy.DbSnapshotCopyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy">aws_db_snapshot_copy</a>.
    /// </summary>
    type DbSnapshotCopyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DbSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbSnapshotCopyState<Missing, Missing>)

        member _.Zero(()) : DbSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DbSnapshotCopyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#source_db_snapshot_identifier-1">DbSnapshotCopy#source_db_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "source_db_snapshot_identifier">]
        member _.SourceDbSnapshotIdentifier(state: DbSnapshotCopyState<Missing, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<Present, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.SourceDbSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : DbSnapshotCopyState<Present, 'TargetDbSnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#target_db_snapshot_identifier-1">DbSnapshotCopy#target_db_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "target_db_snapshot_identifier">]
        member _.TargetDbSnapshotIdentifier(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, Missing>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, Present> =
            state.assignments.Add(fun config -> config.TargetDbSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#copy_tags-1">DbSnapshotCopy#copy_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags">]
        member _.CopyTags(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: bool) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.CopyTags <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#copy_tags-1">DbSnapshotCopy#copy_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags">]
        member _.CopyTags(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.CopyTags <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#destination_region-1">DbSnapshotCopy#destination_region</a>.
        /// </summary>
        [<CustomOperation "destination_region">]
        member _.DestinationRegion(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.DestinationRegion <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#id-1">DbSnapshotCopy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#kms_key_id-1">DbSnapshotCopy#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#option_group_name-1">DbSnapshotCopy#option_group_name</a>.
        /// </summary>
        [<CustomOperation "option_group_name">]
        member _.OptionGroupName(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.OptionGroupName <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#presigned_url-1">DbSnapshotCopy#presigned_url</a>.
        /// </summary>
        [<CustomOperation "presigned_url">]
        member _.PresignedUrl(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.PresignedUrl <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#shared_accounts-1">DbSnapshotCopy#shared_accounts</a>.
        /// </summary>
        [<CustomOperation "shared_accounts">]
        member _.SharedAccounts(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: seq<string>) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.SharedAccounts <- (value |> Seq.toArray))
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#tags-1">DbSnapshotCopy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: seq<string * string>) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#tags_all-1">DbSnapshotCopy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: seq<string * string>) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#target_custom_availability_zone-1">DbSnapshotCopy#target_custom_availability_zone</a>.
        /// </summary>
        [<CustomOperation "target_custom_availability_zone">]
        member _.TargetCustomAvailabilityZone(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: string) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.TargetCustomAvailabilityZone <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_snapshot_copy#timeouts-1">DbSnapshotCopy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>, value: aws.DbSnapshotCopy.DbSnapshotCopyTimeouts) : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DbSnapshotCopyState<'SourceDbSnapshotIdentifier, 'TargetDbSnapshotIdentifier>

        member _.Run(state: DbSnapshotCopyState<Present, Present>) : aws.DbSnapshotCopy.DbSnapshotCopy =
            let config = aws.DbSnapshotCopy.DbSnapshotCopyConfig()
            for setter in state.assignments do
                setter config
            aws.DbSnapshotCopy.DbSnapshotCopy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dbSnapshotCopy: missing required arguments. Must call: source_db_snapshot_identifier, target_db_snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: DbSnapshotCopyState<_, _>) : aws.DbSnapshotCopy.DbSnapshotCopy =
            Unchecked.defaultof<aws.DbSnapshotCopy.DbSnapshotCopy>
