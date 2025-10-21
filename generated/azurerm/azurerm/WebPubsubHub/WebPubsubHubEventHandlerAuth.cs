using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubHub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webPubsubHub.WebPubsubHubEventHandlerAuth")]
    public class WebPubsubHubEventHandlerAuth : azurerm.WebPubsubHub.IWebPubsubHubEventHandlerAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#managed_identity_id WebPubsubHub#managed_identity_id}.</summary>
        [JsiiProperty(name: "managedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        public string ManagedIdentityId
        {
            get;
            set;
        }
    }
}
