using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KubernetesCluster.KubernetesClusterNetworkProfileOutputReference), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterNetworkProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterNetworkProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterNetworkProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterNetworkProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterNetworkProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoadBalancerProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfile\"}}]")]
        public virtual void PutLoadBalancerProfile(azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNatGatewayProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfile\"}}]")]
        public virtual void PutNatGatewayProfile(azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDnsServiceIp")]
        public virtual void ResetDnsServiceIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpVersions")]
        public virtual void ResetIpVersions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerProfile")]
        public virtual void ResetLoadBalancerProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerSku")]
        public virtual void ResetLoadBalancerSku()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNatGatewayProfile")]
        public virtual void ResetNatGatewayProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDataPlane")]
        public virtual void ResetNetworkDataPlane()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkMode")]
        public virtual void ResetNetworkMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkPluginMode")]
        public virtual void ResetNetworkPluginMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkPolicy")]
        public virtual void ResetNetworkPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundType")]
        public virtual void ResetOutboundType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodCidr")]
        public virtual void ResetPodCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPodCidrs")]
        public virtual void ResetPodCidrs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceCidr")]
        public virtual void ResetServiceCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceCidrs")]
        public virtual void ResetServiceCidrs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "loadBalancerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfileOutputReference LoadBalancerProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfileOutputReference>()!;
        }

        [JsiiProperty(name: "natGatewayProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfileOutputReference\"}")]
        public virtual azurerm.KubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfileOutputReference NatGatewayProfile
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsServiceIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DnsServiceIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipVersionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IpVersionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileLoadBalancerProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile? LoadBalancerProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileLoadBalancerProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerSkuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerSkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "natGatewayProfileInput", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfileNatGatewayProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile? NatGatewayProfileInput
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfileNatGatewayProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDataPlaneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkDataPlaneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkPluginInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkPluginInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkPluginModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkPluginModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PodCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "podCidrsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PodCidrsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceCidrsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServiceCidrsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "dnsServiceIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsServiceIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpVersions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerSku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerSku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkDataPlane", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkDataPlane
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPlugin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkPluginMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPluginMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PodCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "podCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PodCidrs
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServiceCidrs
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfile\"}", isOptional: true)]
        public virtual azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile? InternalValue
        {
            get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile?>();
            set => SetInstanceProperty(value);
        }
    }
}
