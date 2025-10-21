using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CustomProvider
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.customProvider.CustomProviderValidation")]
    public class CustomProviderValidation : azurerm.CustomProvider.ICustomProviderValidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#specification CustomProvider#specification}.</summary>
        [JsiiProperty(name: "specification", typeJson: "{\"primitive\":\"string\"}")]
        public string Specification
        {
            get;
            set;
        }
    }
}
