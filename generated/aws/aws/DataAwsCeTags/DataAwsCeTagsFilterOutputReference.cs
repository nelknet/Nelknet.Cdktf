using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCeTags.DataAwsCeTagsFilterOutputReference), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCeTagsFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsCeTagsFilterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsCeTagsFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeTagsFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAnd\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAnd(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterDimension\"}}]")]
        public virtual void PutDimension(aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNot\"}}]")]
        public virtual void PutNot(aws.DataAwsCeTags.IDataAwsCeTagsFilterNot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterNot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOr", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOr\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOr(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsCeTags.IDataAwsCeTagsFilterOr[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOr).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOr).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterTags\"}}]")]
        public virtual void PutTags(aws.DataAwsCeTags.IDataAwsCeTagsFilterTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCostCategory")]
        public virtual void ResetCostCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDimension")]
        public virtual void ResetDimension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNot")]
        public virtual void ResetNot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOr")]
        public virtual void ResetOr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndList\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterAndList And
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterAndList>()!;
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterCostCategoryOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterDimensionOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterNotOutputReference Not
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterNotOutputReference>()!;
        }

        [JsiiProperty(name: "or", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrList\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterOrList Or
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterOrList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterTagsOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterCostCategory\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterDimension\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNot\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterNot? NotInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterNot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OrInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterTags\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterTags? TagsInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilter\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilter? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
