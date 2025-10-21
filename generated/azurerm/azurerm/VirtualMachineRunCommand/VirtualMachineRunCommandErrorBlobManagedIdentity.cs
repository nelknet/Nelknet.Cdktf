using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineRunCommand
{
    [JsiiByValue(fqn: "azurerm.virtualMachineRunCommand.VirtualMachineRunCommandErrorBlobManagedIdentity")]
    public class VirtualMachineRunCommandErrorBlobManagedIdentity : azurerm.VirtualMachineRunCommand.IVirtualMachineRunCommandErrorBlobManagedIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#client_id VirtualMachineRunCommand#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_run_command#object_id VirtualMachineRunCommand#object_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectId
        {
            get;
            set;
        }
    }
}
