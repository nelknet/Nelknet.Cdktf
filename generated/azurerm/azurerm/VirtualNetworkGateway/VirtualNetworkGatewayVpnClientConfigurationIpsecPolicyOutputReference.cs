using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGateway
{
    [JsiiClass(nativeType: typeof(azurerm.VirtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationIpsecPolicyOutputReference), fullyQualifiedName: "azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationIpsecPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualNetworkGatewayVpnClientConfigurationIpsecPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualNetworkGatewayVpnClientConfigurationIpsecPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualNetworkGatewayVpnClientConfigurationIpsecPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGatewayVpnClientConfigurationIpsecPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dhGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DhGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ikeEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IkeEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ikeIntegrityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IkeIntegrityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsecEncryptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpsecEncryptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipsecIntegrityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpsecIntegrityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pfsGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PfsGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saDataSizeInKilobytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SaDataSizeInKilobytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saLifetimeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SaLifetimeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "dhGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DhGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ikeEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ikeIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IkeIntegrity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipsecEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecEncryption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipsecIntegrity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpsecIntegrity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pfsGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PfsGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "saDataSizeInKilobytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaDataSizeInKilobytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "saLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaLifetimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationIpsecPolicy\"}", isOptional: true)]
        public virtual azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationIpsecPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationIpsecPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
