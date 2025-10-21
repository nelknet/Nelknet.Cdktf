using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCeTags.DataAwsCeTagsFilterNotOutputReference), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterNotOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCeTagsFilterNotOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsCeTagsFilterNotOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsCeTagsFilterNotOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeTagsFilterNotOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCostCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotCostCategory\"}}]")]
        public virtual void PutCostCategory(aws.DataAwsCeTags.IDataAwsCeTagsFilterNotCostCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterNotCostCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDimension", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotDimension\"}}]")]
        public virtual void PutDimension(aws.DataAwsCeTags.IDataAwsCeTagsFilterNotDimension @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterNotDimension)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotTags\"}}]")]
        public virtual void PutTags(aws.DataAwsCeTags.IDataAwsCeTagsFilterNotTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterNotTags)}, new object[]{@value});
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

        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotCostCategoryOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterNotCostCategoryOutputReference CostCategory
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterNotCostCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotDimensionOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterNotDimensionOutputReference Dimension
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterNotDimensionOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotTagsOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterNotTagsOutputReference Tags
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterNotTagsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "costCategoryInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotCostCategory\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterNotCostCategory? CostCategoryInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterNotCostCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotDimension\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterNotDimension? DimensionInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterNotDimension?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNotTags\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterNotTags? TagsInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterNotTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNot\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilterNot? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterNot?>();
            set => SetInstanceProperty(value);
        }
    }
}
