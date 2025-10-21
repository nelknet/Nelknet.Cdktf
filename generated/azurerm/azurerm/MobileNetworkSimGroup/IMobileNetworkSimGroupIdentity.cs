using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSimGroup
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkSimGroupIdentity), fullyQualifiedName: "azurerm.mobileNetworkSimGroup.MobileNetworkSimGroupIdentity")]
    public interface IMobileNetworkSimGroupIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#identity_ids MobileNetworkSimGroup#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IdentityIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#type MobileNetworkSimGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkSimGroupIdentity), fullyQualifiedName: "azurerm.mobileNetworkSimGroup.MobileNetworkSimGroupIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkSimGroup.IMobileNetworkSimGroupIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#identity_ids MobileNetworkSimGroup#identity_ids}.</summary>
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IdentityIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_sim_group#type MobileNetworkSimGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
