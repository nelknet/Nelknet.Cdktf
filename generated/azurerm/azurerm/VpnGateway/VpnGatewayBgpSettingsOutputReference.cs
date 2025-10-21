using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnGateway
{
    [JsiiClass(nativeType: typeof(azurerm.VpnGateway.VpnGatewayBgpSettingsOutputReference), fullyQualifiedName: "azurerm.vpnGateway.VpnGatewayBgpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnGatewayBgpSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpnGatewayBgpSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpnGatewayBgpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnGatewayBgpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInstance0BgpPeeringAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddress\"}}]")]
        public virtual void PutInstance0BgpPeeringAddress(azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstance1BgpPeeringAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress\"}}]")]
        public virtual void PutInstance1BgpPeeringAddress(azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstance0BgpPeeringAddress")]
        public virtual void ResetInstance0BgpPeeringAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstance1BgpPeeringAddress")]
        public virtual void ResetInstance1BgpPeeringAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bgpPeeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpPeeringAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instance0BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddressOutputReference\"}")]
        public virtual azurerm.VpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddressOutputReference Instance0BgpPeeringAddress
        {
            get => GetInstanceProperty<azurerm.VpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddressOutputReference>()!;
        }

        [JsiiProperty(name: "instance1BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddressOutputReference\"}")]
        public virtual azurerm.VpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddressOutputReference Instance1BgpPeeringAddress
        {
            get => GetInstanceProperty<azurerm.VpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "asnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instance0BgpPeeringAddressInput", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance0BgpPeeringAddress\"}", isOptional: true)]
        public virtual azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress? Instance0BgpPeeringAddressInput
        {
            get => GetInstanceProperty<azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance0BgpPeeringAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instance1BgpPeeringAddressInput", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettingsInstance1BgpPeeringAddress\"}", isOptional: true)]
        public virtual azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress? Instance1BgpPeeringAddressInput
        {
            get => GetInstanceProperty<azurerm.VpnGateway.IVpnGatewayBgpSettingsInstance1BgpPeeringAddress?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerWeightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeerWeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Asn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerWeight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.vpnGateway.VpnGatewayBgpSettings\"}", isOptional: true)]
        public virtual azurerm.VpnGateway.IVpnGatewayBgpSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.VpnGateway.IVpnGatewayBgpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
