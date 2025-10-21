using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualMachineScaleSet
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualMachineScaleSetTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeouts")]
    public interface IDataAzurermVirtualMachineScaleSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#read DataAzurermVirtualMachineScaleSet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualMachineScaleSetTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualMachineScaleSet.DataAzurermVirtualMachineScaleSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualMachineScaleSet.IDataAzurermVirtualMachineScaleSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine_scale_set#read DataAzurermVirtualMachineScaleSet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
