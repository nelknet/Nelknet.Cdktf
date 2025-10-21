using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubHub
{
    [JsiiInterface(nativeType: typeof(IWebPubsubHubEventListener), fullyQualifiedName: "azurerm.webPubsubHub.WebPubsubHubEventListener")]
    public interface IWebPubsubHubEventListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#eventhub_name WebPubsubHub#eventhub_name}.</summary>
        [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
        string EventhubName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#eventhub_namespace_name WebPubsubHub#eventhub_namespace_name}.</summary>
        [JsiiProperty(name: "eventhubNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
        string EventhubNamespaceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#system_event_name_filter WebPubsubHub#system_event_name_filter}.</summary>
        [JsiiProperty(name: "systemEventNameFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SystemEventNameFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#user_event_name_filter WebPubsubHub#user_event_name_filter}.</summary>
        [JsiiProperty(name: "userEventNameFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UserEventNameFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebPubsubHubEventListener), fullyQualifiedName: "azurerm.webPubsubHub.WebPubsubHubEventListener")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebPubsubHub.IWebPubsubHubEventListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#eventhub_name WebPubsubHub#eventhub_name}.</summary>
            [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
            public string EventhubName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#eventhub_namespace_name WebPubsubHub#eventhub_namespace_name}.</summary>
            [JsiiProperty(name: "eventhubNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
            public string EventhubNamespaceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#system_event_name_filter WebPubsubHub#system_event_name_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemEventNameFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SystemEventNameFilter
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#user_event_name_filter WebPubsubHub#user_event_name_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userEventNameFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UserEventNameFilter
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
