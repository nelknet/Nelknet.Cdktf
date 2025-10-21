using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServiceCertificate
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppServiceCertificateTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppServiceCertificate.DataAzurermAppServiceCertificateTimeouts")]
    public interface IDataAzurermAppServiceCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#read DataAzurermAppServiceCertificate#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppServiceCertificateTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppServiceCertificate.DataAzurermAppServiceCertificateTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppServiceCertificate.IDataAzurermAppServiceCertificateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#read DataAzurermAppServiceCertificate#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
