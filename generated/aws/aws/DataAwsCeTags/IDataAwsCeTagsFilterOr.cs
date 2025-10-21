using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiInterface(nativeType: typeof(IDataAwsCeTagsFilterOr), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterOr")]
    public interface IDataAwsCeTagsFilterOr
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory? CostCategory
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
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension? Dimension
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCeTagsFilterOr), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilterOr")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCeTags.IDataAwsCeTagsFilterOr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrCostCategory\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#dimension DataAwsCeTags#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrDimension\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension? Dimension
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tags DataAwsCeTags#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrTags\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags? Tags
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags?>();
            }
        }
    }
}
