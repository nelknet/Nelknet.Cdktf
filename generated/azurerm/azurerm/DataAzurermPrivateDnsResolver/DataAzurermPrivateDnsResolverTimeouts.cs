using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPrivateDnsResolver
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolverTimeouts")]
    public class DataAzurermPrivateDnsResolverTimeouts : azurerm.DataAzurermPrivateDnsResolver.IDataAzurermPrivateDnsResolverTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#read DataAzurermPrivateDnsResolver#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
