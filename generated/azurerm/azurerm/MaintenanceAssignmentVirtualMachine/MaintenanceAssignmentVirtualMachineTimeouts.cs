using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceAssignmentVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.maintenanceAssignmentVirtualMachine.MaintenanceAssignmentVirtualMachineTimeouts")]
    public class MaintenanceAssignmentVirtualMachineTimeouts : azurerm.MaintenanceAssignmentVirtualMachine.IMaintenanceAssignmentVirtualMachineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#create MaintenanceAssignmentVirtualMachine#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#delete MaintenanceAssignmentVirtualMachine#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_assignment_virtual_machine#read MaintenanceAssignmentVirtualMachine#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
