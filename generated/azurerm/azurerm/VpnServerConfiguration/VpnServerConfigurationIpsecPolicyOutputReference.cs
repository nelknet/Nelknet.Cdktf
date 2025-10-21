using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnServerConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.VpnServerConfiguration.VpnServerConfigurationIpsecPolicyOutputReference), fullyQualifiedName: "azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnServerConfigurationIpsecPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpnServerConfigurationIpsecPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpnServerConfigurationIpsecPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnServerConfigurationIpsecPolicyOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "saDataSizeKilobytesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SaDataSizeKilobytesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saLifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SaLifetimeSecondsInput
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

        [JsiiProperty(name: "saDataSizeKilobytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaDataSizeKilobytes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "saLifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaLifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.vpnServerConfiguration.VpnServerConfigurationIpsecPolicy\"}", isOptional: true)]
        public virtual azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.VpnServerConfiguration.IVpnServerConfigurationIpsecPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
