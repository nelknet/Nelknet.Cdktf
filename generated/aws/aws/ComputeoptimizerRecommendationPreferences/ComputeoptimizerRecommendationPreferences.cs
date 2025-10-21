using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ComputeoptimizerRecommendationPreferences
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences aws_computeoptimizer_recommendation_preferences}.</summary>
    [JsiiClass(nativeType: typeof(aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences), fullyQualifiedName: "aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesConfig\"}}]")]
    public class ComputeoptimizerRecommendationPreferences : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences aws_computeoptimizer_recommendation_preferences} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ComputeoptimizerRecommendationPreferences(Constructs.Construct scope, string id, aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeoptimizerRecommendationPreferences(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeoptimizerRecommendationPreferences(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ComputeoptimizerRecommendationPreferences resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ComputeoptimizerRecommendationPreferences to import.</param>
        /// <param name="importFromId">The id of the existing ComputeoptimizerRecommendationPreferences that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ComputeoptimizerRecommendationPreferences to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ComputeoptimizerRecommendationPreferences to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_recommendation_preferences#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ComputeoptimizerRecommendationPreferences that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ComputeoptimizerRecommendationPreferences to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExternalMetricsPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreference\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExternalMetricsPreference(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesExternalMetricsPreference[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesExternalMetricsPreference).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesExternalMetricsPreference).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreferredResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPreferredResource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesPreferredResource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesPreferredResource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesPreferredResource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScope", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScope\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScope(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesScope[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesScope).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesScope).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUtilizationPreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreference\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUtilizationPreference(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreference[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreference).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ComputeoptimizerRecommendationPreferences.IComputeoptimizerRecommendationPreferencesUtilizationPreference).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnhancedInfrastructureMetrics")]
        public virtual void ResetEnhancedInfrastructureMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalMetricsPreference")]
        public virtual void ResetExternalMetricsPreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferredWorkloadTypes")]
        public virtual void ResetInferredWorkloadTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLookBackPeriod")]
        public virtual void ResetLookBackPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredResource")]
        public virtual void ResetPreferredResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSavingsEstimationMode")]
        public virtual void ResetSavingsEstimationMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScope")]
        public virtual void ResetScope()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUtilizationPreference")]
        public virtual void ResetUtilizationPreference()
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
        = GetStaticProperty<string>(typeof(aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferences))!;

        [JsiiProperty(name: "externalMetricsPreference", typeJson: "{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceList\"}")]
        public virtual aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceList ExternalMetricsPreference
        {
            get => GetInstanceProperty<aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredResource", typeJson: "{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResourceList\"}")]
        public virtual aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResourceList PreferredResource
        {
            get => GetInstanceProperty<aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResourceList>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScopeList\"}")]
        public virtual aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScopeList Scope
        {
            get => GetInstanceProperty<aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScopeList>()!;
        }

        [JsiiProperty(name: "utilizationPreference", typeJson: "{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceList\"}")]
        public virtual aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceList UtilizationPreference
        {
            get => GetInstanceProperty<aws.ComputeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreferenceList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enhancedInfrastructureMetricsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnhancedInfrastructureMetricsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalMetricsPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesExternalMetricsPreference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExternalMetricsPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferredWorkloadTypesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InferredWorkloadTypesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lookBackPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookBackPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredResourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesPreferredResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PreferredResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "savingsEstimationModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SavingsEstimationModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScopeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "utilizationPreferenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.computeoptimizerRecommendationPreferences.ComputeoptimizerRecommendationPreferencesUtilizationPreference\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UtilizationPreferenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "enhancedInfrastructureMetrics", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnhancedInfrastructureMetrics
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inferredWorkloadTypes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferredWorkloadTypes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lookBackPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookBackPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "savingsEstimationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavingsEstimationMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
