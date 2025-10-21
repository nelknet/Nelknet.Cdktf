using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfigOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterDefaultNodePoolKubeletConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterDefaultNodePoolKubeletConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterDefaultNodePoolKubeletConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterDefaultNodePoolKubeletConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowedUnsafeSysctls")]
        public virtual void ResetAllowedUnsafeSysctls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerLogMaxLine")]
        public virtual void ResetContainerLogMaxLine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerLogMaxSizeMb")]
        public virtual void ResetContainerLogMaxSizeMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuCfsQuotaEnabled")]
        public virtual void ResetCpuCfsQuotaEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuCfsQuotaPeriod")]
        public virtual void ResetCpuCfsQuotaPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuManagerPolicy")]
        public virtual void ResetCpuManagerPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageGcHighThreshold")]
        public virtual void ResetImageGcHighThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageGcLowThreshold")]
        public virtual void ResetImageGcLowThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodMaxPid")]
        public virtual void ResetPodMaxPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopologyManagerPolicy")]
        public virtual void ResetTopologyManagerPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedUnsafeSysctlsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedUnsafeSysctlsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerLogMaxLineInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ContainerLogMaxLineInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerLogMaxSizeMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ContainerLogMaxSizeMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCfsQuotaEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CpuCfsQuotaEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuCfsQuotaPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuCfsQuotaPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuManagerPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuManagerPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageGcHighThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ImageGcHighThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageGcLowThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ImageGcLowThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podMaxPidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PodMaxPidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topologyManagerPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopologyManagerPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedUnsafeSysctls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedUnsafeSysctls
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerLogMaxLine", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerLogMaxLine
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerLogMaxSizeMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerLogMaxSizeMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuCfsQuotaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CpuCfsQuotaEnabled
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

        [JsiiProperty(name: "cpuCfsQuotaPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuCfsQuotaPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuManagerPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuManagerPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageGcHighThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImageGcHighThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageGcLowThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImageGcLowThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podMaxPid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PodMaxPid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topologyManagerPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TopologyManagerPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolKubeletConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolKubeletConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
