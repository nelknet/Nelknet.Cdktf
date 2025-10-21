using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "downlinkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DownlinkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uplinkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UplinkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Downlink
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uplink
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRate\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate? InternalValue
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate?>();
            set => SetInstanceProperty(value);
        }
    }
}
