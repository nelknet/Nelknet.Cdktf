using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubHub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webPubsubHub.WebPubsubHubEventListener")]
    public class WebPubsubHubEventListener : azurerm.WebPubsubHub.IWebPubsubHubEventListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#eventhub_name WebPubsubHub#eventhub_name}.</summary>
        [JsiiProperty(name: "eventhubName", typeJson: "{\"primitive\":\"string\"}")]
        public string EventhubName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#eventhub_namespace_name WebPubsubHub#eventhub_namespace_name}.</summary>
        [JsiiProperty(name: "eventhubNamespaceName", typeJson: "{\"primitive\":\"string\"}")]
        public string EventhubNamespaceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#system_event_name_filter WebPubsubHub#system_event_name_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemEventNameFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SystemEventNameFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#user_event_name_filter WebPubsubHub#user_event_name_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userEventNameFilter", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UserEventNameFilter
        {
            get;
            set;
        }
    }
}
