using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachineSecretCertificate), fullyQualifiedName: "azurerm.linuxVirtualMachine.LinuxVirtualMachineSecretCertificate")]
    public interface ILinuxVirtualMachineSecretCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#url LinuxVirtualMachine#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachineSecretCertificate), fullyQualifiedName: "azurerm.linuxVirtualMachine.LinuxVirtualMachineSecretCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxVirtualMachine.ILinuxVirtualMachineSecretCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#url LinuxVirtualMachine#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
