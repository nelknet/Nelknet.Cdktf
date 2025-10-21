using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermArcMachine
{
    [JsiiInterface(nativeType: typeof(IDataAzurermArcMachineTimeouts), fullyQualifiedName: "azurerm.dataAzurermArcMachine.DataAzurermArcMachineTimeouts")]
    public interface IDataAzurermArcMachineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine#read DataAzurermArcMachine#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermArcMachineTimeouts), fullyQualifiedName: "azurerm.dataAzurermArcMachine.DataAzurermArcMachineTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermArcMachine.IDataAzurermArcMachineTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_machine#read DataAzurermArcMachine#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
