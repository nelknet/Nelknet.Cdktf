using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkManager
{
    [JsiiInterface(nativeType: typeof(INetworkManagerScope), fullyQualifiedName: "azurerm.networkManager.NetworkManagerScope")]
    public interface INetworkManagerScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#management_group_ids NetworkManager#management_group_ids}.</summary>
        [JsiiProperty(name: "managementGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ManagementGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#subscription_ids NetworkManager#subscription_ids}.</summary>
        [JsiiProperty(name: "subscriptionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubscriptionIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkManagerScope), fullyQualifiedName: "azurerm.networkManager.NetworkManagerScope")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetworkManager.INetworkManagerScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#management_group_ids NetworkManager#management_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managementGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ManagementGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager#subscription_ids NetworkManager#subscription_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subscriptionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubscriptionIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
