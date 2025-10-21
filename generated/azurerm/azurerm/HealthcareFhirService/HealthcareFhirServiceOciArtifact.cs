using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareFhirService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.healthcareFhirService.HealthcareFhirServiceOciArtifact")]
    public class HealthcareFhirServiceOciArtifact : azurerm.HealthcareFhirService.IHealthcareFhirServiceOciArtifact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#login_server HealthcareFhirService#login_server}.</summary>
        [JsiiProperty(name: "loginServer", typeJson: "{\"primitive\":\"string\"}")]
        public string LoginServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#digest HealthcareFhirService#digest}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Digest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#image_name HealthcareFhirService#image_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageName
        {
            get;
            set;
        }
    }
}
