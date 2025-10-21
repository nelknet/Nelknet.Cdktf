using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVpnGateway
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsOutputReference), fullyQualifiedName: "azurerm.dataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermVpnGatewayBgpSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermVpnGatewayBgpSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVpnGatewayBgpSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermVpnGatewayBgpSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "asn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Asn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "bgpPeeringAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BgpPeeringAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instance0BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.dataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsInstance0BgpPeeringAddressList\"}")]
        public virtual azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsInstance0BgpPeeringAddressList Instance0BgpPeeringAddress
        {
            get => GetInstanceProperty<azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsInstance0BgpPeeringAddressList>()!;
        }

        [JsiiProperty(name: "instance1BgpPeeringAddress", typeJson: "{\"fqn\":\"azurerm.dataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsInstance1BgpPeeringAddressList\"}")]
        public virtual azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsInstance1BgpPeeringAddressList Instance1BgpPeeringAddress
        {
            get => GetInstanceProperty<azurerm.DataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettingsInstance1BgpPeeringAddressList>()!;
        }

        [JsiiProperty(name: "peerWeight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerWeight
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermVpnGateway.DataAzurermVpnGatewayBgpSettings\"}", isOptional: true)]
        public virtual azurerm.DataAzurermVpnGateway.IDataAzurermVpnGatewayBgpSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermVpnGateway.IDataAzurermVpnGatewayBgpSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
