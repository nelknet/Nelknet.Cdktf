using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiByValue(fqn: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames : azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames
    {
        /// <summary>application_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#application_server WorkloadsSapThreeTierVirtualInstance#application_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationServer", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer\"}", isOptional: true)]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer? ApplicationServer
        {
            get;
            set;
        }

        /// <summary>central_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#central_server WorkloadsSapThreeTierVirtualInstance#central_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "centralServer", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer\"}", isOptional: true)]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesCentralServer? CentralServer
        {
            get;
            set;
        }

        /// <summary>database_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#database_server WorkloadsSapThreeTierVirtualInstance#database_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "databaseServer", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer\"}", isOptional: true)]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesDatabaseServer? DatabaseServer
        {
            get;
            set;
        }

        /// <summary>shared_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#shared_storage WorkloadsSapThreeTierVirtualInstance#shared_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sharedStorage", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage\"}", isOptional: true)]
        public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesSharedStorage? SharedStorage
        {
            get;
            set;
        }
    }
}
