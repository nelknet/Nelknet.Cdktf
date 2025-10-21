using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualNetworkGatewayConnection
{
    [JsiiClass(nativeType: typeof(azurerm.VirtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionIpsecPolicyOutputReference), fullyQualifiedName: "azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionIpsecPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VirtualNetworkGatewayConnectionIpsecPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VirtualNetworkGatewayConnectionIpsecPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VirtualNetworkGatewayConnectionIpsecPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualNetworkGatewayConnectionIpsecPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSaDatasize")]
        public virtual void ResetSaDatasize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSaLifetime")]
        public virtual void ResetSaLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        [JsiiProperty(name: "saDatasizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SaDatasizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "saLifetimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SaLifetimeInput
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

        [JsiiProperty(name: "saDatasize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaDatasize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "saLifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SaLifetime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.virtualNetworkGatewayConnection.VirtualNetworkGatewayConnectionIpsecPolicy\"}", isOptional: true)]
        public virtual azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionIpsecPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.VirtualNetworkGatewayConnection.IVirtualNetworkGatewayConnectionIpsecPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
