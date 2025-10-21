using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiInterface(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration")]
    public interface IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#instance_count WorkloadsSapThreeTierVirtualInstance#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#subnet_id WorkloadsSapThreeTierVirtualInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>virtual_machine_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#virtual_machine_configuration WorkloadsSapThreeTierVirtualInstance#virtual_machine_configuration}
        /// </remarks>
        [JsiiProperty(name: "virtualMachineConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfigurationVirtualMachineConfiguration\"}")]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfigurationVirtualMachineConfiguration VirtualMachineConfiguration
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#instance_count WorkloadsSapThreeTierVirtualInstance#instance_count}.</summary>
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#subnet_id WorkloadsSapThreeTierVirtualInstance#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>virtual_machine_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#virtual_machine_configuration WorkloadsSapThreeTierVirtualInstance#virtual_machine_configuration}
            /// </remarks>
            [JsiiProperty(name: "virtualMachineConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfigurationVirtualMachineConfiguration\"}")]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfigurationVirtualMachineConfiguration VirtualMachineConfiguration
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfigurationVirtualMachineConfiguration>()!;
            }
        }
    }
}
