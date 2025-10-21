using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment
{
    [JsiiByValue(fqn: "azurerm.dataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts")]
    public class DataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts : azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.IDataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#read DataAzurermPolicyVirtualMachineConfigurationAssignment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
