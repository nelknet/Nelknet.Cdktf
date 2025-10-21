using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiInterface(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration")]
    public interface IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration
    {
        /// <summary>application_server_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#application_server_configuration WorkloadsSapThreeTierVirtualInstance#application_server_configuration}
        /// </remarks>
        [JsiiProperty(name: "applicationServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration\"}")]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration ApplicationServerConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#app_resource_group_name WorkloadsSapThreeTierVirtualInstance#app_resource_group_name}.</summary>
        [JsiiProperty(name: "appResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string AppResourceGroupName
        {
            get;
        }

        /// <summary>central_server_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#central_server_configuration WorkloadsSapThreeTierVirtualInstance#central_server_configuration}
        /// </remarks>
        [JsiiProperty(name: "centralServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration\"}")]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration CentralServerConfiguration
        {
            get;
        }

        /// <summary>database_server_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#database_server_configuration WorkloadsSapThreeTierVirtualInstance#database_server_configuration}
        /// </remarks>
        [JsiiProperty(name: "databaseServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration\"}")]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration DatabaseServerConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#high_availability_type WorkloadsSapThreeTierVirtualInstance#high_availability_type}.</summary>
        [JsiiProperty(name: "highAvailabilityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HighAvailabilityType
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_names WorkloadsSapThreeTierVirtualInstance#resource_names}
        /// </remarks>
        [JsiiProperty(name: "resourceNames", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames? ResourceNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#secondary_ip_enabled WorkloadsSapThreeTierVirtualInstance#secondary_ip_enabled}.</summary>
        [JsiiProperty(name: "secondaryIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryIpEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>transport_create_and_mount block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#transport_create_and_mount WorkloadsSapThreeTierVirtualInstance#transport_create_and_mount}
        /// </remarks>
        [JsiiProperty(name: "transportCreateAndMount", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount? TransportCreateAndMount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_server_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#application_server_configuration WorkloadsSapThreeTierVirtualInstance#application_server_configuration}
            /// </remarks>
            [JsiiProperty(name: "applicationServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration\"}")]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration ApplicationServerConfiguration
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationApplicationServerConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#app_resource_group_name WorkloadsSapThreeTierVirtualInstance#app_resource_group_name}.</summary>
            [JsiiProperty(name: "appResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string AppResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>central_server_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#central_server_configuration WorkloadsSapThreeTierVirtualInstance#central_server_configuration}
            /// </remarks>
            [JsiiProperty(name: "centralServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration\"}")]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration CentralServerConfiguration
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationCentralServerConfiguration>()!;
            }

            /// <summary>database_server_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#database_server_configuration WorkloadsSapThreeTierVirtualInstance#database_server_configuration}
            /// </remarks>
            [JsiiProperty(name: "databaseServerConfiguration", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration\"}")]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration DatabaseServerConfiguration
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationDatabaseServerConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#high_availability_type WorkloadsSapThreeTierVirtualInstance#high_availability_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "highAvailabilityType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HighAvailabilityType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>resource_names block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#resource_names WorkloadsSapThreeTierVirtualInstance#resource_names}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceNames", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames\"}", isOptional: true)]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames? ResourceNames
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNames?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#secondary_ip_enabled WorkloadsSapThreeTierVirtualInstance#secondary_ip_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryIpEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SecondaryIpEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>transport_create_and_mount block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/workloads_sap_three_tier_virtual_instance#transport_create_and_mount WorkloadsSapThreeTierVirtualInstance#transport_create_and_mount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transportCreateAndMount", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount\"}", isOptional: true)]
            public azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount? TransportCreateAndMount
            {
                get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationTransportCreateAndMount?>();
            }
        }
    }
}
