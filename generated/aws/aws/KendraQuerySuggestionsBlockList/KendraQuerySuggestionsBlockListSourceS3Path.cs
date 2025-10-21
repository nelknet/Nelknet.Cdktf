using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraQuerySuggestionsBlockList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListSourceS3Path")]
    public class KendraQuerySuggestionsBlockListSourceS3Path : aws.KendraQuerySuggestionsBlockList.IKendraQuerySuggestionsBlockListSourceS3Path
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#bucket KendraQuerySuggestionsBlockList#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#key KendraQuerySuggestionsBlockList#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
