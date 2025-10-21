using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubHub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webPubsubHub.WebPubsubHubEventHandler")]
    public class WebPubsubHubEventHandler : azurerm.WebPubsubHub.IWebPubsubHubEventHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#url_template WebPubsubHub#url_template}.</summary>
        [JsiiProperty(name: "urlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public string UrlTemplate
        {
            get;
            set;
        }

        /// <summary>auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#auth WebPubsubHub#auth}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"azurerm.webPubsubHub.WebPubsubHubEventHandlerAuth\"}", isOptional: true)]
        public azurerm.WebPubsubHub.IWebPubsubHubEventHandlerAuth? Auth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#system_events WebPubsubHub#system_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SystemEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#user_event_pattern WebPubsubHub#user_event_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userEventPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserEventPattern
        {
            get;
            set;
        }
    }
}
