using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HealthcareFhirService
{
    [JsiiInterface(nativeType: typeof(IHealthcareFhirServiceOciArtifact), fullyQualifiedName: "azurerm.healthcareFhirService.HealthcareFhirServiceOciArtifact")]
    public interface IHealthcareFhirServiceOciArtifact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#login_server HealthcareFhirService#login_server}.</summary>
        [JsiiProperty(name: "loginServer", typeJson: "{\"primitive\":\"string\"}")]
        string LoginServer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#digest HealthcareFhirService#digest}.</summary>
        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Digest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#image_name HealthcareFhirService#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHealthcareFhirServiceOciArtifact), fullyQualifiedName: "azurerm.healthcareFhirService.HealthcareFhirServiceOciArtifact")]
        internal sealed class _Proxy : DeputyBase, azurerm.HealthcareFhirService.IHealthcareFhirServiceOciArtifact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#login_server HealthcareFhirService#login_server}.</summary>
            [JsiiProperty(name: "loginServer", typeJson: "{\"primitive\":\"string\"}")]
            public string LoginServer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#digest HealthcareFhirService#digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Digest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/healthcare_fhir_service#image_name HealthcareFhirService#image_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
