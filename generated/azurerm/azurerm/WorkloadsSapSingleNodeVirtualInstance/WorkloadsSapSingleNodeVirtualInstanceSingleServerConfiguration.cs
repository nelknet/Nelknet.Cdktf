using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapSingleNodeVirtualInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.workloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceSingleServerConfiguration")]
    public class WorkloadsSapSingleNodeVirtualInstanceSingleServerConfiguration : azurerm.WorkloadsSapSingleNodeVirtualInstance.IWorkloadsSapSingleNodeVirtualInstanceSingleServerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#app_resource_group_name WorkloadsSapSingleNodeVirtualInstance#app_resource_group_name}.</summary>
        [JsiiProperty(name: "appResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AppResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#subnet_id WorkloadsSapSingleNodeVirtualInstance#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        /// <summary>virtual_machine_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#virtual_machine_configuration WorkloadsSapSingleNodeVirtualInstance#virtual_machine_configuration}
        /// </remarks>
        [JsiiProperty(name: "virtualMachineConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationVirtualMachineConfiguration\"}")]
        public azurerm.WorkloadsSapSingleNodeVirtualInstance.IWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationVirtualMachineConfiguration VirtualMachineConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#database_type WorkloadsSapSingleNodeVirtualInstance#database_type}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#disk_volume_configuration WorkloadsSapSingleNodeVirtualInstance#disk_volume_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diskVolumeConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.workloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationDiskVolumeConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.WorkloadsSapSingleNodeVirtualInstance.IWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationDiskVolumeConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WorkloadsSapSingleNodeVirtualInstance.IWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationDiskVolumeConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _diskVolumeConfiguration = value;
            }
        }

        private object? _secondaryIpEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#secondary_ip_enabled WorkloadsSapSingleNodeVirtualInstance#secondary_ip_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SecondaryIpEnabled
        {
            get => _secondaryIpEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryIpEnabled = value;
            }
        }

        /// <summary>virtual_machine_resource_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_single_node_virtual_instance#virtual_machine_resource_names WorkloadsSapSingleNodeVirtualInstance#virtual_machine_resource_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineResourceNames", typeJson: "{\"fqn\":\"azurerm.workloadsSapSingleNodeVirtualInstance.WorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationVirtualMachineResourceNames\"}", isOptional: true)]
        public azurerm.WorkloadsSapSingleNodeVirtualInstance.IWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationVirtualMachineResourceNames? VirtualMachineResourceNames
        {
            get;
            set;
        }
    }
}
