using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LocalNetworkGateway
{
    [JsiiClass(nativeType: typeof(azurerm.LocalNetworkGateway.LocalNetworkGatewayBgpSettingsOutputReference), fullyQualifiedName: "azurerm.localNetworkGateway.LocalNetworkGatewayBgpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LocalNetworkGatewayBgpSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LocalNetworkGatewayBgpSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LocalNetworkGatewayBgpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LocalNetworkGatewayBgpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPeerWeight")]
        public virtual void ResetPeerWeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "asnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bgpPeeringAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BgpPeeringAddressInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "bgpPeeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpPeeringAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerWeight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.localNetworkGateway.LocalNetworkGatewayBgpSettings\"}", isOptional: true)]
        public virtual azurerm.LocalNetworkGateway.ILocalNetworkGatewayBgpSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.LocalNetworkGateway.ILocalNetworkGatewayBgpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
