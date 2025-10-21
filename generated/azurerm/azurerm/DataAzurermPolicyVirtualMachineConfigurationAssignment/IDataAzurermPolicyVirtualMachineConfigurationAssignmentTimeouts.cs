using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts")]
    public interface IDataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#read DataAzurermPolicyVirtualMachineConfigurationAssignment#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts), fullyQualifiedName: "azurerm.dataAzurermPolicyVirtualMachineConfigurationAssignment.DataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPolicyVirtualMachineConfigurationAssignment.IDataAzurermPolicyVirtualMachineConfigurationAssignmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_virtual_machine_configuration_assignment#read DataAzurermPolicyVirtualMachineConfigurationAssignment#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
