using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimPolicy
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate), fullyQualifiedName: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate")]
    public interface IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#downlink MobileNetworkSimPolicy#downlink}.</summary>
        [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
        string Downlink
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#uplink MobileNetworkSimPolicy#uplink}.</summary>
        [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
        string Uplink
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate), fullyQualifiedName: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySliceDataNetworkSessionAggregateMaximumBitRate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#downlink MobileNetworkSimPolicy#downlink}.</summary>
            [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
            public string Downlink
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#uplink MobileNetworkSimPolicy#uplink}.</summary>
            [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
            public string Uplink
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
