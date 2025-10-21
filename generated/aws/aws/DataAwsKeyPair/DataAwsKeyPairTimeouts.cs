using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsKeyPair
{
    [JsiiByValue(fqn: "aws.dataAwsKeyPair.DataAwsKeyPairTimeouts")]
    public class DataAwsKeyPairTimeouts : aws.DataAwsKeyPair.IDataAwsKeyPairTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/key_pair#read DataAwsKeyPair#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
