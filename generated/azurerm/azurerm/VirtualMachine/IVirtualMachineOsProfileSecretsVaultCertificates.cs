using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileSecretsVaultCertificates), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileSecretsVaultCertificates")]
    public interface IVirtualMachineOsProfileSecretsVaultCertificates
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#certificate_url VirtualMachine#certificate_url}.</summary>
        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#certificate_store VirtualMachine#certificate_store}.</summary>
        [JsiiProperty(name: "certificateStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateStore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileSecretsVaultCertificates), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileSecretsVaultCertificates")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineOsProfileSecretsVaultCertificates
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#certificate_url VirtualMachine#certificate_url}.</summary>
            [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#certificate_store VirtualMachine#certificate_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateStore", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateStore
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
