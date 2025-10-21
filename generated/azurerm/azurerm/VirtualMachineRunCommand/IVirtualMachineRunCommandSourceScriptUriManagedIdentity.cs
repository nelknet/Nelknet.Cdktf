using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineRunCommandSourceScriptUriManagedIdentity), fullyQualifiedName: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity")]
    public interface IVirtualMachineRunCommandSourceScriptUriManagedIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#client_id VirtualMachineRunCommand#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#object_id VirtualMachineRunCommand#object_id}.</summary>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineRunCommandSourceScriptUriManagedIdentity), fullyQualifiedName: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#client_id VirtualMachineRunCommand#client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#object_id VirtualMachineRunCommand#object_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
