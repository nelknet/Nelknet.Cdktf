using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    [JsiiByValue(fqn: "aws.dataAwsCeTags.DataAwsCeTagsSortBy")]
    public class DataAwsCeTagsSortBy : aws.DataAwsCeTags.IDataAwsCeTagsSortBy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#key DataAwsCeTags#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#sort_order DataAwsCeTags#sort_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortOrder
        {
            get;
            set;
        }
    }
}
