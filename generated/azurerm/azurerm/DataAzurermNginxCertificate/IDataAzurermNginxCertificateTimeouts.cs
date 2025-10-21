using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxCertificate
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNginxCertificateTimeouts), fullyQualifiedName: "azurerm.dataAzurermNginxCertificate.DataAzurermNginxCertificateTimeouts")]
    public interface IDataAzurermNginxCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#read DataAzurermNginxCertificate#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNginxCertificateTimeouts), fullyQualifiedName: "azurerm.dataAzurermNginxCertificate.DataAzurermNginxCertificateTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNginxCertificate.IDataAzurermNginxCertificateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#read DataAzurermNginxCertificate#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
