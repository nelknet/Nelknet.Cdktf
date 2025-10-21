using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchCertificate
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBatchCertificateTimeouts), fullyQualifiedName: "azurerm.dataAzurermBatchCertificate.DataAzurermBatchCertificateTimeouts")]
    public interface IDataAzurermBatchCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#read DataAzurermBatchCertificate#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBatchCertificateTimeouts), fullyQualifiedName: "azurerm.dataAzurermBatchCertificate.DataAzurermBatchCertificateTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBatchCertificate.IDataAzurermBatchCertificateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#read DataAzurermBatchCertificate#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
