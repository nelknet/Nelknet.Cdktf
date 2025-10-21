using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAmiIds
{
    [JsiiByValue(fqn: "aws.dataAwsAmiIds.DataAwsAmiIdsTimeouts")]
    public class DataAwsAmiIdsTimeouts : aws.DataAwsAmiIds.IDataAwsAmiIdsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#read DataAwsAmiIds#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
