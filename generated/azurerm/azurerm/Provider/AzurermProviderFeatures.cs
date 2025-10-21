using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiByValue(fqn: "azurerm.provider.AzurermProviderFeatures")]
    public class AzurermProviderFeatures : azurerm.Provider.IAzurermProviderFeatures
    {
        private object? _apiManagement;

        /// <summary>api_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#api_management AzurermProvider#api_management}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiManagement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApiManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApiManagement
        {
            get => _apiManagement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesApiManagement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesApiManagement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _apiManagement = value;
            }
        }

        private object? _appConfiguration;

        /// <summary>app_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#app_configuration AzurermProvider#app_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesAppConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AppConfiguration
        {
            get => _appConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesAppConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesAppConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _appConfiguration = value;
            }
        }

        private object? _applicationInsights;

        /// <summary>application_insights block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#application_insights AzurermProvider#application_insights}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInsights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApplicationInsights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApplicationInsights
        {
            get => _applicationInsights;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesApplicationInsights[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesApplicationInsights).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _applicationInsights = value;
            }
        }

        private object? _cognitiveAccount;

        /// <summary>cognitive_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#cognitive_account AzurermProvider#cognitive_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitiveAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesCognitiveAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CognitiveAccount
        {
            get => _cognitiveAccount;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesCognitiveAccount).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cognitiveAccount = value;
            }
        }

        private object? _keyVault;

        /// <summary>key_vault block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#key_vault AzurermProvider#key_vault}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyVault", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesKeyVault\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KeyVault
        {
            get => _keyVault;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesKeyVault[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesKeyVault).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyVault = value;
            }
        }

        private object? _logAnalyticsWorkspace;

        /// <summary>log_analytics_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#log_analytics_workspace AzurermProvider#log_analytics_workspace}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LogAnalyticsWorkspace
        {
            get => _logAnalyticsWorkspace;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesLogAnalyticsWorkspace).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _logAnalyticsWorkspace = value;
            }
        }

        private object? _machineLearning;

        /// <summary>machine_learning block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#machine_learning AzurermProvider#machine_learning}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "machineLearning", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesMachineLearning\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MachineLearning
        {
            get => _machineLearning;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesMachineLearning[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesMachineLearning).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _machineLearning = value;
            }
        }

        private object? _managedDisk;

        /// <summary>managed_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#managed_disk AzurermProvider#managed_disk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ManagedDisk
        {
            get => _managedDisk;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesManagedDisk[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesManagedDisk).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _managedDisk = value;
            }
        }

        private object? _postgresqlFlexibleServer;

        /// <summary>postgresql_flexible_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#postgresql_flexible_server AzurermProvider#postgresql_flexible_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresqlFlexibleServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PostgresqlFlexibleServer
        {
            get => _postgresqlFlexibleServer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesPostgresqlFlexibleServer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _postgresqlFlexibleServer = value;
            }
        }

        private object? _recoveryService;

        /// <summary>recovery_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recovery_service AzurermProvider#recovery_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryService", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecoveryService
        {
            get => _recoveryService;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesRecoveryService[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesRecoveryService).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recoveryService = value;
            }
        }

        private object? _recoveryServicesVaults;

        /// <summary>recovery_services_vaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recovery_services_vaults AzurermProvider#recovery_services_vaults}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryServicesVaults", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecoveryServicesVaults
        {
            get => _recoveryServicesVaults;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesRecoveryServicesVaults).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recoveryServicesVaults = value;
            }
        }

        private object? _resourceGroup;

        /// <summary>resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_group AzurermProvider#resource_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesResourceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceGroup
        {
            get => _resourceGroup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesResourceGroup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesResourceGroup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceGroup = value;
            }
        }

        private object? _subscription;

        /// <summary>subscription block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#subscription AzurermProvider#subscription}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Subscription
        {
            get => _subscription;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesSubscription[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesSubscription).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subscription = value;
            }
        }

        private object? _templateDeployment;

        /// <summary>template_deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#template_deployment AzurermProvider#template_deployment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateDeployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesTemplateDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TemplateDeployment
        {
            get => _templateDeployment;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesTemplateDeployment).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _templateDeployment = value;
            }
        }

        private object? _virtualMachine;

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#virtual_machine AzurermProvider#virtual_machine}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualMachine
        {
            get => _virtualMachine;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesVirtualMachine[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesVirtualMachine).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualMachine = value;
            }
        }

        private object? _virtualMachineScaleSet;

        /// <summary>virtual_machine_scale_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#virtual_machine_scale_set AzurermProvider#virtual_machine_scale_set}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachineScaleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VirtualMachineScaleSet
        {
            get => _virtualMachineScaleSet;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Provider.IAzurermProviderFeaturesVirtualMachineScaleSet).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _virtualMachineScaleSet = value;
            }
        }
    }
}
