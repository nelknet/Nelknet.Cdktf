using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineBootDiagnostics), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineBootDiagnostics")]
    public interface IVirtualMachineBootDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#enabled VirtualMachine#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#storage_uri VirtualMachine#storage_uri}.</summary>
        [JsiiProperty(name: "storageUri", typeJson: "{\"primitive\":\"string\"}")]
        string StorageUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineBootDiagnostics), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachineBootDiagnostics")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachine.IVirtualMachineBootDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#enabled VirtualMachine#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#storage_uri VirtualMachine#storage_uri}.</summary>
            [JsiiProperty(name: "storageUri", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
