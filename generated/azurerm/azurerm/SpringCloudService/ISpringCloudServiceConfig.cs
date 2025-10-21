using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiInterface(nativeType: typeof(ISpringCloudServiceConfig), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfig")]
    public interface ISpringCloudServiceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#location SpringCloudService#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#name SpringCloudService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#resource_group_name SpringCloudService#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#build_agent_pool_size SpringCloudService#build_agent_pool_size}.</summary>
        [JsiiProperty(name: "buildAgentPoolSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuildAgentPoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>config_server_git_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#config_server_git_setting SpringCloudService#config_server_git_setting}
        /// </remarks>
        [JsiiProperty(name: "configServerGitSetting", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSetting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting? ConfigServerGitSetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_registry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#container_registry SpringCloudService#container_registry}
        /// </remarks>
        [JsiiProperty(name: "containerRegistry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceContainerRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ContainerRegistry
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_build_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#default_build_service SpringCloudService#default_build_service}
        /// </remarks>
        [JsiiProperty(name: "defaultBuildService", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceDefaultBuildService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService? DefaultBuildService
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#id SpringCloudService#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#log_stream_public_endpoint_enabled SpringCloudService#log_stream_public_endpoint_enabled}.</summary>
        [JsiiProperty(name: "logStreamPublicEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogStreamPublicEndpointEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#managed_environment_id SpringCloudService#managed_environment_id}.</summary>
        [JsiiProperty(name: "managedEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedEnvironmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>marketplace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#marketplace SpringCloudService#marketplace}
        /// </remarks>
        [JsiiProperty(name: "marketplace", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceMarketplace\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceMarketplace? Marketplace
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#network SpringCloudService#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_registry_enabled SpringCloudService#service_registry_enabled}.</summary>
        [JsiiProperty(name: "serviceRegistryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServiceRegistryEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sku_name SpringCloudService#sku_name}.</summary>
        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkuName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sku_tier SpringCloudService#sku_tier}.</summary>
        [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkuTier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#tags SpringCloudService#tags}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#timeouts SpringCloudService#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>trace block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#trace SpringCloudService#trace}
        /// </remarks>
        [JsiiProperty(name: "trace", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTrace\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SpringCloudService.ISpringCloudServiceTrace? Trace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#zone_redundant SpringCloudService#zone_redundant}.</summary>
        [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ZoneRedundant
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudServiceConfig), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudService.ISpringCloudServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#location SpringCloudService#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#name SpringCloudService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#resource_group_name SpringCloudService#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#build_agent_pool_size SpringCloudService#build_agent_pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "buildAgentPoolSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuildAgentPoolSize
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>config_server_git_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#config_server_git_setting SpringCloudService#config_server_git_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configServerGitSetting", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSetting\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting? ConfigServerGitSetting
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting?>();
            }

            /// <summary>container_registry block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#container_registry SpringCloudService#container_registry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerRegistry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceContainerRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ContainerRegistry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_build_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#default_build_service SpringCloudService#default_build_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultBuildService", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceDefaultBuildService\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService? DefaultBuildService
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#id SpringCloudService#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#log_stream_public_endpoint_enabled SpringCloudService#log_stream_public_endpoint_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logStreamPublicEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LogStreamPublicEndpointEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#managed_environment_id SpringCloudService#managed_environment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedEnvironmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedEnvironmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>marketplace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#marketplace SpringCloudService#marketplace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "marketplace", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceMarketplace\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceMarketplace? Marketplace
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceMarketplace?>();
            }

            /// <summary>network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#network SpringCloudService#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceNetwork\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceNetwork? Network
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceNetwork?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_registry_enabled SpringCloudService#service_registry_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRegistryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ServiceRegistryEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sku_name SpringCloudService#sku_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkuName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sku_tier SpringCloudService#sku_tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkuTier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#tags SpringCloudService#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#timeouts SpringCloudService#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTimeouts\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceTimeouts?>();
            }

            /// <summary>trace block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#trace SpringCloudService#trace}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trace", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTrace\"}", isOptional: true)]
            public azurerm.SpringCloudService.ISpringCloudServiceTrace? Trace
            {
                get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceTrace?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#zone_redundant SpringCloudService#zone_redundant}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ZoneRedundant
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
