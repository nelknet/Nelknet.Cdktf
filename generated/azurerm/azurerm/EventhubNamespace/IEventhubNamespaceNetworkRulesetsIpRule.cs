using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventhubNamespace
{
    [JsiiInterface(nativeType: typeof(IEventhubNamespaceNetworkRulesetsIpRule), fullyQualifiedName: "azurerm.eventhubNamespace.EventhubNamespaceNetworkRulesetsIpRule")]
    public interface IEventhubNamespaceNetworkRulesetsIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#action EventhubNamespace#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#ip_mask EventhubNamespace#ip_mask}.</summary>
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpMask
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEventhubNamespaceNetworkRulesetsIpRule), fullyQualifiedName: "azurerm.eventhubNamespace.EventhubNamespaceNetworkRulesetsIpRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.EventhubNamespace.IEventhubNamespaceNetworkRulesetsIpRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#action EventhubNamespace#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#ip_mask EventhubNamespace#ip_mask}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpMask
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
