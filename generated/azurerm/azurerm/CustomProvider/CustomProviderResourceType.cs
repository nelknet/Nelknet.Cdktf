using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CustomProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.customProvider.CustomProviderResourceType")]
    public class CustomProviderResourceType : azurerm.CustomProvider.ICustomProviderResourceType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#endpoint CustomProvider#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#name CustomProvider#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#routing_type CustomProvider#routing_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingType
        {
            get;
            set;
        }
    }
}
