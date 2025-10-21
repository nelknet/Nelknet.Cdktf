using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimPolicy
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkSimPolicySlice), fullyQualifiedName: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySlice")]
    public interface IMobileNetworkSimPolicySlice
    {
        /// <summary>data_network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#data_network MobileNetworkSimPolicy#data_network}
        /// </remarks>
        [JsiiProperty(name: "dataNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetwork\"},\"kind\":\"array\"}}]}}")]
        object DataNetwork
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_data_network_id MobileNetworkSimPolicy#default_data_network_id}.</summary>
        [JsiiProperty(name: "defaultDataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultDataNetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#slice_id MobileNetworkSimPolicy#slice_id}.</summary>
        [JsiiProperty(name: "sliceId", typeJson: "{\"primitive\":\"string\"}")]
        string SliceId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkSimPolicySlice), fullyQualifiedName: "azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySlice")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkSimPolicy.IMobileNetworkSimPolicySlice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#data_network MobileNetworkSimPolicy#data_network}
            /// </remarks>
            [JsiiProperty(name: "dataNetwork", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkSimPolicy.MobileNetworkSimPolicySliceDataNetwork\"},\"kind\":\"array\"}}]}}")]
            public object DataNetwork
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#default_data_network_id MobileNetworkSimPolicy#default_data_network_id}.</summary>
            [JsiiProperty(name: "defaultDataNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultDataNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_policy#slice_id MobileNetworkSimPolicy#slice_id}.</summary>
            [JsiiProperty(name: "sliceId", typeJson: "{\"primitive\":\"string\"}")]
            public string SliceId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
