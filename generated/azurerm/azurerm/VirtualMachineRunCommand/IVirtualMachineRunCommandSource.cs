using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineRunCommandSource), fullyQualifiedName: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSource")]
    public interface IVirtualMachineRunCommandSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#command_id VirtualMachineRunCommand#command_id}.</summary>
        [JsiiProperty(name: "commandId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommandId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script VirtualMachineRunCommand#script}.</summary>
        [JsiiProperty(name: "script", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Script
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script_uri VirtualMachineRunCommand#script_uri}.</summary>
        [JsiiProperty(name: "scriptUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScriptUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>script_uri_managed_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script_uri_managed_identity VirtualMachineRunCommand#script_uri_managed_identity}
        /// </remarks>
        [JsiiProperty(name: "scriptUriManagedIdentity", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity? ScriptUriManagedIdentity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineRunCommandSource), fullyQualifiedName: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#command_id VirtualMachineRunCommand#command_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commandId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommandId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script VirtualMachineRunCommand#script}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "script", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Script
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script_uri VirtualMachineRunCommand#script_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scriptUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScriptUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>script_uri_managed_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script_uri_managed_identity VirtualMachineRunCommand#script_uri_managed_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scriptUriManagedIdentity", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity\"}", isOptional: true)]
            public azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity? ScriptUriManagedIdentity
            {
                get => GetInstanceProperty<azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity?>();
            }
        }
    }
}
