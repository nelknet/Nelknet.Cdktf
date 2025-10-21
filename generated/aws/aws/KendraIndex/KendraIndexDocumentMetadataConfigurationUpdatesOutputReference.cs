using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiClass(nativeType: typeof(aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesOutputReference), fullyQualifiedName: "aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class KendraIndexDocumentMetadataConfigurationUpdatesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public KendraIndexDocumentMetadataConfigurationUpdatesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndexDocumentMetadataConfigurationUpdatesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndexDocumentMetadataConfigurationUpdatesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRelevance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance\"}}]")]
        public virtual void PutRelevance(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearch\"}}]")]
        public virtual void PutSearch(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRelevance")]
        public virtual void ResetRelevance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearch")]
        public virtual void ResetSearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "relevance", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevanceOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevanceOutputReference Relevance
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevanceOutputReference>()!;
        }

        [JsiiProperty(name: "search", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearchOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearchOutputReference Search
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relevanceInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesRelevance\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance? RelevanceInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesRelevance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesSearch\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch? SearchInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdatesSearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdates\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
