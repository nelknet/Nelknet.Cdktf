namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MemorydbSnapshotState<'ClusterName> = { assignments: ResizeArray<aws.MemorydbSnapshot.MemorydbSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot">aws_memorydb_snapshot</a>.
    /// </summary>
    type MemorydbSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : MemorydbSnapshotState<Missing> =
            ({ assignments = ResizeArray() } : MemorydbSnapshotState<Missing>)

        member _.Zero(()) : MemorydbSnapshotState<Missing> =
            ({ assignments = ResizeArray() } : MemorydbSnapshotState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#cluster_name-1">MemorydbSnapshot#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: MemorydbSnapshotState<Missing>, value: string) : MemorydbSnapshotState<Present> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : MemorydbSnapshotState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#id-1">MemorydbSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MemorydbSnapshotState<'ClusterName>, value: string) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MemorydbSnapshotState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#kms_key_arn-1">MemorydbSnapshot#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: MemorydbSnapshotState<'ClusterName>, value: string) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : MemorydbSnapshotState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#name-1">MemorydbSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MemorydbSnapshotState<'ClusterName>, value: string) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MemorydbSnapshotState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#name_prefix-1">MemorydbSnapshot#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: MemorydbSnapshotState<'ClusterName>, value: string) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : MemorydbSnapshotState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#tags-1">MemorydbSnapshot#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MemorydbSnapshotState<'ClusterName>, value: seq<string * string>) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MemorydbSnapshotState<'ClusterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#tags_all-1">MemorydbSnapshot#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MemorydbSnapshotState<'ClusterName>, value: seq<string * string>) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MemorydbSnapshotState<'ClusterName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_snapshot#timeouts-1">MemorydbSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MemorydbSnapshotState<'ClusterName>, value: aws.MemorydbSnapshot.MemorydbSnapshotTimeouts) : MemorydbSnapshotState<'ClusterName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MemorydbSnapshotState<'ClusterName>

        member _.Run(state: MemorydbSnapshotState<Present>) : aws.MemorydbSnapshot.MemorydbSnapshot =
            let config = aws.MemorydbSnapshot.MemorydbSnapshotConfig()
            for setter in state.assignments do
                setter config
            aws.MemorydbSnapshot.MemorydbSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.memorydbSnapshot: missing required arguments. Must call: cluster_name.", 9999, IsError = true)>]
        member _.Run(_: MemorydbSnapshotState<_>) : aws.MemorydbSnapshot.MemorydbSnapshot =
            Unchecked.defaultof<aws.MemorydbSnapshot.MemorydbSnapshot>
