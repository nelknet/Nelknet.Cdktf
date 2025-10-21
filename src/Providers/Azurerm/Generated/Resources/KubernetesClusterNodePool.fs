namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> = { assignments: ResizeArray<azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool">azurerm_kubernetes_cluster_node_pool</a>.
    /// </summary>
    type KubernetesClusterNodePoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesClusterNodePoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterNodePoolState<Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesClusterNodePoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterNodePoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#kubernetes_cluster_id-1">KubernetesClusterNodePool#kubernetes_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_cluster_id">]
        member _.KubernetesClusterId(state: KubernetesClusterNodePoolState<Missing, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<Present, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.KubernetesClusterId <- value)
            ({ assignments = state.assignments } : KubernetesClusterNodePoolState<Present, 'Name, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#name-1">KubernetesClusterNodePool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesClusterNodePoolState<'KubernetesClusterId, Missing, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, Present, 'VmSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesClusterNodePoolState<'KubernetesClusterId, Present, 'VmSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#vm_size-1">KubernetesClusterNodePool#vm_size</a>.
        /// </summary>
        [<CustomOperation "vm_size">]
        member _.VmSize(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, Missing>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.VmSize <- value)
            ({ assignments = state.assignments } : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#auto_scaling_enabled-1">KubernetesClusterNodePool#auto_scaling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_scaling_enabled">]
        member _.AutoScalingEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: bool) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.AutoScalingEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#auto_scaling_enabled-1">KubernetesClusterNodePool#auto_scaling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_scaling_enabled">]
        member _.AutoScalingEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.AutoScalingEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#capacity_reservation_group_id-1">KubernetesClusterNodePool#capacity_reservation_group_id</a>.
        /// </summary>
        [<CustomOperation "capacity_reservation_group_id">]
        member _.CapacityReservationGroupId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.CapacityReservationGroupId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#eviction_policy-1">KubernetesClusterNodePool#eviction_policy</a>.
        /// </summary>
        [<CustomOperation "eviction_policy">]
        member _.EvictionPolicy(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.EvictionPolicy <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#fips_enabled-1">KubernetesClusterNodePool#fips_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "fips_enabled">]
        member _.FipsEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: bool) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.FipsEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#fips_enabled-1">KubernetesClusterNodePool#fips_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "fips_enabled">]
        member _.FipsEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.FipsEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#gpu_instance-1">KubernetesClusterNodePool#gpu_instance</a>.
        /// </summary>
        [<CustomOperation "gpu_instance">]
        member _.GpuInstance(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.GpuInstance <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#host_encryption_enabled-1">KubernetesClusterNodePool#host_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "host_encryption_enabled">]
        member _.HostEncryptionEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: bool) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.HostEncryptionEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#host_encryption_enabled-1">KubernetesClusterNodePool#host_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "host_encryption_enabled">]
        member _.HostEncryptionEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.HostEncryptionEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#host_group_id-1">KubernetesClusterNodePool#host_group_id</a>.
        /// </summary>
        [<CustomOperation "host_group_id">]
        member _.HostGroupId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.HostGroupId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#id-1">KubernetesClusterNodePool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// kubelet_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#kubelet_config-1">KubernetesClusterNodePool#kubelet_config</a>
        /// </summary>
        [<CustomOperation "kubelet_config">]
        member _.KubeletConfig(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolKubeletConfig) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.KubeletConfig <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#kubelet_disk_type-1">KubernetesClusterNodePool#kubelet_disk_type</a>.
        /// </summary>
        [<CustomOperation "kubelet_disk_type">]
        member _.KubeletDiskType(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.KubeletDiskType <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// linux_os_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#linux_os_config-1">KubernetesClusterNodePool#linux_os_config</a>
        /// </summary>
        [<CustomOperation "linux_os_config">]
        member _.LinuxOsConfig(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolLinuxOsConfig) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.LinuxOsConfig <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#max_count-1">KubernetesClusterNodePool#max_count</a>.
        /// </summary>
        [<CustomOperation "max_count">]
        member _.MaxCount(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: double) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.MaxCount <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#max_pods-1">KubernetesClusterNodePool#max_pods</a>.
        /// </summary>
        [<CustomOperation "max_pods">]
        member _.MaxPods(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: double) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.MaxPods <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#min_count-1">KubernetesClusterNodePool#min_count</a>.
        /// </summary>
        [<CustomOperation "min_count">]
        member _.MinCount(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: double) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.MinCount <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#mode-1">KubernetesClusterNodePool#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_count-1">KubernetesClusterNodePool#node_count</a>.
        /// </summary>
        [<CustomOperation "node_count">]
        member _.NodeCount(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: double) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodeCount <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_labels-1">KubernetesClusterNodePool#node_labels</a>.
        /// </summary>
        [<CustomOperation "node_labels">]
        member _.NodeLabels(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: seq<string * string>) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodeLabels <- dict value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// node_network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_network_profile-1">KubernetesClusterNodePool#node_network_profile</a>
        /// </summary>
        [<CustomOperation "node_network_profile">]
        member _.NodeNetworkProfile(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolNodeNetworkProfile) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodeNetworkProfile <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_public_ip_enabled-1">KubernetesClusterNodePool#node_public_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_enabled">]
        member _.NodePublicIpEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: bool) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodePublicIpEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_public_ip_enabled-1">KubernetesClusterNodePool#node_public_ip_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_enabled">]
        member _.NodePublicIpEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodePublicIpEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_public_ip_prefix_id-1">KubernetesClusterNodePool#node_public_ip_prefix_id</a>.
        /// </summary>
        [<CustomOperation "node_public_ip_prefix_id">]
        member _.NodePublicIpPrefixId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodePublicIpPrefixId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#node_taints-1">KubernetesClusterNodePool#node_taints</a>.
        /// </summary>
        [<CustomOperation "node_taints">]
        member _.NodeTaints(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: seq<string>) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.NodeTaints <- (value |> Seq.toArray))
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#orchestrator_version-1">KubernetesClusterNodePool#orchestrator_version</a>.
        /// </summary>
        [<CustomOperation "orchestrator_version">]
        member _.OrchestratorVersion(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.OrchestratorVersion <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#os_disk_size_gb-1">KubernetesClusterNodePool#os_disk_size_gb</a>.
        /// </summary>
        [<CustomOperation "os_disk_size_gb">]
        member _.OsDiskSizeGb(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: double) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.OsDiskSizeGb <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#os_disk_type-1">KubernetesClusterNodePool#os_disk_type</a>.
        /// </summary>
        [<CustomOperation "os_disk_type">]
        member _.OsDiskType(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.OsDiskType <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#os_sku-1">KubernetesClusterNodePool#os_sku</a>.
        /// </summary>
        [<CustomOperation "os_sku">]
        member _.OsSku(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.OsSku <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#os_type-1">KubernetesClusterNodePool#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.OsType <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#pod_subnet_id-1">KubernetesClusterNodePool#pod_subnet_id</a>.
        /// </summary>
        [<CustomOperation "pod_subnet_id">]
        member _.PodSubnetId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.PodSubnetId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#priority-1">KubernetesClusterNodePool#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.Priority <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#proximity_placement_group_id-1">KubernetesClusterNodePool#proximity_placement_group_id</a>.
        /// </summary>
        [<CustomOperation "proximity_placement_group_id">]
        member _.ProximityPlacementGroupId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.ProximityPlacementGroupId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#scale_down_mode-1">KubernetesClusterNodePool#scale_down_mode</a>.
        /// </summary>
        [<CustomOperation "scale_down_mode">]
        member _.ScaleDownMode(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.ScaleDownMode <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#snapshot_id-1">KubernetesClusterNodePool#snapshot_id</a>.
        /// </summary>
        [<CustomOperation "snapshot_id">]
        member _.SnapshotId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.SnapshotId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#spot_max_price-1">KubernetesClusterNodePool#spot_max_price</a>.
        /// </summary>
        [<CustomOperation "spot_max_price">]
        member _.SpotMaxPrice(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: double) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.SpotMaxPrice <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#tags-1">KubernetesClusterNodePool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: seq<string * string>) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#timeouts-1">KubernetesClusterNodePool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolTimeouts) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#ultra_ssd_enabled-1">KubernetesClusterNodePool#ultra_ssd_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ultra_ssd_enabled">]
        member _.UltraSsdEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: bool) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.UltraSsdEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#ultra_ssd_enabled-1">KubernetesClusterNodePool#ultra_ssd_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ultra_ssd_enabled">]
        member _.UltraSsdEnabled(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: HashiCorp.Cdktf.IResolvable) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.UltraSsdEnabled <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// upgrade_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#upgrade_settings-1">KubernetesClusterNodePool#upgrade_settings</a>
        /// </summary>
        [<CustomOperation "upgrade_settings">]
        member _.UpgradeSettings(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolUpgradeSettings) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.UpgradeSettings <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#vnet_subnet_id-1">KubernetesClusterNodePool#vnet_subnet_id</a>.
        /// </summary>
        [<CustomOperation "vnet_subnet_id">]
        member _.VnetSubnetId(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.VnetSubnetId <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// windows_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#windows_profile-1">KubernetesClusterNodePool#windows_profile</a>
        /// </summary>
        [<CustomOperation "windows_profile">]
        member _.WindowsProfile(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolWindowsProfile) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.WindowsProfile <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#workload_runtime-1">KubernetesClusterNodePool#workload_runtime</a>.
        /// </summary>
        [<CustomOperation "workload_runtime">]
        member _.WorkloadRuntime(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: string) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.WorkloadRuntime <- value)
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_node_pool#zones-1">KubernetesClusterNodePool#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>, value: seq<string>) : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : KubernetesClusterNodePoolState<'KubernetesClusterId, 'Name, 'VmSize>

        member _.Run(state: KubernetesClusterNodePoolState<Present, Present, Present>) : azurerm.KubernetesClusterNodePool.KubernetesClusterNodePool =
            let config = azurerm.KubernetesClusterNodePool.KubernetesClusterNodePoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesClusterNodePool.KubernetesClusterNodePool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesClusterNodePool: missing required arguments. Must call: kubernetes_cluster_id, name, vm_size.", 9999, IsError = true)>]
        member _.Run(_: KubernetesClusterNodePoolState<_, _, _>) : azurerm.KubernetesClusterNodePool.KubernetesClusterNodePool =
            Unchecked.defaultof<azurerm.KubernetesClusterNodePool.KubernetesClusterNodePool>
