using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Provider
{
    [JsiiByValue(fqn: "aws.provider.AwsProviderDefaultTags")]
    public class AwsProviderDefaultTags : aws.Provider.IAwsProviderDefaultTags
    {
        /// <summary>Resource tags to default across all resources. Can also be configured with environment variables like `TF_AWS_DEFAULT_TAGS_&lt;tag_name&gt;`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs#tags AwsProvider#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
