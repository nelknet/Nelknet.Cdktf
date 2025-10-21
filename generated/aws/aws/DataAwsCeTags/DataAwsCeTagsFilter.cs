using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiByValue(fqn: "aws.dataAwsCeTags.DataAwsCeTagsFilter")]
    public class DataAwsCeTagsFilter : aws.DataAwsCeTags.IDataAwsCeTagsFilter
    {
        private object? _and;

        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#and DataAwsCeTags#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? And
        {
            get => _and;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterAnd).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _and = value;
            }
        }

        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterCostCategory\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#dimension DataAwsCeTags#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterDimension\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#not DataAwsCeTags#not}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "not", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterNot\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterNot? Not
        {
            get;
            set;
        }

        private object? _or;

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#or DataAwsCeTags#or}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Or
        {
            get => _or;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsCeTags.IDataAwsCeTagsFilterOr[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilterOr).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _or = value;
            }
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tags DataAwsCeTags#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterTags\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterTags? Tags
        {
            get;
            set;
        }
    }
}
