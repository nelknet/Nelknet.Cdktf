using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiInterface(nativeType: typeof(IDataAwsCeTagsFilterAnd), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterAnd")]
    public interface IDataAwsCeTagsFilterAnd
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory? CostCategory
        {
            get
            {
                return null;
            }
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#dimension DataAwsCeTags#dimension}
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tags DataAwsCeTags#tags}
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCeTagsFilterAnd), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterAnd")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndCostCategory\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterAndCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#dimension DataAwsCeTags#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndDimension\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension? Dimension
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterAndDimension?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tags DataAwsCeTags#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAndTags\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags? Tags
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterAndTags?>();
            }
        }
    }
}
