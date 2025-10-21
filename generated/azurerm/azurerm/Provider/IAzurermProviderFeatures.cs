using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Provider
{
    [JsiiInterface(nativeType: typeof(IAzurermProviderFeatures), fullyQualifiedName: "azurerm.provider.AzurermProviderFeatures")]
    public interface IAzurermProviderFeatures
    {
        /// <summary>api_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#api_management AzurermProvider#api_management}
        /// </remarks>
        [JsiiProperty(name: "apiManagement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApiManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#app_configuration AzurermProvider#app_configuration}
        /// </remarks>
        [JsiiProperty(name: "appConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesAppConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>application_insights block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#application_insights AzurermProvider#application_insights}
        /// </remarks>
        [JsiiProperty(name: "applicationInsights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApplicationInsights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplicationInsights
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognitive_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#cognitive_account AzurermProvider#cognitive_account}
        /// </remarks>
        [JsiiProperty(name: "cognitiveAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesCognitiveAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CognitiveAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>key_vault block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#key_vault AzurermProvider#key_vault}
        /// </remarks>
        [JsiiProperty(name: "keyVault", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesKeyVault\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeyVault
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_analytics_workspace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#log_analytics_workspace AzurermProvider#log_analytics_workspace}
        /// </remarks>
        [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogAnalyticsWorkspace
        {
            get
            {
                return null;
            }
        }

        /// <summary>machine_learning block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#machine_learning AzurermProvider#machine_learning}
        /// </remarks>
        [JsiiProperty(name: "machineLearning", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesMachineLearning\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MachineLearning
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#managed_disk AzurermProvider#managed_disk}
        /// </remarks>
        [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManagedDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgresql_flexible_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#postgresql_flexible_server AzurermProvider#postgresql_flexible_server}
        /// </remarks>
        [JsiiProperty(name: "postgresqlFlexibleServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PostgresqlFlexibleServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>recovery_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recovery_service AzurermProvider#recovery_service}
        /// </remarks>
        [JsiiProperty(name: "recoveryService", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoveryService
        {
            get
            {
                return null;
            }
        }

        /// <summary>recovery_services_vaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recovery_services_vaults AzurermProvider#recovery_services_vaults}
        /// </remarks>
        [JsiiProperty(name: "recoveryServicesVaults", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecoveryServicesVaults
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_group AzurermProvider#resource_group}
        /// </remarks>
        [JsiiProperty(name: "resourceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesResourceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>subscription block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#subscription AzurermProvider#subscription}
        /// </remarks>
        [JsiiProperty(name: "subscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Subscription
        {
            get
            {
                return null;
            }
        }

        /// <summary>template_deployment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#template_deployment AzurermProvider#template_deployment}
        /// </remarks>
        [JsiiProperty(name: "templateDeployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesTemplateDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TemplateDeployment
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_machine block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#virtual_machine AzurermProvider#virtual_machine}
        /// </remarks>
        [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualMachine
        {
            get
            {
                return null;
            }
        }

        /// <summary>virtual_machine_scale_set block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#virtual_machine_scale_set AzurermProvider#virtual_machine_scale_set}
        /// </remarks>
        [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachineScaleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VirtualMachineScaleSet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAzurermProviderFeatures), fullyQualifiedName: "azurerm.provider.AzurermProviderFeatures")]
        internal sealed class _Proxy : DeputyBase, azurerm.Provider.IAzurermProviderFeatures
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#api_management AzurermProvider#api_management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiManagement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApiManagement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiManagement
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>app_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#app_configuration AzurermProvider#app_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesAppConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>application_insights block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#application_insights AzurermProvider#application_insights}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationInsights", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesApplicationInsights\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApplicationInsights
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cognitive_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#cognitive_account AzurermProvider#cognitive_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitiveAccount", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesCognitiveAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CognitiveAccount
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>key_vault block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#key_vault AzurermProvider#key_vault}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVault", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesKeyVault\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KeyVault
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>log_analytics_workspace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#log_analytics_workspace AzurermProvider#log_analytics_workspace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logAnalyticsWorkspace", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesLogAnalyticsWorkspace\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LogAnalyticsWorkspace
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>machine_learning block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#machine_learning AzurermProvider#machine_learning}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "machineLearning", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesMachineLearning\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MachineLearning
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>managed_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#managed_disk AzurermProvider#managed_disk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedDisk", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesManagedDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ManagedDisk
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>postgresql_flexible_server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#postgresql_flexible_server AzurermProvider#postgresql_flexible_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresqlFlexibleServer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesPostgresqlFlexibleServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PostgresqlFlexibleServer
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>recovery_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recovery_service AzurermProvider#recovery_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryService", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryService\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecoveryService
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>recovery_services_vaults block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#recovery_services_vaults AzurermProvider#recovery_services_vaults}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryServicesVaults", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesRecoveryServicesVaults\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecoveryServicesVaults
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#resource_group AzurermProvider#resource_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesResourceGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceGroup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>subscription block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#subscription AzurermProvider#subscription}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subscription", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesSubscription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Subscription
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>template_deployment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#template_deployment AzurermProvider#template_deployment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateDeployment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesTemplateDeployment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TemplateDeployment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>virtual_machine block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#virtual_machine AzurermProvider#virtual_machine}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachine", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualMachine
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>virtual_machine_scale_set block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs#virtual_machine_scale_set AzurermProvider#virtual_machine_scale_set}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "virtualMachineScaleSet", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.provider.AzurermProviderFeaturesVirtualMachineScaleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VirtualMachineScaleSet
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
