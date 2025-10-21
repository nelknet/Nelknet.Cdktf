namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> = { assignments: ResizeArray<aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy">aws_rds_cluster_snapshot_copy</a>.
    /// </summary>
    type RdsClusterSnapshotCopyBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterSnapshotCopyState<Missing, Missing>)

        member _.Zero(()) : RdsClusterSnapshotCopyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterSnapshotCopyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#source_db_cluster_snapshot_identifier-1">RdsClusterSnapshotCopy#source_db_cluster_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "source_db_cluster_snapshot_identifier">]
        member _.SourceDbClusterSnapshotIdentifier(state: RdsClusterSnapshotCopyState<Missing, 'TargetDbClusterSnapshotIdentifier>, value: string) : RdsClusterSnapshotCopyState<Present, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.SourceDbClusterSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : RdsClusterSnapshotCopyState<Present, 'TargetDbClusterSnapshotIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#target_db_cluster_snapshot_identifier-1">RdsClusterSnapshotCopy#target_db_cluster_snapshot_identifier</a>.
        /// </summary>
        [<CustomOperation "target_db_cluster_snapshot_identifier">]
        member _.TargetDbClusterSnapshotIdentifier(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, Missing>, value: string) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, Present> =
            state.assignments.Add(fun config -> config.TargetDbClusterSnapshotIdentifier <- value)
            ({ assignments = state.assignments } : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#copy_tags-1">RdsClusterSnapshotCopy#copy_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags">]
        member _.CopyTags(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: bool) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.CopyTags <- value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#copy_tags-1">RdsClusterSnapshotCopy#copy_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags">]
        member _.CopyTags(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.CopyTags <- value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#destination_region-1">RdsClusterSnapshotCopy#destination_region</a>.
        /// </summary>
        [<CustomOperation "destination_region">]
        member _.DestinationRegion(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: string) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.DestinationRegion <- value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#kms_key_id-1">RdsClusterSnapshotCopy#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: string) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#presigned_url-1">RdsClusterSnapshotCopy#presigned_url</a>.
        /// </summary>
        [<CustomOperation "presigned_url">]
        member _.PresignedUrl(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: string) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.PresignedUrl <- value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#shared_accounts-1">RdsClusterSnapshotCopy#shared_accounts</a>.
        /// </summary>
        [<CustomOperation "shared_accounts">]
        member _.SharedAccounts(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: seq<string>) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.SharedAccounts <- (value |> Seq.toArray))
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#tags-1">RdsClusterSnapshotCopy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: seq<string * string>) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_snapshot_copy#timeouts-1">RdsClusterSnapshotCopy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>, value: aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopyTimeouts) : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsClusterSnapshotCopyState<'SourceDbClusterSnapshotIdentifier, 'TargetDbClusterSnapshotIdentifier>

        member _.Run(state: RdsClusterSnapshotCopyState<Present, Present>) : aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopy =
            let config = aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopyConfig()
            for setter in state.assignments do
                setter config
            aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsClusterSnapshotCopy: missing required arguments. Must call: source_db_cluster_snapshot_identifier, target_db_cluster_snapshot_identifier.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterSnapshotCopyState<_, _>) : aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopy =
            Unchecked.defaultof<aws.RdsClusterSnapshotCopy.RdsClusterSnapshotCopy>
