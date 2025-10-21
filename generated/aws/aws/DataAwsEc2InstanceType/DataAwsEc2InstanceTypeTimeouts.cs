using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceType
{
    [JsiiByValue(fqn: "aws.dataAwsEc2InstanceType.DataAwsEc2InstanceTypeTimeouts")]
    public class DataAwsEc2InstanceTypeTimeouts : aws.DataAwsEc2InstanceType.IDataAwsEc2InstanceTypeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type#read DataAwsEc2InstanceType#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
