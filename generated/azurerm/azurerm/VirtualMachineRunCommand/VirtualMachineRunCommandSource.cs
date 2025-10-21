using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    [JsiiByValue(fqn: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSource")]
    public class VirtualMachineRunCommandSource : azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#command_id VirtualMachineRunCommand#command_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "commandId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CommandId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script VirtualMachineRunCommand#script}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "script", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Script
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script_uri VirtualMachineRunCommand#script_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scriptUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScriptUri
        {
            get;
            set;
        }

        /// <summary>script_uri_managed_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#script_uri_managed_identity VirtualMachineRunCommand#script_uri_managed_identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scriptUriManagedIdentity", typeJson: "{\"fqn\":\"azurerm.virtualMachineRunCommand.VirtualMachineRunCommandSourceScriptUriManagedIdentity\"}", isOptional: true)]
        public azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandSourceScriptUriManagedIdentity? ScriptUriManagedIdentity
        {
            get;
            set;
        }
    }
}
