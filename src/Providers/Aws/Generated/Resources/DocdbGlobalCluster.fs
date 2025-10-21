namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DocdbGlobalClusterState<'GlobalClusterIdentifier> = { assignments: ResizeArray<aws.DocdbGlobalCluster.DocdbGlobalClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster">aws_docdb_global_cluster</a>.
    /// </summary>
    type DocdbGlobalClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DocdbGlobalClusterState<Missing> =
            ({ assignments = ResizeArray() } : DocdbGlobalClusterState<Missing>)

        member _.Zero(()) : DocdbGlobalClusterState<Missing> =
            ({ assignments = ResizeArray() } : DocdbGlobalClusterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#global_cluster_identifier-1">DocdbGlobalCluster#global_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "global_cluster_identifier">]
        member _.GlobalClusterIdentifier(state: DocdbGlobalClusterState<Missing>, value: string) : DocdbGlobalClusterState<Present> =
            state.assignments.Add(fun config -> config.GlobalClusterIdentifier <- value)
            ({ assignments = state.assignments } : DocdbGlobalClusterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#database_name-1">DocdbGlobalCluster#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: string) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#deletion_protection-1">DocdbGlobalCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#deletion_protection-1">DocdbGlobalCluster#deletion_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#engine-1">DocdbGlobalCluster#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: string) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#engine_version-1">DocdbGlobalCluster#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: string) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#id-1">DocdbGlobalCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: string) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#source_db_cluster_identifier-1">DocdbGlobalCluster#source_db_cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "source_db_cluster_identifier">]
        member _.SourceDbClusterIdentifier(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: string) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.SourceDbClusterIdentifier <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#storage_encrypted-1">DocdbGlobalCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: bool) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#storage_encrypted-1">DocdbGlobalCluster#storage_encrypted</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "storage_encrypted">]
        member _.StorageEncrypted(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: HashiCorp.Cdktf.IResolvable) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.StorageEncrypted <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_global_cluster#timeouts-1">DocdbGlobalCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DocdbGlobalClusterState<'GlobalClusterIdentifier>, value: aws.DocdbGlobalCluster.DocdbGlobalClusterTimeouts) : DocdbGlobalClusterState<'GlobalClusterIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DocdbGlobalClusterState<'GlobalClusterIdentifier>

        member _.Run(state: DocdbGlobalClusterState<Present>) : aws.DocdbGlobalCluster.DocdbGlobalCluster =
            let config = aws.DocdbGlobalCluster.DocdbGlobalClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DocdbGlobalCluster.DocdbGlobalCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.docdbGlobalCluster: missing required arguments. Must call: global_cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: DocdbGlobalClusterState<_>) : aws.DocdbGlobalCluster.DocdbGlobalCluster =
            Unchecked.defaultof<aws.DocdbGlobalCluster.DocdbGlobalCluster>
