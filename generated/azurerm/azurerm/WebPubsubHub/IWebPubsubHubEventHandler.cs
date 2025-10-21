using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubHub
{
    [JsiiInterface(nativeType: typeof(IWebPubsubHubEventHandler), fullyQualifiedName: "azurerm.webPubsubHub.WebPubsubHubEventHandler")]
    public interface IWebPubsubHubEventHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#url_template WebPubsubHub#url_template}.</summary>
        [JsiiProperty(name: "urlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string UrlTemplate
        {
            get;
        }

        /// <summary>auth block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#auth WebPubsubHub#auth}
        /// </remarks>
        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"azurerm.webPubsubHub.WebPubsubHubEventHandlerAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WebPubsubHub.IWebPubsubHubEventHandlerAuth? Auth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#system_events WebPubsubHub#system_events}.</summary>
        [JsiiProperty(name: "systemEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SystemEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#user_event_pattern WebPubsubHub#user_event_pattern}.</summary>
        [JsiiProperty(name: "userEventPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserEventPattern
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWebPubsubHubEventHandler), fullyQualifiedName: "azurerm.webPubsubHub.WebPubsubHubEventHandler")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebPubsubHub.IWebPubsubHubEventHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#url_template WebPubsubHub#url_template}.</summary>
            [JsiiProperty(name: "urlTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string UrlTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>auth block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#auth WebPubsubHub#auth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"azurerm.webPubsubHub.WebPubsubHubEventHandlerAuth\"}", isOptional: true)]
            public azurerm.WebPubsubHub.IWebPubsubHubEventHandlerAuth? Auth
            {
                get => GetInstanceProperty<azurerm.WebPubsubHub.IWebPubsubHubEventHandlerAuth?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#system_events WebPubsubHub#system_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "systemEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SystemEvents
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#user_event_pattern WebPubsubHub#user_event_pattern}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userEventPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserEventPattern
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
