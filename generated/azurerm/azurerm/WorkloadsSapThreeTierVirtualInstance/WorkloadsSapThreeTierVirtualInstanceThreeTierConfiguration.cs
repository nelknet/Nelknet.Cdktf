using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration : azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration
    {
        /// <summary>application_server_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#application_server_configuration WorkloadsSapThreeTierVirtualInstance#application_server_configuration}
        /// </remarks>
        [JsiiProperty(name: "applicationServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration\"}")]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration ApplicationServerConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#app_resource_group_name WorkloadsSapThreeTierVirtualInstance#app_resource_group_name}.</summary>
        [JsiiProperty(name: "appResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AppResourceGroupName
        {
            get;
            set;
        }

        /// <summary>central_server_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#central_server_configuration WorkloadsSapThreeTierVirtualInstance#central_server_configuration}
        /// </remarks>
        [JsiiProperty(name: "centralServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration\"}")]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration CentralServerConfiguration
        {
            get;
            set;
        }

        /// <summary>database_server_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#database_server_configuration WorkloadsSapThreeTierVirtualInstance#database_server_configuration}
        /// </remarks>
        [JsiiProperty(name: "databaseServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration\"}")]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration DatabaseServerConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#high_availability_type WorkloadsSapThreeTierVirtualInstance#high_availability_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "highAvailabilityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HighAvailabilityType
        {
            get;
            set;
        }

        /// <summary>resource_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_names WorkloadsSapThreeTierVirtualInstance#resource_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceNames", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames\"}", isOptional: true)]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames? ResourceNames
        {
            get;
            set;
        }

        private object? _secondaryIpEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#secondary_ip_enabled WorkloadsSapThreeTierVirtualInstance#secondary_ip_enabled}.</summary>
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

        /// <summary>transport_create_and_mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#transport_create_and_mount WorkloadsSapThreeTierVirtualInstance#transport_create_and_mount}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transportCreateAndMount", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount\"}", isOptional: true)]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount? TransportCreateAndMount
        {
            get;
            set;
        }
    }
}
