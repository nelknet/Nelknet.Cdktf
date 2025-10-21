using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterLinuxProfileOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterLinuxProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterLinuxProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterLinuxProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterLinuxProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSshKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey\"}}]")]
        public virtual void PutSshKey(azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey)}, new object[]{@value});
        }

        [JsiiProperty(name: "sshKey", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKeyOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterLinuxProfileSshKeyOutputReference SshKey
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterLinuxProfileSshKeyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshKeyInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey? SshKeyInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey?>();
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
