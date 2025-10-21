using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsResolverOutboundEndpointTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpointTimeouts")]
    public interface IDataAzurermPrivateDnsResolverOutboundEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint#read DataAzurermPrivateDnsResolverOutboundEndpoint#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsResolverOutboundEndpointTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolverOutboundEndpoint.DataAzurermPrivateDnsResolverOutboundEndpointTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsResolverOutboundEndpoint.IDataAzurermPrivateDnsResolverOutboundEndpointTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver_outbound_endpoint#read DataAzurermPrivateDnsResolverOutboundEndpoint#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
