using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2Host
{
    [JsiiByValue(fqn: "aws.dataAwsEc2Host.DataAwsEc2HostTimeouts")]
    public class DataAwsEc2HostTimeouts : aws.DataAwsEc2Host.IDataAwsEc2HostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_host#read DataAwsEc2Host#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
