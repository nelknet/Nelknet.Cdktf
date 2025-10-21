using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterConfig")]
    public class ServiceFabricClusterConfig : azurerm.ServiceFabricCluster.IServiceFabricClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#location ServiceFabricCluster#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#management_endpoint ServiceFabricCluster#management_endpoint}.</summary>
        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string ManagementEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#name ServiceFabricCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _nodeType;

        /// <summary>node_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#node_type ServiceFabricCluster#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeType\"},\"kind\":\"array\"}}]}}")]
        public object NodeType
        {
            get => _nodeType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nodeType = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reliability_level ServiceFabricCluster#reliability_level}.</summary>
        [JsiiProperty(name: "reliabilityLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string ReliabilityLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#resource_group_name ServiceFabricCluster#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_mode ServiceFabricCluster#upgrade_mode}.</summary>
        [JsiiProperty(name: "upgradeMode", typeJson: "{\"primitive\":\"string\"}")]
        public string UpgradeMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#vm_image ServiceFabricCluster#vm_image}.</summary>
        [JsiiProperty(name: "vmImage", typeJson: "{\"primitive\":\"string\"}")]
        public string VmImage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#add_on_features ServiceFabricCluster#add_on_features}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addOnFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AddOnFeatures
        {
            get;
            set;
        }

        /// <summary>azure_active_directory block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#azure_active_directory ServiceFabricCluster#azure_active_directory}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectory", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterAzureActiveDirectory\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterAzureActiveDirectory? AzureActiveDirectory
        {
            get;
            set;
        }

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate ServiceFabricCluster#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificate\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterCertificate? Certificate
        {
            get;
            set;
        }

        /// <summary>certificate_common_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_common_names ServiceFabricCluster#certificate_common_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificateCommonNames", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNames\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames? CertificateCommonNames
        {
            get;
            set;
        }

        private object? _clientCertificateCommonName;

        /// <summary>client_certificate_common_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_certificate_common_name ServiceFabricCluster#client_certificate_common_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateCommonName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClientCertificateCommonName
        {
            get => _clientCertificateCommonName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clientCertificateCommonName = value;
            }
        }

        private object? _clientCertificateThumbprint;

        /// <summary>client_certificate_thumbprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_certificate_thumbprint ServiceFabricCluster#client_certificate_thumbprint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateThumbprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateThumbprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ClientCertificateThumbprint
        {
            get => _clientCertificateThumbprint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateThumbprint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateThumbprint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _clientCertificateThumbprint = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#cluster_code_version ServiceFabricCluster#cluster_code_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterCodeVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClusterCodeVersion
        {
            get;
            set;
        }

        /// <summary>diagnostics_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#diagnostics_config ServiceFabricCluster#diagnostics_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "diagnosticsConfig", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig? DiagnosticsConfig
        {
            get;
            set;
        }

        private object? _fabricSettings;

        /// <summary>fabric_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#fabric_settings ServiceFabricCluster#fabric_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fabricSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterFabricSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FabricSettings
        {
            get => _fabricSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ServiceFabricCluster.IServiceFabricClusterFabricSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterFabricSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fabricSettings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#id ServiceFabricCluster#id}.</summary>
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

        /// <summary>reverse_proxy_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_certificate ServiceFabricCluster#reverse_proxy_certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reverseProxyCertificate", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificate\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate? ReverseProxyCertificate
        {
            get;
            set;
        }

        /// <summary>reverse_proxy_certificate_common_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_certificate_common_names ServiceFabricCluster#reverse_proxy_certificate_common_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reverseProxyCertificateCommonNames", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNames\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNames? ReverseProxyCertificateCommonNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#service_fabric_zonal_upgrade_mode ServiceFabricCluster#service_fabric_zonal_upgrade_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceFabricZonalUpgradeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceFabricZonalUpgradeMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#tags ServiceFabricCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#timeouts ServiceFabricCluster#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterTimeouts\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>upgrade_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#upgrade_policy ServiceFabricCluster#upgrade_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy? UpgradePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#vmss_zonal_upgrade_mode ServiceFabricCluster#vmss_zonal_upgrade_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmssZonalUpgradeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmssZonalUpgradeMode
        {
            get;
            set;
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
