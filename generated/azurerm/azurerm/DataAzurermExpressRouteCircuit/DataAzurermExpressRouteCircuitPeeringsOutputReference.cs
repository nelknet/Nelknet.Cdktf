using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermExpressRouteCircuit
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitPeeringsOutputReference), fullyQualifiedName: "azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitPeeringsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermExpressRouteCircuitPeeringsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermExpressRouteCircuitPeeringsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermExpressRouteCircuitPeeringsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermExpressRouteCircuitPeeringsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "azureAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AzureAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerAsn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "peeringType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeeringType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryPeerAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryPeerAddressPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryPeerAddressPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SharedKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VlanId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermExpressRouteCircuit.DataAzurermExpressRouteCircuitPeerings\"}", isOptional: true)]
        public virtual azurerm.DataAzurermExpressRouteCircuit.IDataAzurermExpressRouteCircuitPeerings? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermExpressRouteCircuit.IDataAzurermExpressRouteCircuitPeerings?>();
            set => SetInstanceProperty(value);
        }
    }
}
