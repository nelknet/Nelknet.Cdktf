using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig")]
    public interface IVirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#component VirtualMachineScaleSet#component}.</summary>
        [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}")]
        string Component
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#content VirtualMachineScaleSet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#pass VirtualMachineScaleSet#pass}.</summary>
        [JsiiProperty(name: "pass", typeJson: "{\"primitive\":\"string\"}")]
        string Pass
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#setting_name VirtualMachineScaleSet#setting_name}.</summary>
        [JsiiProperty(name: "settingName", typeJson: "{\"primitive\":\"string\"}")]
        string SettingName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfigAdditionalUnattendConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#component VirtualMachineScaleSet#component}.</summary>
            [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}")]
            public string Component
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#content VirtualMachineScaleSet#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#pass VirtualMachineScaleSet#pass}.</summary>
            [JsiiProperty(name: "pass", typeJson: "{\"primitive\":\"string\"}")]
            public string Pass
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#setting_name VirtualMachineScaleSet#setting_name}.</summary>
            [JsiiProperty(name: "settingName", typeJson: "{\"primitive\":\"string\"}")]
            public string SettingName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
