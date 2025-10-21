using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.healthcareService.HealthcareServiceIdentity")]
    public class HealthcareServiceIdentity : azurerm.HealthcareService.IHealthcareServiceIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_service#type HealthcareService#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
