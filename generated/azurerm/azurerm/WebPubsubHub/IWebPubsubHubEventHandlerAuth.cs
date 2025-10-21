using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubHub
{
    [JsiiInterface(nativeType: typeof(IWebPubsubHubEventHandlerAuth), fullyQualifiedName: "azurerm.webPubsubHub.WebPubsubHubEventHandlerAuth")]
    public interface IWebPubsubHubEventHandlerAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#managed_identity_id WebPubsubHub#managed_identity_id}.</summary>
        [JsiiProperty(name: "managedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagedIdentityId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWebPubsubHubEventHandlerAuth), fullyQualifiedName: "azurerm.webPubsubHub.WebPubsubHubEventHandlerAuth")]
        internal sealed class _Proxy : DeputyBase, azurerm.WebPubsubHub.IWebPubsubHubEventHandlerAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/web_pubsub_hub#managed_identity_id WebPubsubHub#managed_identity_id}.</summary>
            [JsiiProperty(name: "managedIdentityId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagedIdentityId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
