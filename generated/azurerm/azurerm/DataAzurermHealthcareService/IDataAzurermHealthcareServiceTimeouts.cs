using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermHealthcareService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermHealthcareServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermHealthcareService.DataAzurermHealthcareServiceTimeouts")]
    public interface IDataAzurermHealthcareServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#read DataAzurermHealthcareService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermHealthcareServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermHealthcareService.DataAzurermHealthcareServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermHealthcareService.IDataAzurermHealthcareServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#read DataAzurermHealthcareService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
