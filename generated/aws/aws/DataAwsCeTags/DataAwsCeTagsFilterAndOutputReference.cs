using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCeTags.DataAwsCeTagsFilterAndOutputReference), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterAndOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCeTagsFilterAndOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCeTagsFilterAndOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsCeTagsFilterAndOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeTagsFilterAndOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndDimension\"}}]")]
        public virtual void PutDimension(aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndTags\"}}]")]
        public virtual void PutTags(aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndCostCategoryOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterAndCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterAndCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndDimensionOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterAndDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterAndDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndTagsOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterAndTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterAndTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndCostCategory\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndDimension\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndTags\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags? TagsInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAnd\"}]}}", isOptional: true)]
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
                        case aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
