using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceTypeOfferings
{
    [JsiiByValue(fqn: "aws.dataAwsEc2InstanceTypeOfferings.DataAwsEc2InstanceTypeOfferingsTimeouts")]
    public class DataAwsEc2InstanceTypeOfferingsTimeouts : aws.DataAwsEc2InstanceTypeOfferings.IDataAwsEc2InstanceTypeOfferingsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offerings#read DataAwsEc2InstanceTypeOfferings#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
