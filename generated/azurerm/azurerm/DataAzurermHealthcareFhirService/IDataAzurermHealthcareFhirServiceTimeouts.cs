using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHealthcareFhirService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermHealthcareFhirServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermHealthcareFhirService.DataAzurermHealthcareFhirServiceTimeouts")]
    public interface IDataAzurermHealthcareFhirServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#read DataAzurermHealthcareFhirService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermHealthcareFhirServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermHealthcareFhirService.DataAzurermHealthcareFhirServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermHealthcareFhirService.IDataAzurermHealthcareFhirServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_fhir_service#read DataAzurermHealthcareFhirService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
