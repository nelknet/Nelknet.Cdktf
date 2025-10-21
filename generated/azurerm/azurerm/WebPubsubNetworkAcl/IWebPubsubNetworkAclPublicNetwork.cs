using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubNetworkAcl
{
    [JsiiInterface(nativeType: typeof(IWebPubsubNetworkAclPublicNetwork), fullyQualifiedName: "azurerm.webPubsubNetworkAcl.WebPubsubNetworkAclPublicNetwork")]
    public interface IWebPubsubNetworkAclPublicNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#allowed_request_types WebPubsubNetworkAcl#allowed_request_types}.</summary>
        [JsiiProperty(name: "allowedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedRequestTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#denied_request_types WebPubsubNetworkAcl#denied_request_types}.</summary>
        [JsiiProperty(name: "deniedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DeniedRequestTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebPubsubNetworkAclPublicNetwork), fullyQualifiedName: "azurerm.webPubsubNetworkAcl.WebPubsubNetworkAclPublicNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebPubsubNetworkAcl.IWebPubsubNetworkAclPublicNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#allowed_request_types WebPubsubNetworkAcl#allowed_request_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedRequestTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_network_acl#denied_request_types WebPubsubNetworkAcl#denied_request_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deniedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DeniedRequestTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
