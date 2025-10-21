using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCeTags.DataAwsCeTagsFilterOrOutputReference), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterOrOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCeTagsFilterOrOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCeTagsFilterOrOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsCeTagsFilterOrOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeTagsFilterOrOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrDimension\"}}]")]
        public virtual void PutDimension(aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrTags\"}}]")]
        public virtual void PutTags(aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags)}, new object[]{@value});
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

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrCostCategoryOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterOrCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterOrCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrDimensionOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterOrDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterOrDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrTagsOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterOrTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterOrTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrCostCategory\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrDimension\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrTags\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags? TagsInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOr\"}]}}", isOptional: true)]
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
                        case aws.DataAwsCeTags.IDataAwsCeTagsFilterOr cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOr).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
