using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachine
{
    [JsiiInterface(nativeType: typeof(ILinuxVirtualMachinePlan), fullyQualifiedName: "azurerm.linuxVirtualMachine.LinuxVirtualMachinePlan")]
    public interface ILinuxVirtualMachinePlan
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#name LinuxVirtualMachine#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#product LinuxVirtualMachine#product}.</summary>
        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        string Product
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#publisher LinuxVirtualMachine#publisher}.</summary>
        [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
        string Publisher
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxVirtualMachinePlan), fullyQualifiedName: "azurerm.linuxVirtualMachine.LinuxVirtualMachinePlan")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxVirtualMachine.ILinuxVirtualMachinePlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#name LinuxVirtualMachine#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#product LinuxVirtualMachine#product}.</summary>
            [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
            public string Product
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine#publisher LinuxVirtualMachine#publisher}.</summary>
            [JsiiProperty(name: "publisher", typeJson: "{\"primitive\":\"string\"}")]
            public string Publisher
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
