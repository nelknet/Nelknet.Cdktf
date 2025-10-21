using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrchestratedVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent")]
    public interface IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#content OrchestratedVirtualMachineScaleSet#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#setting OrchestratedVirtualMachineScaleSet#setting}.</summary>
        [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
        string Setting
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent), fullyQualifiedName: "azurerm.orchestratedVirtualMachineScaleSet.OrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrchestratedVirtualMachineScaleSet.IOrchestratedVirtualMachineScaleSetOsProfileWindowsConfigurationAdditionalUnattendContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#content OrchestratedVirtualMachineScaleSet#content}.</summary>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orchestrated_virtual_machine_scale_set#setting OrchestratedVirtualMachineScaleSet#setting}.</summary>
            [JsiiProperty(name: "setting", typeJson: "{\"primitive\":\"string\"}")]
            public string Setting
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
