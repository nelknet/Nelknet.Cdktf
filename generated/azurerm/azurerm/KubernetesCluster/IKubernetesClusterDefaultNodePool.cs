using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterDefaultNodePool), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool")]
    public interface IKubernetesClusterDefaultNodePool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#vm_size KubernetesCluster#vm_size}.</summary>
        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        string VmSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#auto_scaling_enabled KubernetesCluster#auto_scaling_enabled}.</summary>
        [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoScalingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#capacity_reservation_group_id KubernetesCluster#capacity_reservation_group_id}.</summary>
        [JsiiProperty(name: "capacityReservationGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CapacityReservationGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#fips_enabled KubernetesCluster#fips_enabled}.</summary>
        [JsiiProperty(name: "fipsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FipsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#gpu_instance KubernetesCluster#gpu_instance}.</summary>
        [JsiiProperty(name: "gpuInstance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GpuInstance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#host_encryption_enabled KubernetesCluster#host_encryption_enabled}.</summary>
        [JsiiProperty(name: "hostEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostEncryptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#host_group_id KubernetesCluster#host_group_id}.</summary>
        [JsiiProperty(name: "hostGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>kubelet_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_config KubernetesCluster#kubelet_config}
        /// </remarks>
        [JsiiProperty(name: "kubeletConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig? KubeletConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_disk_type KubernetesCluster#kubelet_disk_type}.</summary>
        [JsiiProperty(name: "kubeletDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KubeletDiskType
        {
            get
            {
                return null;
            }
        }

        /// <summary>linux_os_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#linux_os_config KubernetesCluster#linux_os_config}
        /// </remarks>
        [JsiiProperty(name: "linuxOsConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig? LinuxOsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_count KubernetesCluster#max_count}.</summary>
        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_pods KubernetesCluster#max_pods}.</summary>
        [JsiiProperty(name: "maxPods", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPods
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#min_count KubernetesCluster#min_count}.</summary>
        [JsiiProperty(name: "minCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_count KubernetesCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_labels KubernetesCluster#node_labels}.</summary>
        [JsiiProperty(name: "nodeLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? NodeLabels
        {
            get
            {
                return null;
            }
        }

        /// <summary>node_network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_network_profile KubernetesCluster#node_network_profile}
        /// </remarks>
        [JsiiProperty(name: "nodeNetworkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile? NodeNetworkProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_public_ip_enabled KubernetesCluster#node_public_ip_enabled}.</summary>
        [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NodePublicIpEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_public_ip_prefix_id KubernetesCluster#node_public_ip_prefix_id}.</summary>
        [JsiiProperty(name: "nodePublicIpPrefixId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodePublicIpPrefixId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#only_critical_addons_enabled KubernetesCluster#only_critical_addons_enabled}.</summary>
        [JsiiProperty(name: "onlyCriticalAddonsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnlyCriticalAddonsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#orchestrator_version KubernetesCluster#orchestrator_version}.</summary>
        [JsiiProperty(name: "orchestratorVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrchestratorVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#os_disk_size_gb KubernetesCluster#os_disk_size_gb}.</summary>
        [JsiiProperty(name: "osDiskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OsDiskSizeGb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#os_disk_type KubernetesCluster#os_disk_type}.</summary>
        [JsiiProperty(name: "osDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OsDiskType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#os_sku KubernetesCluster#os_sku}.</summary>
        [JsiiProperty(name: "osSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OsSku
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_subnet_id KubernetesCluster#pod_subnet_id}.</summary>
        [JsiiProperty(name: "podSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PodSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#proximity_placement_group_id KubernetesCluster#proximity_placement_group_id}.</summary>
        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProximityPlacementGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_mode KubernetesCluster#scale_down_mode}.</summary>
        [JsiiProperty(name: "scaleDownMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#snapshot_id KubernetesCluster#snapshot_id}.</summary>
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnapshotId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#temporary_name_for_rotation KubernetesCluster#temporary_name_for_rotation}.</summary>
        [JsiiProperty(name: "temporaryNameForRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemporaryNameForRotation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#type KubernetesCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ultra_ssd_enabled KubernetesCluster#ultra_ssd_enabled}.</summary>
        [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UltraSsdEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>upgrade_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#upgrade_settings KubernetesCluster#upgrade_settings}
        /// </remarks>
        [JsiiProperty(name: "upgradeSettings", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings? UpgradeSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#vnet_subnet_id KubernetesCluster#vnet_subnet_id}.</summary>
        [JsiiProperty(name: "vnetSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VnetSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_runtime KubernetesCluster#workload_runtime}.</summary>
        [JsiiProperty(name: "workloadRuntime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WorkloadRuntime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#zones KubernetesCluster#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Zones
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterDefaultNodePool), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#vm_size KubernetesCluster#vm_size}.</summary>
            [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
            public string VmSize
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#auto_scaling_enabled KubernetesCluster#auto_scaling_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoScalingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#capacity_reservation_group_id KubernetesCluster#capacity_reservation_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacityReservationGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CapacityReservationGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#fips_enabled KubernetesCluster#fips_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fipsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FipsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#gpu_instance KubernetesCluster#gpu_instance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gpuInstance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GpuInstance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#host_encryption_enabled KubernetesCluster#host_encryption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HostEncryptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#host_group_id KubernetesCluster#host_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kubelet_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_config KubernetesCluster#kubelet_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubeletConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig? KubeletConfig
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_disk_type KubernetesCluster#kubelet_disk_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kubeletDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KubeletDiskType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>linux_os_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#linux_os_config KubernetesCluster#linux_os_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linuxOsConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfig\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig? LinuxOsConfig
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_count KubernetesCluster#max_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_pods KubernetesCluster#max_pods}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPods", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPods
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#min_count KubernetesCluster#min_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_count KubernetesCluster#node_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_labels KubernetesCluster#node_labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? NodeLabels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>node_network_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_network_profile KubernetesCluster#node_network_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeNetworkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile? NodeNetworkProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_public_ip_enabled KubernetesCluster#node_public_ip_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? NodePublicIpEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_public_ip_prefix_id KubernetesCluster#node_public_ip_prefix_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodePublicIpPrefixId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodePublicIpPrefixId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#only_critical_addons_enabled KubernetesCluster#only_critical_addons_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onlyCriticalAddonsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OnlyCriticalAddonsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#orchestrator_version KubernetesCluster#orchestrator_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "orchestratorVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrchestratorVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#os_disk_size_gb KubernetesCluster#os_disk_size_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osDiskSizeGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OsDiskSizeGb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#os_disk_type KubernetesCluster#os_disk_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osDiskType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OsDiskType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#os_sku KubernetesCluster#os_sku}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "osSku", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OsSku
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#pod_subnet_id KubernetesCluster#pod_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PodSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#proximity_placement_group_id KubernetesCluster#proximity_placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProximityPlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_mode KubernetesCluster#scale_down_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#snapshot_id KubernetesCluster#snapshot_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnapshotId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#temporary_name_for_rotation KubernetesCluster#temporary_name_for_rotation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "temporaryNameForRotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemporaryNameForRotation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#type KubernetesCluster#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ultra_ssd_enabled KubernetesCluster#ultra_ssd_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UltraSsdEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>upgrade_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#upgrade_settings KubernetesCluster#upgrade_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeSettings", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings? UpgradeSettings
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#vnet_subnet_id KubernetesCluster#vnet_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vnetSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VnetSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_runtime KubernetesCluster#workload_runtime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workloadRuntime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WorkloadRuntime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#zones KubernetesCluster#zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Zones
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
