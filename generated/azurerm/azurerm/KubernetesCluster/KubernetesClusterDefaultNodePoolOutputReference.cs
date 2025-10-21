using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterDefaultNodePoolOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterDefaultNodePoolOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterDefaultNodePoolOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterDefaultNodePoolOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKubeletConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig\"}}]")]
        public virtual void PutKubeletConfig(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLinuxOsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfig\"}}]")]
        public virtual void PutLinuxOsConfig(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeNetworkProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfile\"}}]")]
        public virtual void PutNodeNetworkProfile(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpgradeSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings\"}}]")]
        public virtual void PutUpgradeSettings(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScalingEnabled")]
        public virtual void ResetAutoScalingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationGroupId")]
        public virtual void ResetCapacityReservationGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFipsEnabled")]
        public virtual void ResetFipsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGpuInstance")]
        public virtual void ResetGpuInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostEncryptionEnabled")]
        public virtual void ResetHostEncryptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostGroupId")]
        public virtual void ResetHostGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubeletConfig")]
        public virtual void ResetKubeletConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKubeletDiskType")]
        public virtual void ResetKubeletDiskType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinuxOsConfig")]
        public virtual void ResetLinuxOsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCount")]
        public virtual void ResetMaxCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPods")]
        public virtual void ResetMaxPods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinCount")]
        public virtual void ResetMinCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeCount")]
        public virtual void ResetNodeCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeLabels")]
        public virtual void ResetNodeLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeNetworkProfile")]
        public virtual void ResetNodeNetworkProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodePublicIpEnabled")]
        public virtual void ResetNodePublicIpEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodePublicIpPrefixId")]
        public virtual void ResetNodePublicIpPrefixId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnlyCriticalAddonsEnabled")]
        public virtual void ResetOnlyCriticalAddonsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrchestratorVersion")]
        public virtual void ResetOrchestratorVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsDiskSizeGb")]
        public virtual void ResetOsDiskSizeGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsDiskType")]
        public virtual void ResetOsDiskType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsSku")]
        public virtual void ResetOsSku()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodSubnetId")]
        public virtual void ResetPodSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProximityPlacementGroupId")]
        public virtual void ResetProximityPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownMode")]
        public virtual void ResetScaleDownMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotId")]
        public virtual void ResetSnapshotId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemporaryNameForRotation")]
        public virtual void ResetTemporaryNameForRotation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUltraSsdEnabled")]
        public virtual void ResetUltraSsdEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeSettings")]
        public virtual void ResetUpgradeSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVnetSubnetId")]
        public virtual void ResetVnetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkloadRuntime")]
        public virtual void ResetWorkloadRuntime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZones")]
        public virtual void ResetZones()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kubeletConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfigOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfigOutputReference KubeletConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfigOutputReference>()!;
        }

        [JsiiProperty(name: "linuxOsConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference LinuxOsConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "nodeNetworkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference NodeNetworkProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileOutputReference>()!;
        }

        [JsiiProperty(name: "upgradeSettings", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettingsOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettingsOutputReference UpgradeSettings
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoScalingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fipsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FipsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gpuInstanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GpuInstanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostEncryptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HostEncryptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubeletConfigInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig? KubeletConfigInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubeletDiskTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KubeletDiskTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linuxOsConfigInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig? LinuxOsConfigInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPodsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPodsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeLabelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? NodeLabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeNetworkProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile? NodeNetworkProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePublicIpEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? NodePublicIpEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePublicIpPrefixIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodePublicIpPrefixIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onlyCriticalAddonsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OnlyCriticalAddonsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orchestratorVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrchestratorVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskSizeGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OsDiskSizeGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsDiskTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osSkuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsSkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PodSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proximityPlacementGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProximityPlacementGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "temporaryNameForRotationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemporaryNameForRotationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ultraSsdEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UltraSsdEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeSettingsInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolUpgradeSettings\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings? UpgradeSettingsInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolUpgradeSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vnetSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VnetSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workloadRuntimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkloadRuntimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoScalingEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "capacityReservationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fipsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FipsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "gpuInstance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpuInstance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostEncryptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HostEncryptionEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "hostGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kubeletDiskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeletDiskType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPods", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPods
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> NodeLabels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodePublicIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object NodePublicIpEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "nodePublicIpPrefixId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodePublicIpPrefixId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onlyCriticalAddonsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object OnlyCriticalAddonsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "orchestratorVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrchestratorVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osDiskSizeGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OsDiskSizeGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osDiskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDiskType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsSku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PodSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProximityPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "temporaryNameForRotation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemporaryNameForRotation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ultraSsdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object UltraSsdEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vnetSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VnetSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workloadRuntime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkloadRuntime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool?>();
            set => SetInstanceProperty(value);
        }
    }
}
