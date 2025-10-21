using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration : azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#instance_count WorkloadsSapThreeTierVirtualInstance#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#subnet_id WorkloadsSapThreeTierVirtualInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>virtual_machine_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#virtual_machine_configuration WorkloadsSapThreeTierVirtualInstance#virtual_machine_configuration}
        /// </remarks>
        [JsiiProperty(name: "virtualMachineConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfigurationVirtualMachineConfiguration\"}")]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfigurationVirtualMachineConfiguration VirtualMachineConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#database_type WorkloadsSapThreeTierVirtualInstance#database_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DatabaseType
        {
            get;
            set;
        }

        private object? _diskVolumeConfiguration;

        /// <summary>disk_volume_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#disk_volume_configuration WorkloadsSapThreeTierVirtualInstance#disk_volume_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskVolumeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfigurationDiskVolumeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DiskVolumeConfiguration
        {
            get => _diskVolumeConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfigurationDiskVolumeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfigurationDiskVolumeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _diskVolumeConfiguration = value;
            }
        }
    }
}
