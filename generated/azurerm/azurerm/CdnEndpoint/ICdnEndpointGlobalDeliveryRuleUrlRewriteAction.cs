using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointGlobalDeliveryRuleUrlRewriteAction), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction")]
    public interface ICdnEndpointGlobalDeliveryRuleUrlRewriteAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#destination CdnEndpoint#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#source_pattern CdnEndpoint#source_pattern}.</summary>
        [JsiiProperty(name: "sourcePattern", typeJson: "{\"primitive\":\"string\"}")]
        string SourcePattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#preserve_unmatched_path CdnEndpoint#preserve_unmatched_path}.</summary>
        [JsiiProperty(name: "preserveUnmatchedPath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreserveUnmatchedPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointGlobalDeliveryRuleUrlRewriteAction), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#destination CdnEndpoint#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#source_pattern CdnEndpoint#source_pattern}.</summary>
            [JsiiProperty(name: "sourcePattern", typeJson: "{\"primitive\":\"string\"}")]
            public string SourcePattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#preserve_unmatched_path CdnEndpoint#preserve_unmatched_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preserveUnmatchedPath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PreserveUnmatchedPath
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
