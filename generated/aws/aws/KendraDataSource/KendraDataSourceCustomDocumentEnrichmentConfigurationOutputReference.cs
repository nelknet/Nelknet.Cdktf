using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiClass(nativeType: typeof(aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationOutputReference), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraDataSourceCustomDocumentEnrichmentConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraDataSourceCustomDocumentEnrichmentConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraDataSourceCustomDocumentEnrichmentConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraDataSourceCustomDocumentEnrichmentConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInlineConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInlineConfigurations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostExtractionHookConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration\"}}]")]
        public virtual void PutPostExtractionHookConfiguration(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreExtractionHookConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration\"}}]")]
        public virtual void PutPreExtractionHookConfiguration(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInlineConfigurations")]
        public virtual void ResetInlineConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostExtractionHookConfiguration")]
        public virtual void ResetPostExtractionHookConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreExtractionHookConfiguration")]
        public virtual void ResetPreExtractionHookConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inlineConfigurations", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsList\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsList InlineConfigurations
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsList>()!;
        }

        [JsiiProperty(name: "postExtractionHookConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationOutputReference PostExtractionHookConfiguration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "preExtractionHookConfiguration", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationOutputReference\"}")]
        public virtual aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationOutputReference PreExtractionHookConfiguration
        {
            get => GetInstanceProperty<aws.KendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inlineConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InlineConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postExtractionHookConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration? PostExtractionHookConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPostExtractionHookConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preExtractionHookConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration? PreExtractionHookConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationPreExtractionHookConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfiguration\"}", isOptional: true)]
        public virtual aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
