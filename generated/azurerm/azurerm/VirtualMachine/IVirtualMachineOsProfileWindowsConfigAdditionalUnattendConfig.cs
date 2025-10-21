using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig")]
    public interface IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#component VirtualMachine#component}.</summary>
        [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}")]
        string Component
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#content VirtualMachine#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#pass VirtualMachine#pass}.</summary>
        [JsiiProperty(name: "pass", typeJson: "{\"primitive\":\"string\"}")]
        string Pass
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#setting_name VirtualMachine#setting_name}.</summary>
        [JsiiProperty(name: "settingName", typeJson: "{\"primitive\":\"string\"}")]
        string SettingName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfigAdditionalUnattendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#component VirtualMachine#component}.</summary>
            [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}")]
            public string Component
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#content VirtualMachine#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#pass VirtualMachine#pass}.</summary>
            [JsiiProperty(name: "pass", typeJson: "{\"primitive\":\"string\"}")]
            public string Pass
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#setting_name VirtualMachine#setting_name}.</summary>
            [JsiiProperty(name: "settingName", typeJson: "{\"primitive\":\"string\"}")]
            public string SettingName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
