using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterAciConnectorLinuxOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinuxOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterAciConnectorLinuxOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterAciConnectorLinuxOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterAciConnectorLinuxOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterAciConnectorLinuxOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "connectorIdentity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinuxConnectorIdentityList\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterAciConnectorLinuxConnectorIdentityList ConnectorIdentity
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterAciConnectorLinuxConnectorIdentityList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "subnetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux?>();
            set => SetInstanceProperty(value);
        }
    }
}
