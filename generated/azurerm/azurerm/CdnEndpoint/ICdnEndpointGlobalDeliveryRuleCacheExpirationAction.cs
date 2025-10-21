using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointGlobalDeliveryRuleCacheExpirationAction), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction")]
    public interface ICdnEndpointGlobalDeliveryRuleCacheExpirationAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#behavior CdnEndpoint#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        string Behavior
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#duration CdnEndpoint#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointGlobalDeliveryRuleCacheExpirationAction), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#behavior CdnEndpoint#behavior}.</summary>
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
            public string Behavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#duration CdnEndpoint#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
