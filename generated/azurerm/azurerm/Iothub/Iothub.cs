using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub azurerm_iothub}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.Iothub.Iothub), fullyQualifiedName: "azurerm.iothub.Iothub", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.iothub.IothubConfig\"}}]")]
    public class Iothub : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub azurerm_iothub} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Iothub(Constructs.Construct scope, string id, azurerm.Iothub.IIothubConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.Iothub.IIothubConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Iothub(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Iothub(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Iothub resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Iothub to import.</param>
        /// <param name="importFromId">The id of the existing Iothub that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Iothub to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Iothub to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Iothub that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Iothub to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.Iothub.Iothub), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCloudToDevice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iothub.IothubCloudToDevice\"}}]")]
        public virtual void PutCloudToDevice(azurerm.Iothub.IIothubCloudToDevice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Iothub.IIothubCloudToDevice)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubEndpoint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEndpoint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.Iothub.IIothubEndpoint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubEndpoint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubEndpoint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnrichment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubEnrichment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnrichment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.Iothub.IIothubEnrichment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubEnrichment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubEnrichment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFallbackRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iothub.IothubFallbackRoute\"}}]")]
        public virtual void PutFallbackRoute(azurerm.Iothub.IIothubFallbackRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Iothub.IIothubFallbackRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileUpload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iothub.IothubFileUpload\"}}]")]
        public virtual void PutFileUpload(azurerm.Iothub.IIothubFileUpload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Iothub.IIothubFileUpload)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iothub.IothubIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.Iothub.IIothubIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Iothub.IIothubIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkRuleSet", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubNetworkRuleSet\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkRuleSet(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.Iothub.IIothubNetworkRuleSet[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubNetworkRuleSet).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubNetworkRuleSet).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubRoute\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoute(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.Iothub.IIothubRoute[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubRoute).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubRoute).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSku", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iothub.IothubSku\"}}]")]
        public virtual void PutSku(azurerm.Iothub.IIothubSku @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Iothub.IIothubSku)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.iothub.IothubTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.Iothub.IIothubTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.Iothub.IIothubTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudToDevice")]
        public virtual void ResetCloudToDevice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpoint")]
        public virtual void ResetEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnrichment")]
        public virtual void ResetEnrichment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventHubPartitionCount")]
        public virtual void ResetEventHubPartitionCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventHubRetentionInDays")]
        public virtual void ResetEventHubRetentionInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFallbackRoute")]
        public virtual void ResetFallbackRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileUpload")]
        public virtual void ResetFileUpload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalAuthenticationEnabled")]
        public virtual void ResetLocalAuthenticationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinTlsVersion")]
        public virtual void ResetMinTlsVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkRuleSet")]
        public virtual void ResetNetworkRuleSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkAccessEnabled")]
        public virtual void ResetPublicNetworkAccessEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute")]
        public virtual void ResetRoute()
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
        = GetStaticProperty<string>(typeof(azurerm.Iothub.Iothub))!;

        [JsiiProperty(name: "cloudToDevice", typeJson: "{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceOutputReference\"}")]
        public virtual azurerm.Iothub.IothubCloudToDeviceOutputReference CloudToDevice
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubCloudToDeviceOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"fqn\":\"azurerm.iothub.IothubEndpointList\"}")]
        public virtual azurerm.Iothub.IothubEndpointList Endpoint
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubEndpointList>()!;
        }

        [JsiiProperty(name: "enrichment", typeJson: "{\"fqn\":\"azurerm.iothub.IothubEnrichmentList\"}")]
        public virtual azurerm.Iothub.IothubEnrichmentList Enrichment
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubEnrichmentList>()!;
        }

        [JsiiProperty(name: "eventHubEventsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventHubEventsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventHubEventsNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventHubEventsNamespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventHubEventsPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventHubEventsPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventHubOperationsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventHubOperationsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventHubOperationsPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventHubOperationsPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fallbackRoute", typeJson: "{\"fqn\":\"azurerm.iothub.IothubFallbackRouteOutputReference\"}")]
        public virtual azurerm.Iothub.IothubFallbackRouteOutputReference FallbackRoute
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubFallbackRouteOutputReference>()!;
        }

        [JsiiProperty(name: "fileUpload", typeJson: "{\"fqn\":\"azurerm.iothub.IothubFileUploadOutputReference\"}")]
        public virtual azurerm.Iothub.IothubFileUploadOutputReference FileUpload
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubFileUploadOutputReference>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.iothub.IothubIdentityOutputReference\"}")]
        public virtual azurerm.Iothub.IothubIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "networkRuleSet", typeJson: "{\"fqn\":\"azurerm.iothub.IothubNetworkRuleSetList\"}")]
        public virtual azurerm.Iothub.IothubNetworkRuleSetList NetworkRuleSet
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubNetworkRuleSetList>()!;
        }

        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.iothub.IothubRouteList\"}")]
        public virtual azurerm.Iothub.IothubRouteList Route
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubRouteList>()!;
        }

        [JsiiProperty(name: "sharedAccessPolicy", typeJson: "{\"fqn\":\"azurerm.iothub.IothubSharedAccessPolicyList\"}")]
        public virtual azurerm.Iothub.IothubSharedAccessPolicyList SharedAccessPolicy
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubSharedAccessPolicyList>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.iothub.IothubSkuOutputReference\"}")]
        public virtual azurerm.Iothub.IothubSkuOutputReference Sku
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubSkuOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.iothub.IothubTimeoutsOutputReference\"}")]
        public virtual azurerm.Iothub.IothubTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudToDeviceInput", typeJson: "{\"fqn\":\"azurerm.iothub.IothubCloudToDevice\"}", isOptional: true)]
        public virtual azurerm.Iothub.IIothubCloudToDevice? CloudToDeviceInput
        {
            get => GetInstanceProperty<azurerm.Iothub.IIothubCloudToDevice?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EndpointInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enrichmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubEnrichment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnrichmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventHubPartitionCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EventHubPartitionCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventHubRetentionInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EventHubRetentionInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fallbackRouteInput", typeJson: "{\"fqn\":\"azurerm.iothub.IothubFallbackRoute\"}", isOptional: true)]
        public virtual azurerm.Iothub.IIothubFallbackRoute? FallbackRouteInput
        {
            get => GetInstanceProperty<azurerm.Iothub.IIothubFallbackRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileUploadInput", typeJson: "{\"fqn\":\"azurerm.iothub.IothubFileUpload\"}", isOptional: true)]
        public virtual azurerm.Iothub.IIothubFileUpload? FileUploadInput
        {
            get => GetInstanceProperty<azurerm.Iothub.IIothubFileUpload?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.iothub.IothubIdentity\"}", isOptional: true)]
        public virtual azurerm.Iothub.IIothubIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.Iothub.IIothubIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localAuthenticationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? LocalAuthenticationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minTlsVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinTlsVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkRuleSetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubNetworkRuleSet\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkRuleSetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkAccessEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicNetworkAccessEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RouteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"fqn\":\"azurerm.iothub.IothubSku\"}", isOptional: true)]
        public virtual azurerm.Iothub.IIothubSku? SkuInput
        {
            get => GetInstanceProperty<azurerm.Iothub.IIothubSku?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.iothub.IothubTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "eventHubPartitionCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EventHubPartitionCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventHubRetentionInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EventHubRetentionInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localAuthenticationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object LocalAuthenticationEnabled
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minTlsVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinTlsVersion
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
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
    }
}
