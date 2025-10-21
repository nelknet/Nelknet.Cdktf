using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterConfig")]
    public class KubernetesClusterConfig : azurerm.KubernetesCluster.IKubernetesClusterConfig
    {
        /// <summary>default_node_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#default_node_pool KubernetesCluster#default_node_pool}
        /// </remarks>
        [JsiiProperty(name: "defaultNodePool", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePool\"}")]
        public azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePool DefaultNodePool
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#location KubernetesCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#name KubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#resource_group_name KubernetesCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>aci_connector_linux block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#aci_connector_linux KubernetesCluster#aci_connector_linux}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aciConnectorLinux", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAciConnectorLinux\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterAciConnectorLinux? AciConnectorLinux
        {
            get;
            set;
        }

        /// <summary>api_server_access_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#api_server_access_profile KubernetesCluster#api_server_access_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiServerAccessProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterApiServerAccessProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterApiServerAccessProfile? ApiServerAccessProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#automatic_upgrade_channel KubernetesCluster#automatic_upgrade_channel}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automaticUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutomaticUpgradeChannel
        {
            get;
            set;
        }

        /// <summary>auto_scaler_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#auto_scaler_profile KubernetesCluster#auto_scaler_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoScalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile? AutoScalerProfile
        {
            get;
            set;
        }

        /// <summary>azure_active_directory_role_based_access_control block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_active_directory_role_based_access_control KubernetesCluster#azure_active_directory_role_based_access_control}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectoryRoleBasedAccessControl", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterAzureActiveDirectoryRoleBasedAccessControl\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterAzureActiveDirectoryRoleBasedAccessControl? AzureActiveDirectoryRoleBasedAccessControl
        {
            get;
            set;
        }

        private object? _azurePolicyEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#azure_policy_enabled KubernetesCluster#azure_policy_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "azurePolicyEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AzurePolicyEnabled
        {
            get => _azurePolicyEnabled;
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
                _azurePolicyEnabled = value;
            }
        }

        /// <summary>confidential_computing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#confidential_computing KubernetesCluster#confidential_computing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confidentialComputing", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing? ConfidentialComputing
        {
            get;
            set;
        }

        private object? _costAnalysisEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cost_analysis_enabled KubernetesCluster#cost_analysis_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "costAnalysisEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CostAnalysisEnabled
        {
            get => _costAnalysisEnabled;
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
                _costAnalysisEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#disk_encryption_set_id KubernetesCluster#disk_encryption_set_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionSetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskEncryptionSetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix KubernetesCluster#dns_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_prefix_private_cluster KubernetesCluster#dns_prefix_private_cluster}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsPrefixPrivateCluster", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsPrefixPrivateCluster
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#edge_zone KubernetesCluster#edge_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EdgeZone
        {
            get;
            set;
        }

        private object? _httpApplicationRoutingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_application_routing_enabled KubernetesCluster#http_application_routing_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpApplicationRoutingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HttpApplicationRoutingEnabled
        {
            get => _httpApplicationRoutingEnabled;
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
                _httpApplicationRoutingEnabled = value;
            }
        }

        /// <summary>http_proxy_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy_config KubernetesCluster#http_proxy_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpProxyConfig", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig? HttpProxyConfig
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#identity KubernetesCluster#identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIdentity\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterIdentity? Identity
        {
            get;
            set;
        }

        private object? _imageCleanerEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_enabled KubernetesCluster#image_cleaner_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageCleanerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ImageCleanerEnabled
        {
            get => _imageCleanerEnabled;
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
                _imageCleanerEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#image_cleaner_interval_hours KubernetesCluster#image_cleaner_interval_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageCleanerIntervalHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ImageCleanerIntervalHours
        {
            get;
            set;
        }

        /// <summary>ingress_application_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ingress_application_gateway KubernetesCluster#ingress_application_gateway}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ingressApplicationGateway", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGateway\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway? IngressApplicationGateway
        {
            get;
            set;
        }

        /// <summary>key_management_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_management_service KubernetesCluster#key_management_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyManagementService", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyManagementService\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterKeyManagementService? KeyManagementService
        {
            get;
            set;
        }

        /// <summary>key_vault_secrets_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_secrets_provider KubernetesCluster#key_vault_secrets_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyVaultSecretsProvider", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider? KeyVaultSecretsProvider
        {
            get;
            set;
        }

        /// <summary>kubelet_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubelet_identity KubernetesCluster#kubelet_identity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kubeletIdentity", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterKubeletIdentity\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterKubeletIdentity? KubeletIdentity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#kubernetes_version KubernetesCluster#kubernetes_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetesVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KubernetesVersion
        {
            get;
            set;
        }

        /// <summary>linux_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#linux_profile KubernetesCluster#linux_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linuxProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile? LinuxProfile
        {
            get;
            set;
        }

        private object? _localAccountDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#local_account_disabled KubernetesCluster#local_account_disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localAccountDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LocalAccountDisabled
        {
            get => _localAccountDisabled;
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
                _localAccountDisabled = value;
            }
        }

        /// <summary>maintenance_window block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window KubernetesCluster#maintenance_window}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>maintenance_window_auto_upgrade block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_auto_upgrade KubernetesCluster#maintenance_window_auto_upgrade}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowAutoUpgrade", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAutoUpgrade\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowAutoUpgrade? MaintenanceWindowAutoUpgrade
        {
            get;
            set;
        }

        /// <summary>maintenance_window_node_os block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#maintenance_window_node_os KubernetesCluster#maintenance_window_node_os}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowNodeOs", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNodeOs\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindowNodeOs? MaintenanceWindowNodeOs
        {
            get;
            set;
        }

        /// <summary>microsoft_defender block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#microsoft_defender KubernetesCluster#microsoft_defender}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "microsoftDefender", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMicrosoftDefender\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterMicrosoftDefender? MicrosoftDefender
        {
            get;
            set;
        }

        /// <summary>monitor_metrics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#monitor_metrics KubernetesCluster#monitor_metrics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "monitorMetrics", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMonitorMetrics\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterMonitorMetrics? MonitorMetrics
        {
            get;
            set;
        }

        /// <summary>network_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#network_profile KubernetesCluster#network_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterNetworkProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterNetworkProfile? NetworkProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_os_upgrade_channel KubernetesCluster#node_os_upgrade_channel}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeOsUpgradeChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeOsUpgradeChannel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_resource_group KubernetesCluster#node_resource_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeResourceGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeResourceGroup
        {
            get;
            set;
        }

        private object? _oidcIssuerEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oidc_issuer_enabled KubernetesCluster#oidc_issuer_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oidcIssuerEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? OidcIssuerEnabled
        {
            get => _oidcIssuerEnabled;
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
                _oidcIssuerEnabled = value;
            }
        }

        /// <summary>oms_agent block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#oms_agent KubernetesCluster#oms_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "omsAgent", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterOmsAgent\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterOmsAgent? OmsAgent
        {
            get;
            set;
        }

        private object? _openServiceMeshEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#open_service_mesh_enabled KubernetesCluster#open_service_mesh_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "openServiceMeshEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? OpenServiceMeshEnabled
        {
            get => _openServiceMeshEnabled;
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
                _openServiceMeshEnabled = value;
            }
        }

        private object? _privateClusterEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_enabled KubernetesCluster#private_cluster_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateClusterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PrivateClusterEnabled
        {
            get => _privateClusterEnabled;
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
                _privateClusterEnabled = value;
            }
        }

        private object? _privateClusterPublicFqdnEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_cluster_public_fqdn_enabled KubernetesCluster#private_cluster_public_fqdn_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateClusterPublicFqdnEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PrivateClusterPublicFqdnEnabled
        {
            get => _privateClusterPublicFqdnEnabled;
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
                _privateClusterPublicFqdnEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#private_dns_zone_id KubernetesCluster#private_dns_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateDnsZoneId
        {
            get;
            set;
        }

        private object? _roleBasedAccessControlEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#role_based_access_control_enabled KubernetesCluster#role_based_access_control_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleBasedAccessControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RoleBasedAccessControlEnabled
        {
            get => _roleBasedAccessControlEnabled;
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
                _roleBasedAccessControlEnabled = value;
            }
        }

        private object? _runCommandEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#run_command_enabled KubernetesCluster#run_command_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runCommandEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RunCommandEnabled
        {
            get => _runCommandEnabled;
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
                _runCommandEnabled = value;
            }
        }

        /// <summary>service_mesh_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_mesh_profile KubernetesCluster#service_mesh_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceMeshProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile? ServiceMeshProfile
        {
            get;
            set;
        }

        /// <summary>service_principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#service_principal KubernetesCluster#service_principal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServicePrincipal\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterServicePrincipal? ServicePrincipal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#sku_tier KubernetesCluster#sku_tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SkuTier
        {
            get;
            set;
        }

        /// <summary>storage_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#storage_profile KubernetesCluster#storage_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterStorageProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterStorageProfile? StorageProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#support_plan KubernetesCluster#support_plan}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportPlan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SupportPlan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#tags KubernetesCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>web_app_routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#web_app_routing KubernetesCluster#web_app_routing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webAppRouting", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWebAppRouting\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting? WebAppRouting
        {
            get;
            set;
        }

        /// <summary>windows_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#windows_profile KubernetesCluster#windows_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "windowsProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWindowsProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterWindowsProfile? WindowsProfile
        {
            get;
            set;
        }

        /// <summary>workload_autoscaler_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_autoscaler_profile KubernetesCluster#workload_autoscaler_profile}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workloadAutoscalerProfile", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterWorkloadAutoscalerProfile\"}", isOptional: true)]
        public azurerm.KubernetesCluster.IKubernetesClusterWorkloadAutoscalerProfile? WorkloadAutoscalerProfile
        {
            get;
            set;
        }

        private object? _workloadIdentityEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#workload_identity_enabled KubernetesCluster#workload_identity_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workloadIdentityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? WorkloadIdentityEnabled
        {
            get => _workloadIdentityEnabled;
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
                _workloadIdentityEnabled = value;
            }
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.ISSHProvisionerConnection).FullName}, {typeof(HashiCorp.Cdktf.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(HashiCorp.Cdktf.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case HashiCorp.Cdktf.IFileProvisioner cast_e9c63e:
                                break;
                            case HashiCorp.Cdktf.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case HashiCorp.Cdktf.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(HashiCorp.Cdktf.IFileProvisioner).FullName}, {typeof(HashiCorp.Cdktf.ILocalExecProvisioner).FullName}, {typeof(HashiCorp.Cdktf.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(HashiCorp.Cdktf.IFileProvisioner).FullName}, {typeof(HashiCorp.Cdktf.ILocalExecProvisioner).FullName}, {typeof(HashiCorp.Cdktf.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
