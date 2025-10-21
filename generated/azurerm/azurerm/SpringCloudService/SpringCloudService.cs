using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service azurerm_spring_cloud_service}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudService.SpringCloudService), fullyQualifiedName: "azurerm.springCloudService.SpringCloudService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfig\"}}]")]
    public class SpringCloudService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service azurerm_spring_cloud_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SpringCloudService(Constructs.Construct scope, string id, azurerm.SpringCloudService.ISpringCloudServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SpringCloudService.ISpringCloudServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SpringCloudService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SpringCloudService to import.</param>
        /// <param name="importFromId">The id of the existing SpringCloudService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SpringCloudService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SpringCloudService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SpringCloudService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SpringCloudService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SpringCloudService.SpringCloudService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConfigServerGitSetting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSetting\"}}]")]
        public virtual void PutConfigServerGitSetting(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerRegistry", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceContainerRegistry\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutContainerRegistry(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SpringCloudService.ISpringCloudServiceContainerRegistry[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SpringCloudService.ISpringCloudServiceContainerRegistry).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SpringCloudService.ISpringCloudServiceContainerRegistry).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultBuildService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceDefaultBuildService\"}}]")]
        public virtual void PutDefaultBuildService(azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMarketplace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceMarketplace\"}}]")]
        public virtual void PutMarketplace(azurerm.SpringCloudService.ISpringCloudServiceMarketplace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceMarketplace)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceNetwork\"}}]")]
        public virtual void PutNetwork(azurerm.SpringCloudService.ISpringCloudServiceNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SpringCloudService.ISpringCloudServiceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrace", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTrace\"}}]")]
        public virtual void PutTrace(azurerm.SpringCloudService.ISpringCloudServiceTrace @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceTrace)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBuildAgentPoolSize")]
        public virtual void ResetBuildAgentPoolSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigServerGitSetting")]
        public virtual void ResetConfigServerGitSetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerRegistry")]
        public virtual void ResetContainerRegistry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultBuildService")]
        public virtual void ResetDefaultBuildService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogStreamPublicEndpointEnabled")]
        public virtual void ResetLogStreamPublicEndpointEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedEnvironmentId")]
        public virtual void ResetManagedEnvironmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMarketplace")]
        public virtual void ResetMarketplace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRegistryEnabled")]
        public virtual void ResetServiceRegistryEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkuName")]
        public virtual void ResetSkuName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkuTier")]
        public virtual void ResetSkuTier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrace")]
        public virtual void ResetTrace()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneRedundant")]
        public virtual void ResetZoneRedundant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.SpringCloudService.SpringCloudService))!;

        [JsiiProperty(name: "configServerGitSetting", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingOutputReference ConfigServerGitSetting
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingOutputReference>()!;
        }

        [JsiiProperty(name: "containerRegistry", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceContainerRegistryList\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceContainerRegistryList ContainerRegistry
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceContainerRegistryList>()!;
        }

        [JsiiProperty(name: "defaultBuildService", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceDefaultBuildServiceOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceDefaultBuildServiceOutputReference DefaultBuildService
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceDefaultBuildServiceOutputReference>()!;
        }

        [JsiiProperty(name: "marketplace", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceMarketplaceOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceMarketplaceOutputReference Marketplace
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceMarketplaceOutputReference>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceNetworkOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceNetworkOutputReference Network
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "outboundPublicIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutboundPublicIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "requiredNetworkTrafficRules", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceRequiredNetworkTrafficRulesList\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceRequiredNetworkTrafficRulesList RequiredNetworkTrafficRules
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceRequiredNetworkTrafficRulesList>()!;
        }

        [JsiiProperty(name: "serviceRegistryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRegistryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTimeoutsOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "trace", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTraceOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceTraceOutputReference Trace
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceTraceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildAgentPoolSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildAgentPoolSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configServerGitSettingInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSetting\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting? ConfigServerGitSettingInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerRegistryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceContainerRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ContainerRegistryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultBuildServiceInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceDefaultBuildService\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService? DefaultBuildServiceInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceDefaultBuildService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logStreamPublicEndpointEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LogStreamPublicEndpointEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedEnvironmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedEnvironmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "marketplaceInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceMarketplace\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceMarketplace? MarketplaceInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceMarketplace?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceNetwork\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceNetwork? NetworkInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRegistryEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ServiceRegistryEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceTrace\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceTrace? TraceInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceTrace?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneRedundantInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ZoneRedundantInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "buildAgentPoolSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildAgentPoolSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logStreamPublicEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LogStreamPublicEndpointEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "managedEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRegistryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ServiceRegistryEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skuTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneRedundant", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ZoneRedundant
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
