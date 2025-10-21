namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EksClusterState<'Name, 'RoleArn, 'VpcConfig> = { assignments: ResizeArray<aws.EksCluster.EksClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster">aws_eks_cluster</a>.
    /// </summary>
    type EksClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : EksClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksClusterState<Missing, Missing, Missing>)

        member _.Zero(()) : EksClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EksClusterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#name-1">EksCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EksClusterState<Missing, 'RoleArn, 'VpcConfig>, value: string) : EksClusterState<Present, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EksClusterState<Present, 'RoleArn, 'VpcConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#role_arn-1">EksCluster#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: EksClusterState<'Name, Missing, 'VpcConfig>, value: string) : EksClusterState<'Name, Present, 'VpcConfig> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : EksClusterState<'Name, Present, 'VpcConfig>)

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#vpc_config-1">EksCluster#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: EksClusterState<'Name, 'RoleArn, Missing>, value: aws.EksCluster.EksClusterVpcConfig) : EksClusterState<'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            ({ assignments = state.assignments } : EksClusterState<'Name, 'RoleArn, Present>)

        /// <summary>
        /// access_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#access_config-1">EksCluster#access_config</a>
        /// </summary>
        [<CustomOperation "access_config">]
        member _.AccessConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterAccessConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.AccessConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#bootstrap_self_managed_addons-1">EksCluster#bootstrap_self_managed_addons</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bootstrap_self_managed_addons">]
        member _.BootstrapSelfManagedAddons(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: bool) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.BootstrapSelfManagedAddons <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#bootstrap_self_managed_addons-1">EksCluster#bootstrap_self_managed_addons</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bootstrap_self_managed_addons">]
        member _.BootstrapSelfManagedAddons(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: HashiCorp.Cdktf.IResolvable) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.BootstrapSelfManagedAddons <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// compute_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#compute_config-1">EksCluster#compute_config</a>
        /// </summary>
        [<CustomOperation "compute_config">]
        member _.ComputeConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterComputeConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.ComputeConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#enabled_cluster_log_types-1">EksCluster#enabled_cluster_log_types</a>.
        /// </summary>
        [<CustomOperation "enabled_cluster_log_types">]
        member _.EnabledClusterLogTypes(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: seq<string>) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.EnabledClusterLogTypes <- (value |> Seq.toArray))
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// encryption_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#encryption_config-1">EksCluster#encryption_config</a>
        /// </summary>
        [<CustomOperation "encryption_config">]
        member _.EncryptionConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterEncryptionConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.EncryptionConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#force_update_version-1">EksCluster#force_update_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update_version">]
        member _.ForceUpdateVersion(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: bool) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.ForceUpdateVersion <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#force_update_version-1">EksCluster#force_update_version</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update_version">]
        member _.ForceUpdateVersion(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: HashiCorp.Cdktf.IResolvable) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.ForceUpdateVersion <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#id-1">EksCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: string) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// kubernetes_network_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#kubernetes_network_config-1">EksCluster#kubernetes_network_config</a>
        /// </summary>
        [<CustomOperation "kubernetes_network_config">]
        member _.KubernetesNetworkConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterKubernetesNetworkConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.KubernetesNetworkConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// outpost_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#outpost_config-1">EksCluster#outpost_config</a>
        /// </summary>
        [<CustomOperation "outpost_config">]
        member _.OutpostConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterOutpostConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.OutpostConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// remote_network_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#remote_network_config-1">EksCluster#remote_network_config</a>
        /// </summary>
        [<CustomOperation "remote_network_config">]
        member _.RemoteNetworkConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterRemoteNetworkConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.RemoteNetworkConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// storage_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#storage_config-1">EksCluster#storage_config</a>
        /// </summary>
        [<CustomOperation "storage_config">]
        member _.StorageConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterStorageConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.StorageConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#tags-1">EksCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: seq<string * string>) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#tags_all-1">EksCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: seq<string * string>) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#timeouts-1">EksCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterTimeouts) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// upgrade_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#upgrade_policy-1">EksCluster#upgrade_policy</a>
        /// </summary>
        [<CustomOperation "upgrade_policy">]
        member _.UpgradePolicy(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterUpgradePolicy) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.UpgradePolicy <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#version-1">EksCluster#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: string) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        /// <summary>
        /// zonal_shift_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#zonal_shift_config-1">EksCluster#zonal_shift_config</a>
        /// </summary>
        [<CustomOperation "zonal_shift_config">]
        member _.ZonalShiftConfig(state: EksClusterState<'Name, 'RoleArn, 'VpcConfig>, value: aws.EksCluster.EksClusterZonalShiftConfig) : EksClusterState<'Name, 'RoleArn, 'VpcConfig> =
            state.assignments.Add(fun config -> config.ZonalShiftConfig <- value)
            state : EksClusterState<'Name, 'RoleArn, 'VpcConfig>

        member _.Run(state: EksClusterState<Present, Present, Present>) : aws.EksCluster.EksCluster =
            let config = aws.EksCluster.EksClusterConfig()
            for setter in state.assignments do
                setter config
            aws.EksCluster.EksCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.eksCluster: missing required arguments. Must call: name, role_arn, vpc_config.", 9999, IsError = true)>]
        member _.Run(_: EksClusterState<_, _, _>) : aws.EksCluster.EksCluster =
            Unchecked.defaultof<aws.EksCluster.EksCluster>
