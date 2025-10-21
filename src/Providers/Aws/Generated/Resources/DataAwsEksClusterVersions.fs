namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksClusterVersionsState = { assignments: ResizeArray<aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions">aws_eks_cluster_versions</a>.
    /// </summary>
    type DataAwsEksClusterVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksClusterVersionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEksClusterVersionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#cluster_type-1">DataAwsEksClusterVersions#cluster_type</a>.
        /// </summary>
        [<CustomOperation "cluster_type">]
        member _.ClusterType(state: DataAwsEksClusterVersionsState, value: string) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.ClusterType <- value)
            state : DataAwsEksClusterVersionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#cluster_versions_only-1">DataAwsEksClusterVersions#cluster_versions_only</a>.
        /// </summary>
        [<CustomOperation "cluster_versions_only">]
        member _.ClusterVersionsOnly(state: DataAwsEksClusterVersionsState, value: seq<string>) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.ClusterVersionsOnly <- (value |> Seq.toArray))
            state : DataAwsEksClusterVersionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#default_only-1">DataAwsEksClusterVersions#default_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_only">]
        member _.DefaultOnly(state: DataAwsEksClusterVersionsState, value: bool) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.DefaultOnly <- value)
            state : DataAwsEksClusterVersionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#default_only-1">DataAwsEksClusterVersions#default_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_only">]
        member _.DefaultOnly(state: DataAwsEksClusterVersionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.DefaultOnly <- value)
            state : DataAwsEksClusterVersionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#include_all-1">DataAwsEksClusterVersions#include_all</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_all">]
        member _.IncludeAll(state: DataAwsEksClusterVersionsState, value: bool) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.IncludeAll <- value)
            state : DataAwsEksClusterVersionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#include_all-1">DataAwsEksClusterVersions#include_all</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_all">]
        member _.IncludeAll(state: DataAwsEksClusterVersionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.IncludeAll <- value)
            state : DataAwsEksClusterVersionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_versions#version_status-1">DataAwsEksClusterVersions#version_status</a>.
        /// </summary>
        [<CustomOperation "version_status">]
        member _.VersionStatus(state: DataAwsEksClusterVersionsState, value: string) : DataAwsEksClusterVersionsState =
            state.assignments.Add(fun config -> config.VersionStatus <- value)
            state : DataAwsEksClusterVersionsState

        member _.Run(state: DataAwsEksClusterVersionsState) : aws.DataAwsEksClusterVersions.DataAwsEksClusterVersions =
            let config = aws.DataAwsEksClusterVersions.DataAwsEksClusterVersionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksClusterVersions.DataAwsEksClusterVersions(StackContext.get (), logicalId, config)
