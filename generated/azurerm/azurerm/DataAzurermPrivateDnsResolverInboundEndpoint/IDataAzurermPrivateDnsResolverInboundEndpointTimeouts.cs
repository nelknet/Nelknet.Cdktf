using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsResolverInboundEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsResolverInboundEndpointTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpointTimeouts")]
    public interface IDataAzurermPrivateDnsResolverInboundEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint#read DataAzurermPrivateDnsResolverInboundEndpoint#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsResolverInboundEndpointTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolverInboundEndpoint.DataAzurermPrivateDnsResolverInboundEndpointTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsResolverInboundEndpoint.IDataAzurermPrivateDnsResolverInboundEndpointTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_inbound_endpoint#read DataAzurermPrivateDnsResolverInboundEndpoint#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
