using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMobileNetworkAttachedDataNetwork
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference), fullyQualifiedName: "azurerm.dataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "icmpPinholeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IcmpPinholeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pinholeMaximumNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PinholeMaximumNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "portRange", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRangeList\"}")]
        public virtual azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRangeList PortRange
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRangeList>()!;
        }

        [JsiiProperty(name: "tcpPinholeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpPinholeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tcpPortReuseMinimumHoldTimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpPortReuseMinimumHoldTimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "udpPinholeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UdpPinholeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "udpPortReuseMinimumHoldTimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UdpPortReuseMinimumHoldTimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermMobileNetworkAttachedDataNetwork.DataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation\"}", isOptional: true)]
        public virtual azurerm.DataAzurermMobileNetworkAttachedDataNetwork.IDataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermMobileNetworkAttachedDataNetwork.IDataAzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation?>();
            set => SetInstanceProperty(value);
        }
    }
}
