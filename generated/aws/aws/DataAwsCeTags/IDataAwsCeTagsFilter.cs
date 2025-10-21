using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiInterface(nativeType: typeof(IDataAwsCeTagsFilter), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilter")]
    public interface IDataAwsCeTagsFilter
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#and DataAwsCeTags#and}
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? And
        {
            get
            {
                return null;
            }
        }

        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
        /// </remarks>
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterCostCategory\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory? CostCategory
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
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterDimension\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension? Dimension
        {
            get
            {
                return null;
            }
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#not DataAwsCeTags#not}
        /// </remarks>
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterNot? Not
        {
            get
            {
                return null;
            }
        }

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#or DataAwsCeTags#or}
        /// </remarks>
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Or
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
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterTags\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsCeTags.IDataAwsCeTagsFilterTags? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCeTagsFilter), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTagsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCeTags.IDataAwsCeTagsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#and DataAwsCeTags#and}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? And
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>cost_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterCostCategory\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory? CostCategory
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory?>();
            }

            /// <summary>dimension block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#dimension DataAwsCeTags#dimension}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterDimension\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension? Dimension
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension?>();
            }

            /// <summary>not block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#not DataAwsCeTags#not}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNot\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterNot? Not
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterNot?>();
            }

            /// <summary>or block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#or DataAwsCeTags#or}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Or
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tags DataAwsCeTags#tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterTags\"}", isOptional: true)]
            public aws.DataAwsCeTags.IDataAwsCeTagsFilterTags? Tags
            {
                get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilterTags?>();
            }
        }
    }
}
