using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpc
{
    [JsiiByValue(fqn: "aws.dataAwsVpc.DataAwsVpcTimeouts")]
    public class DataAwsVpcTimeouts : aws.DataAwsVpc.IDataAwsVpcTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#read DataAwsVpc#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
