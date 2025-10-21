using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterConfig), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterConfig")]
    public interface IKubernetesClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>default_node_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#default_node_pool KubernetesCluster#default_node_pool}
        /// </remarks>
        [JsiiProperty(name: "defaultNodePool", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool\"}")]
        azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool DefaultNodePool
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#location KubernetesCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#resource_group_name KubernetesCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>aci_connector_linux block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#aci_connector_linux KubernetesCluster#aci_connector_linux}
        /// </remarks>
        [JsiiProperty(name: "aciConnectorLinux", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux? AciConnectorLinux
        {
            get
            {
                return null;
            }
        }

        /// <summary>api_server_access_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#api_server_access_profile KubernetesCluster#api_server_access_profile}
        /// </remarks>
        [JsiiProperty(name: "apiServerAccessProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile? ApiServerAccessProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#automatic_upgrade_channel KubernetesCluster#automatic_upgrade_channel}.</summary>
        [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutomaticUpgradeChannel
        {
            get
            {
                return null;
            }
        }

        /// <summary>auto_scaler_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#auto_scaler_profile KubernetesCluster#auto_scaler_profile}
        /// </remarks>
        [JsiiProperty(name: "autoScalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile? AutoScalerProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>azure_active_directory_role_based_access_control block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_active_directory_role_based_access_control KubernetesCluster#azure_active_directory_role_based_access_control}
        /// </remarks>
        [JsiiProperty(name: "azureActiveDirectoryRoleBasedAccessControl", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl? AzureActiveDirectoryRoleBasedAccessControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_policy_enabled KubernetesCluster#azure_policy_enabled}.</summary>
        [JsiiProperty(name: "azurePolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzurePolicyEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>confidential_computing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#confidential_computing KubernetesCluster#confidential_computing}
        /// </remarks>
        [JsiiProperty(name: "confidentialComputing", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing? ConfidentialComputing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cost_analysis_enabled KubernetesCluster#cost_analysis_enabled}.</summary>
        [JsiiProperty(name: "costAnalysisEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CostAnalysisEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#disk_encryption_set_id KubernetesCluster#disk_encryption_set_id}.</summary>
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskEncryptionSetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix KubernetesCluster#dns_prefix}.</summary>
        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix_private_cluster KubernetesCluster#dns_prefix_private_cluster}.</summary>
        [JsiiProperty(name: "dnsPrefixPrivateCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsPrefixPrivateCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#edge_zone KubernetesCluster#edge_zone}.</summary>
        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EdgeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_application_routing_enabled KubernetesCluster#http_application_routing_enabled}.</summary>
        [JsiiProperty(name: "httpApplicationRoutingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpApplicationRoutingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_proxy_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy_config KubernetesCluster#http_proxy_config}
        /// </remarks>
        [JsiiProperty(name: "httpProxyConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig? HttpProxyConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#id KubernetesCluster#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#identity KubernetesCluster#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterIdentity? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_enabled KubernetesCluster#image_cleaner_enabled}.</summary>
        [JsiiProperty(name: "imageCleanerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ImageCleanerEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_interval_hours KubernetesCluster#image_cleaner_interval_hours}.</summary>
        [JsiiProperty(name: "imageCleanerIntervalHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImageCleanerIntervalHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>ingress_application_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ingress_application_gateway KubernetesCluster#ingress_application_gateway}
        /// </remarks>
        [JsiiProperty(name: "ingressApplicationGateway", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGateway\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway? IngressApplicationGateway
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_management_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_management_service KubernetesCluster#key_management_service}
        /// </remarks>
        [JsiiProperty(name: "keyManagementService", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyManagementService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService? KeyManagementService
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault_secrets_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_secrets_provider KubernetesCluster#key_vault_secrets_provider}
        /// </remarks>
        [JsiiProperty(name: "keyVaultSecretsProvider", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider? KeyVaultSecretsProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>kubelet_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_identity KubernetesCluster#kubelet_identity}
        /// </remarks>
        [JsiiProperty(name: "kubeletIdentity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeletIdentity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity? KubeletIdentity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubernetes_version KubernetesCluster#kubernetes_version}.</summary>
        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KubernetesVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>linux_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#linux_profile KubernetesCluster#linux_profile}
        /// </remarks>
        [JsiiProperty(name: "linuxProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile? LinuxProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#local_account_disabled KubernetesCluster#local_account_disabled}.</summary>
        [JsiiProperty(name: "localAccountDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LocalAccountDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window KubernetesCluster#maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window_auto_upgrade block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_auto_upgrade KubernetesCluster#maintenance_window_auto_upgrade}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowAutoUpgrade", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgrade\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade? MaintenanceWindowAutoUpgrade
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_window_node_os block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_node_os KubernetesCluster#maintenance_window_node_os}
        /// </remarks>
        [JsiiProperty(name: "maintenanceWindowNodeOs", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs? MaintenanceWindowNodeOs
        {
            get
            {
                return null;
            }
        }

        /// <summary>microsoft_defender block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#microsoft_defender KubernetesCluster#microsoft_defender}
        /// </remarks>
        [JsiiProperty(name: "microsoftDefender", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMicrosoftDefender\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender? MicrosoftDefender
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitor_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#monitor_metrics KubernetesCluster#monitor_metrics}
        /// </remarks>
        [JsiiProperty(name: "monitorMetrics", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics? MonitorMetrics
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_profile KubernetesCluster#network_profile}
        /// </remarks>
        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile? NetworkProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_os_upgrade_channel KubernetesCluster#node_os_upgrade_channel}.</summary>
        [JsiiProperty(name: "nodeOsUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeOsUpgradeChannel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_resource_group KubernetesCluster#node_resource_group}.</summary>
        [JsiiProperty(name: "nodeResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oidc_issuer_enabled KubernetesCluster#oidc_issuer_enabled}.</summary>
        [JsiiProperty(name: "oidcIssuerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OidcIssuerEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>oms_agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oms_agent KubernetesCluster#oms_agent}
        /// </remarks>
        [JsiiProperty(name: "omsAgent", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterOmsAgent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterOmsAgent? OmsAgent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#open_service_mesh_enabled KubernetesCluster#open_service_mesh_enabled}.</summary>
        [JsiiProperty(name: "openServiceMeshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OpenServiceMeshEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_enabled KubernetesCluster#private_cluster_enabled}.</summary>
        [JsiiProperty(name: "privateClusterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateClusterEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_public_fqdn_enabled KubernetesCluster#private_cluster_public_fqdn_enabled}.</summary>
        [JsiiProperty(name: "privateClusterPublicFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateClusterPublicFqdnEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_dns_zone_id KubernetesCluster#private_dns_zone_id}.</summary>
        [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateDnsZoneId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#role_based_access_control_enabled KubernetesCluster#role_based_access_control_enabled}.</summary>
        [JsiiProperty(name: "roleBasedAccessControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoleBasedAccessControlEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#run_command_enabled KubernetesCluster#run_command_enabled}.</summary>
        [JsiiProperty(name: "runCommandEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RunCommandEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_mesh_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_mesh_profile KubernetesCluster#service_mesh_profile}
        /// </remarks>
        [JsiiProperty(name: "serviceMeshProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile? ServiceMeshProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_principal KubernetesCluster#service_principal}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServicePrincipal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal? ServicePrincipal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#sku_tier KubernetesCluster#sku_tier}.</summary>
        [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkuTier
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#storage_profile KubernetesCluster#storage_profile}
        /// </remarks>
        [JsiiProperty(name: "storageProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterStorageProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterStorageProfile? StorageProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#support_plan KubernetesCluster#support_plan}.</summary>
        [JsiiProperty(name: "supportPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SupportPlan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_app_routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#web_app_routing KubernetesCluster#web_app_routing}
        /// </remarks>
        [JsiiProperty(name: "webAppRouting", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWebAppRouting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting? WebAppRouting
        {
            get
            {
                return null;
            }
        }

        /// <summary>windows_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#windows_profile KubernetesCluster#windows_profile}
        /// </remarks>
        [JsiiProperty(name: "windowsProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile? WindowsProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>workload_autoscaler_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_autoscaler_profile KubernetesCluster#workload_autoscaler_profile}
        /// </remarks>
        [JsiiProperty(name: "workloadAutoscalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile? WorkloadAutoscalerProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_identity_enabled KubernetesCluster#workload_identity_enabled}.</summary>
        [JsiiProperty(name: "workloadIdentityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WorkloadIdentityEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterConfig), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_node_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#default_node_pool KubernetesCluster#default_node_pool}
            /// </remarks>
            [JsiiProperty(name: "defaultNodePool", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool\"}")]
            public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool DefaultNodePool
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#location KubernetesCluster#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#resource_group_name KubernetesCluster#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>aci_connector_linux block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#aci_connector_linux KubernetesCluster#aci_connector_linux}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aciConnectorLinux", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux? AciConnectorLinux
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux?>();
            }

            /// <summary>api_server_access_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#api_server_access_profile KubernetesCluster#api_server_access_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiServerAccessProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile? ApiServerAccessProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#automatic_upgrade_channel KubernetesCluster#automatic_upgrade_channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutomaticUpgradeChannel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>auto_scaler_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#auto_scaler_profile KubernetesCluster#auto_scaler_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoScalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile? AutoScalerProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile?>();
            }

            /// <summary>azure_active_directory_role_based_access_control block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_active_directory_role_based_access_control KubernetesCluster#azure_active_directory_role_based_access_control}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureActiveDirectoryRoleBasedAccessControl", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControl\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl? AzureActiveDirectoryRoleBasedAccessControl
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_policy_enabled KubernetesCluster#azure_policy_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azurePolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AzurePolicyEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>confidential_computing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#confidential_computing KubernetesCluster#confidential_computing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confidentialComputing", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing? ConfidentialComputing
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cost_analysis_enabled KubernetesCluster#cost_analysis_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "costAnalysisEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CostAnalysisEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#disk_encryption_set_id KubernetesCluster#disk_encryption_set_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskEncryptionSetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix KubernetesCluster#dns_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix_private_cluster KubernetesCluster#dns_prefix_private_cluster}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsPrefixPrivateCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsPrefixPrivateCluster
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#edge_zone KubernetesCluster#edge_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EdgeZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_application_routing_enabled KubernetesCluster#http_application_routing_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpApplicationRoutingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HttpApplicationRoutingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_proxy_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy_config KubernetesCluster#http_proxy_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpProxyConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig? HttpProxyConfig
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#id KubernetesCluster#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#identity KubernetesCluster#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIdentity\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterIdentity? Identity
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_enabled KubernetesCluster#image_cleaner_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageCleanerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ImageCleanerEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_interval_hours KubernetesCluster#image_cleaner_interval_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageCleanerIntervalHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImageCleanerIntervalHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ingress_application_gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ingress_application_gateway KubernetesCluster#ingress_application_gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ingressApplicationGateway", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGateway\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway? IngressApplicationGateway
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway?>();
            }

            /// <summary>key_management_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_management_service KubernetesCluster#key_management_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyManagementService", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyManagementService\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService? KeyManagementService
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService?>();
            }

            /// <summary>key_vault_secrets_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_secrets_provider KubernetesCluster#key_vault_secrets_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultSecretsProvider", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider? KeyVaultSecretsProvider
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider?>();
            }

            /// <summary>kubelet_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_identity KubernetesCluster#kubelet_identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubeletIdentity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeletIdentity\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity? KubeletIdentity
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubernetes_version KubernetesCluster#kubernetes_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KubernetesVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>linux_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#linux_profile KubernetesCluster#linux_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linuxProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile? LinuxProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#local_account_disabled KubernetesCluster#local_account_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localAccountDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LocalAccountDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>maintenance_window block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window KubernetesCluster#maintenance_window}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow? MaintenanceWindow
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow?>();
            }

            /// <summary>maintenance_window_auto_upgrade block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_auto_upgrade KubernetesCluster#maintenance_window_auto_upgrade}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowAutoUpgrade", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgrade\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade? MaintenanceWindowAutoUpgrade
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade?>();
            }

            /// <summary>maintenance_window_node_os block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_node_os KubernetesCluster#maintenance_window_node_os}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindowNodeOs", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs? MaintenanceWindowNodeOs
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs?>();
            }

            /// <summary>microsoft_defender block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#microsoft_defender KubernetesCluster#microsoft_defender}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "microsoftDefender", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMicrosoftDefender\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender? MicrosoftDefender
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender?>();
            }

            /// <summary>monitor_metrics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#monitor_metrics KubernetesCluster#monitor_metrics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitorMetrics", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics? MonitorMetrics
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics?>();
            }

            /// <summary>network_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_profile KubernetesCluster#network_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile? NetworkProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_os_upgrade_channel KubernetesCluster#node_os_upgrade_channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeOsUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeOsUpgradeChannel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_resource_group KubernetesCluster#node_resource_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeResourceGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oidc_issuer_enabled KubernetesCluster#oidc_issuer_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oidcIssuerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OidcIssuerEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>oms_agent block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oms_agent KubernetesCluster#oms_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "omsAgent", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterOmsAgent\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterOmsAgent? OmsAgent
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterOmsAgent?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#open_service_mesh_enabled KubernetesCluster#open_service_mesh_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "openServiceMeshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OpenServiceMeshEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_enabled KubernetesCluster#private_cluster_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateClusterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PrivateClusterEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_public_fqdn_enabled KubernetesCluster#private_cluster_public_fqdn_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateClusterPublicFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PrivateClusterPublicFqdnEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_dns_zone_id KubernetesCluster#private_dns_zone_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateDnsZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#role_based_access_control_enabled KubernetesCluster#role_based_access_control_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleBasedAccessControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RoleBasedAccessControlEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#run_command_enabled KubernetesCluster#run_command_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RunCommandEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>service_mesh_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_mesh_profile KubernetesCluster#service_mesh_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceMeshProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile? ServiceMeshProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile?>();
            }

            /// <summary>service_principal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_principal KubernetesCluster#service_principal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServicePrincipal\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal? ServicePrincipal
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#sku_tier KubernetesCluster#sku_tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkuTier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storage_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#storage_profile KubernetesCluster#storage_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterStorageProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterStorageProfile? StorageProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterStorageProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#support_plan KubernetesCluster#support_plan}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SupportPlan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterTimeouts?>();
            }

            /// <summary>web_app_routing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#web_app_routing KubernetesCluster#web_app_routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webAppRouting", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWebAppRouting\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting? WebAppRouting
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting?>();
            }

            /// <summary>windows_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#windows_profile KubernetesCluster#windows_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "windowsProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile? WindowsProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile?>();
            }

            /// <summary>workload_autoscaler_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_autoscaler_profile KubernetesCluster#workload_autoscaler_profile}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workloadAutoscalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile? WorkloadAutoscalerProfile
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_identity_enabled KubernetesCluster#workload_identity_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workloadIdentityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? WorkloadIdentityEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
