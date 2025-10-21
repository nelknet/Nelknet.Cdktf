using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterDefaultNodePoolLinuxOsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSysctlConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig\"}}]")]
        public virtual void PutSysctlConfig(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSwapFileSizeMb")]
        public virtual void ResetSwapFileSizeMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSysctlConfig")]
        public virtual void ResetSysctlConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransparentHugePageDefrag")]
        public virtual void ResetTransparentHugePageDefrag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransparentHugePageEnabled")]
        public virtual void ResetTransparentHugePageEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sysctlConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfigOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfigOutputReference SysctlConfig
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "swapFileSizeMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SwapFileSizeMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sysctlConfigInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig? SysctlConfigInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfigSysctlConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transparentHugePageDefragInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransparentHugePageDefragInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transparentHugePageEnabledInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransparentHugePageEnabledInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "swapFileSizeMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SwapFileSizeMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transparentHugePageDefrag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransparentHugePageDefrag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transparentHugePageEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransparentHugePageEnabled
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolLinuxOsConfig\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolLinuxOsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
