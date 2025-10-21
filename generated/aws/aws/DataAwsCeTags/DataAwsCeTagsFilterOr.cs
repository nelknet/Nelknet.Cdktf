using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiByValue(fqn: "aws.dataAwsCeTags.DataAwsCeTagsFilterOr")]
    public class DataAwsCeTagsFilterOr : aws.DataAwsCeTags.IDataAwsCeTagsFilterOr
    {
        /// <summary>cost_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#cost_category DataAwsCeTags#cost_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "costCategory", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrCostCategory\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterOrCostCategory? CostCategory
        {
            get;
            set;
        }

        /// <summary>dimension block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#dimension DataAwsCeTags#dimension}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dimension", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrDimension\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterOrDimension? Dimension
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tags DataAwsCeTags#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOrTags\"}", isOptional: true)]
        public aws.DataAwsCeTags.IDataAwsCeTagsFilterOrTags? Tags
        {
            get;
            set;
        }
    }
}
