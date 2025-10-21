using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraQuerySuggestionsBlockList
{
    [JsiiByValue(fqn: "aws.kendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListTimeouts")]
    public class KendraQuerySuggestionsBlockListTimeouts : aws.KendraQuerySuggestionsBlockList.IKendraQuerySuggestionsBlockListTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#create KendraQuerySuggestionsBlockList#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#delete KendraQuerySuggestionsBlockList#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#update KendraQuerySuggestionsBlockList#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
