using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsResolver
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPrivateDnsResolverTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolverTimeouts")]
    public interface IDataAzurermPrivateDnsResolverTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#read DataAzurermPrivateDnsResolver#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPrivateDnsResolverTimeouts), fullyQualifiedName: "azurerm.dataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolverTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPrivateDnsResolver.IDataAzurermPrivateDnsResolverTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#read DataAzurermPrivateDnsResolver#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
