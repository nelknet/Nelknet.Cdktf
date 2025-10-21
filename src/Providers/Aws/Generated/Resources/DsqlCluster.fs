namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DsqlClusterState = { assignments: ResizeArray<aws.DsqlCluster.DsqlClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster">aws_dsql_cluster</a>.
    /// </summary>
    type DsqlClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DsqlClusterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DsqlClusterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#deletion_protection_enabled-1">DsqlCluster#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: DsqlClusterState, value: bool) : DsqlClusterState =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : DsqlClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#deletion_protection_enabled-1">DsqlCluster#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: DsqlClusterState, value: HashiCorp.Cdktf.IResolvable) : DsqlClusterState =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : DsqlClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#kms_encryption_key-1">DsqlCluster#kms_encryption_key</a>.
        /// </summary>
        [<CustomOperation "kms_encryption_key">]
        member _.KmsEncryptionKey(state: DsqlClusterState, value: string) : DsqlClusterState =
            state.assignments.Add(fun config -> config.KmsEncryptionKey <- value)
            state : DsqlClusterState

        /// <summary>
        /// multi_region_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#multi_region_properties-1">DsqlCluster#multi_region_properties</a> Accepts: aws.IResolvable | aws.DsqlCluster.DsqlClusterMultiRegionProperties[]
        /// </summary>
        [<CustomOperation "multi_region_properties">]
        member _.MultiRegionProperties(state: DsqlClusterState, value: HashiCorp.Cdktf.IResolvable) : DsqlClusterState =
            state.assignments.Add(fun config -> config.MultiRegionProperties <- value)
            state : DsqlClusterState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#tags-1">DsqlCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DsqlClusterState, value: seq<string * string>) : DsqlClusterState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DsqlClusterState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#timeouts-1">DsqlCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DsqlClusterState, value: aws.DsqlCluster.DsqlClusterTimeouts) : DsqlClusterState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DsqlClusterState

        member _.Run(state: DsqlClusterState) : aws.DsqlCluster.DsqlCluster =
            let config = aws.DsqlCluster.DsqlClusterConfig()
            for setter in state.assignments do
                setter config
            aws.DsqlCluster.DsqlCluster(StackContext.get (), logicalId, config)
