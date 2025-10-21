using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IDataAzurermVirtualMachineTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualMachine.DataAzurermVirtualMachineTimeouts")]
    public interface IDataAzurermVirtualMachineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#read DataAzurermVirtualMachine#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermVirtualMachineTimeouts), fullyQualifiedName: "azurerm.dataAzurermVirtualMachine.DataAzurermVirtualMachineTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermVirtualMachine.IDataAzurermVirtualMachineTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_machine#read DataAzurermVirtualMachine#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
