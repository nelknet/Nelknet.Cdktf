namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptuneGlobalClusterState<'GlobalClusterIdentifier> = { assignments: ResizeArray<aws.NeptuneGlobalCluster.NeptuneGlobalClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster">aws_neptune_global_cluster</a>.
    /// </summary>
    type NeptuneGlobalClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptuneGlobalClusterState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneGlobalClusterState<Missing>)

        member _.Zero(()) : NeptuneGlobalClusterState<Missing> =
            ({ assignments = ResizeArray() } : NeptuneGlobalClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#global_cluster_identifier-1">NeptuneGlobalCluster#global_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "global_cluster_identifier">]
        member _.GlobalClusterIdentifier(state: NeptuneGlobalClusterState<Missing>, value: string) : NeptuneGlobalClusterState<Present> =
            state.assignments.Add(fun config -> config.GlobalClusterIdentifier <- value)
            ({ assignments = state.assignments } : NeptuneGlobalClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#deletion_protection-1">NeptuneGlobalCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#deletion_protection-1">NeptuneGlobalCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#engine-1">NeptuneGlobalCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: string) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#engine_version-1">NeptuneGlobalCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: string) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#id-1">NeptuneGlobalCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: string) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#source_db_cluster_identifier-1">NeptuneGlobalCluster#source_db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "source_db_cluster_identifier">]
        member _.SourceDbClusterIdentifier(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: string) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.SourceDbClusterIdentifier <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#storage_encrypted-1">NeptuneGlobalCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#storage_encrypted-1">NeptuneGlobalCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_global_cluster#timeouts-1">NeptuneGlobalCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NeptuneGlobalClusterState<'GlobalClusterIdentifier>, value: aws.NeptuneGlobalCluster.NeptuneGlobalClusterTimeouts) : NeptuneGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NeptuneGlobalClusterState<'GlobalClusterIdentifier>

        member _.Run(state: NeptuneGlobalClusterState<Present>) : aws.NeptuneGlobalCluster.NeptuneGlobalCluster =
            let config = aws.NeptuneGlobalCluster.NeptuneGlobalClusterConfig()
            for setter in state.assignments do
                setter config
            aws.NeptuneGlobalCluster.NeptuneGlobalCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptuneGlobalCluster: missing required arguments. Must call: global_cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: NeptuneGlobalClusterState<_>) : aws.NeptuneGlobalCluster.NeptuneGlobalCluster =
            Unchecked.defaultof<aws.NeptuneGlobalCluster.NeptuneGlobalCluster>
