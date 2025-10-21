namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsGlobalClusterState<'GlobalClusterIdentifier> = { assignments: ResizeArray<aws.RdsGlobalCluster.RdsGlobalClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster">aws_rds_global_cluster</a>.
    /// </summary>
    type RdsGlobalClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsGlobalClusterState<Missing> =
            ({ assignments = ResizeArray() } : RdsGlobalClusterState<Missing>)

        member _.Zero(()) : RdsGlobalClusterState<Missing> =
            ({ assignments = ResizeArray() } : RdsGlobalClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#global_cluster_identifier-1">RdsGlobalCluster#global_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "global_cluster_identifier">]
        member _.GlobalClusterIdentifier(state: RdsGlobalClusterState<Missing>, value: string) : RdsGlobalClusterState<Present> =
            state.assignments.Add(fun config -> config.GlobalClusterIdentifier <- value)
            ({ assignments = state.assignments } : RdsGlobalClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#database_name-1">RdsGlobalCluster#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: string) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#deletion_protection-1">RdsGlobalCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#deletion_protection-1">RdsGlobalCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#engine-1">RdsGlobalCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: string) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#engine_lifecycle_support-1">RdsGlobalCluster#engine_lifecycle_support</a>.
        /// </summary>
        [<CustomOperation "engine_lifecycle_support">]
        member _.EngineLifecycleSupport(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: string) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.EngineLifecycleSupport <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#engine_version-1">RdsGlobalCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: string) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#force_destroy-1">RdsGlobalCluster#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#force_destroy-1">RdsGlobalCluster#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#id-1">RdsGlobalCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: string) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#source_db_cluster_identifier-1">RdsGlobalCluster#source_db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "source_db_cluster_identifier">]
        member _.SourceDbClusterIdentifier(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: string) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.SourceDbClusterIdentifier <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#storage_encrypted-1">RdsGlobalCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#storage_encrypted-1">RdsGlobalCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#tags-1">RdsGlobalCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: seq<string * string>) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#tags_all-1">RdsGlobalCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: seq<string * string>) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_global_cluster#timeouts-1">RdsGlobalCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsGlobalClusterState<'GlobalClusterIdentifier>, value: aws.RdsGlobalCluster.RdsGlobalClusterTimeouts) : RdsGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsGlobalClusterState<'GlobalClusterIdentifier>

        member _.Run(state: RdsGlobalClusterState<Present>) : aws.RdsGlobalCluster.RdsGlobalCluster =
            let config = aws.RdsGlobalCluster.RdsGlobalClusterConfig()
            for setter in state.assignments do
                setter config
            aws.RdsGlobalCluster.RdsGlobalCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsGlobalCluster: missing required arguments. Must call: global_cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: RdsGlobalClusterState<_>) : aws.RdsGlobalCluster.RdsGlobalCluster =
            Unchecked.defaultof<aws.RdsGlobalCluster.RdsGlobalCluster>
