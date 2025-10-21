namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName> = { assignments: ResizeArray<aws.RedshiftSnapshotCopyGrant.RedshiftSnapshotCopyGrantConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy_grant">aws_redshift_snapshot_copy_grant</a>.
    /// </summary>
    type RedshiftSnapshotCopyGrantBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftSnapshotCopyGrantState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotCopyGrantState<Missing>)

        member _.Zero(()) : RedshiftSnapshotCopyGrantState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftSnapshotCopyGrantState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy_grant#snapshot_copy_grant_name-1">RedshiftSnapshotCopyGrant#snapshot_copy_grant_name</a>.
        /// </summary>
        [<CustomOperation "snapshot_copy_grant_name">]
        member _.SnapshotCopyGrantName(state: RedshiftSnapshotCopyGrantState<Missing>, value: string) : RedshiftSnapshotCopyGrantState<Present> =
            state.assignments.Add(fun config -> config.SnapshotCopyGrantName <- value)
            ({ assignments = state.assignments } : RedshiftSnapshotCopyGrantState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy_grant#id-1">RedshiftSnapshotCopyGrant#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>, value: string) : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy_grant#kms_key_id-1">RedshiftSnapshotCopyGrant#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>, value: string) : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy_grant#tags-1">RedshiftSnapshotCopyGrant#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>, value: seq<string * string>) : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_snapshot_copy_grant#tags_all-1">RedshiftSnapshotCopyGrant#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>, value: seq<string * string>) : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftSnapshotCopyGrantState<'SnapshotCopyGrantName>

        member _.Run(state: RedshiftSnapshotCopyGrantState<Present>) : aws.RedshiftSnapshotCopyGrant.RedshiftSnapshotCopyGrant =
            let config = aws.RedshiftSnapshotCopyGrant.RedshiftSnapshotCopyGrantConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftSnapshotCopyGrant.RedshiftSnapshotCopyGrant(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftSnapshotCopyGrant: missing required arguments. Must call: snapshot_copy_grant_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftSnapshotCopyGrantState<_>) : aws.RedshiftSnapshotCopyGrant.RedshiftSnapshotCopyGrant =
            Unchecked.defaultof<aws.RedshiftSnapshotCopyGrant.RedshiftSnapshotCopyGrant>
