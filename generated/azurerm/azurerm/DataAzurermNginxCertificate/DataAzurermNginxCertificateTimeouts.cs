using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxCertificate
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNginxCertificate.DataAzurermNginxCertificateTimeouts")]
    public class DataAzurermNginxCertificateTimeouts : azurerm.DataAzurermNginxCertificate.IDataAzurermNginxCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_certificate#read DataAzurermNginxCertificate#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
