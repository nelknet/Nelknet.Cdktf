using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualMachine.VirtualMachineOsProfileSecretsVaultCertificates")]
    public class VirtualMachineOsProfileSecretsVaultCertificates : azurerm.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#certificate_url VirtualMachine#certificate_url}.</summary>
        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#certificate_store VirtualMachine#certificate_store}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateStore
        {
            get;
            set;
        }
    }
}
