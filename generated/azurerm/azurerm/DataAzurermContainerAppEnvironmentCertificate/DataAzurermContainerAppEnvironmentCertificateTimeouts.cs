using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerAppEnvironmentCertificate
{
    [JsiiByValue(fqn: "azurerm.dataAzurermContainerAppEnvironmentCertificate.DataAzurermContainerAppEnvironmentCertificateTimeouts")]
    public class DataAzurermContainerAppEnvironmentCertificateTimeouts : azurerm.DataAzurermContainerAppEnvironmentCertificate.IDataAzurermContainerAppEnvironmentCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment_certificate#read DataAzurermContainerAppEnvironmentCertificate#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
