using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkServiceServiceQosPolicyMaximumBitRate), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate")]
    public interface IMobileNetworkServiceServiceQosPolicyMaximumBitRate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#downlink MobileNetworkService#downlink}.</summary>
        [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
        string Downlink
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#uplink MobileNetworkService#uplink}.</summary>
        [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
        string Uplink
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkServiceServiceQosPolicyMaximumBitRate), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#downlink MobileNetworkService#downlink}.</summary>
            [JsiiProperty(name: "downlink", typeJson: "{\"primitive\":\"string\"}")]
            public string Downlink
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_service#uplink MobileNetworkService#uplink}.</summary>
            [JsiiProperty(name: "uplink", typeJson: "{\"primitive\":\"string\"}")]
            public string Uplink
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
