using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGateway
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway azurerm_spring_cloud_gateway}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudGateway.SpringCloudGateway), fullyQualifiedName: "azurerm.springCloudGateway.SpringCloudGateway", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayConfig\"}}]")]
    public class SpringCloudGateway : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway azurerm_spring_cloud_gateway} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SpringCloudGateway(Constructs.Construct scope, string id, azurerm.SpringCloudGateway.ISpringCloudGatewayConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SpringCloudGateway.ISpringCloudGatewayConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudGateway(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudGateway(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SpringCloudGateway resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SpringCloudGateway to import.</param>
        /// <param name="importFromId">The id of the existing SpringCloudGateway that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SpringCloudGateway to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SpringCloudGateway to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SpringCloudGateway that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SpringCloudGateway to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SpringCloudGateway.SpringCloudGateway), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putApiMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayApiMetadata\"}}]")]
        public virtual void PutApiMetadata(azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientAuthorization", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayClientAuthorization\"}}]")]
        public virtual void PutClientAuthorization(azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCors", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayCors\"}}]")]
        public virtual void PutCors(azurerm.SpringCloudGateway.ISpringCloudGatewayCors @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayCors)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalResponseCachePerInstance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerInstance\"}}]")]
        public virtual void PutLocalResponseCachePerInstance(azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalResponseCachePerRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute\"}}]")]
        public virtual void PutLocalResponseCachePerRoute(azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQuota", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayQuota\"}}]")]
        public virtual void PutQuota(azurerm.SpringCloudGateway.ISpringCloudGatewayQuota @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayQuota)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSso", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewaySso\"}}]")]
        public virtual void PutSso(azurerm.SpringCloudGateway.ISpringCloudGatewaySso @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewaySso)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SpringCloudGateway.ISpringCloudGatewayTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGateway.ISpringCloudGatewayTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiMetadata")]
        public virtual void ResetApiMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationPerformanceMonitoringIds")]
        public virtual void ResetApplicationPerformanceMonitoringIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplicationPerformanceMonitoringTypes")]
        public virtual void ResetApplicationPerformanceMonitoringTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientAuthorization")]
        public virtual void ResetClientAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCors")]
        public virtual void ResetCors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentVariables")]
        public virtual void ResetEnvironmentVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpsOnly")]
        public virtual void ResetHttpsOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalResponseCachePerInstance")]
        public virtual void ResetLocalResponseCachePerInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalResponseCachePerRoute")]
        public virtual void ResetLocalResponseCachePerRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuota")]
        public virtual void ResetQuota()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSensitiveEnvironmentVariables")]
        public virtual void ResetSensitiveEnvironmentVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSso")]
        public virtual void ResetSso()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.SpringCloudGateway.SpringCloudGateway))!;

        [JsiiProperty(name: "apiMetadata", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayApiMetadataOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayApiMetadataOutputReference ApiMetadata
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayApiMetadataOutputReference>()!;
        }

        [JsiiProperty(name: "clientAuthorization", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayClientAuthorizationOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayClientAuthorizationOutputReference ClientAuthorization
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayClientAuthorizationOutputReference>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayCorsOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayCorsOutputReference Cors
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayCorsOutputReference>()!;
        }

        [JsiiProperty(name: "localResponseCachePerInstance", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerInstanceOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayLocalResponseCachePerInstanceOutputReference LocalResponseCachePerInstance
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayLocalResponseCachePerInstanceOutputReference>()!;
        }

        [JsiiProperty(name: "localResponseCachePerRoute", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRouteOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayLocalResponseCachePerRouteOutputReference LocalResponseCachePerRoute
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayLocalResponseCachePerRouteOutputReference>()!;
        }

        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayQuotaOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayQuotaOutputReference Quota
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayQuotaOutputReference>()!;
        }

        [JsiiProperty(name: "sso", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewaySsoOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewaySsoOutputReference Sso
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewaySsoOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayTimeoutsOutputReference\"}")]
        public virtual azurerm.SpringCloudGateway.SpringCloudGatewayTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.SpringCloudGatewayTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiMetadataInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayApiMetadata\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata? ApiMetadataInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayApiMetadata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationPerformanceMonitoringIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApplicationPerformanceMonitoringIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationPerformanceMonitoringTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApplicationPerformanceMonitoringTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAuthorizationInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayClientAuthorization\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization? ClientAuthorizationInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayClientAuthorization?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayCors\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewayCors? CorsInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayCors?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? EnvironmentVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localResponseCachePerInstanceInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerInstance\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance? LocalResponseCachePerInstanceInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerInstance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localResponseCachePerRouteInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute? LocalResponseCachePerRouteInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayLocalResponseCachePerRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayQuota\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewayQuota? QuotaInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewayQuota?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sensitiveEnvironmentVariablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? SensitiveEnvironmentVariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "springCloudServiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpringCloudServiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssoInput", typeJson: "{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewaySso\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGateway.ISpringCloudGatewaySso? SsoInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGateway.ISpringCloudGatewaySso?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.springCloudGateway.SpringCloudGatewayTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "applicationPerformanceMonitoringIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApplicationPerformanceMonitoringIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applicationPerformanceMonitoringTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ApplicationPerformanceMonitoringTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> EnvironmentVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HttpsOnly
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublicNetworkAccessEnabled
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

        [JsiiProperty(name: "sensitiveEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> SensitiveEnvironmentVariables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "springCloudServiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpringCloudServiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
