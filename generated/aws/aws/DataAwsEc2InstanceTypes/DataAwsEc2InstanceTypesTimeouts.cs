using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceTypes
{
    [JsiiByValue(fqn: "aws.dataAwsEc2InstanceTypes.DataAwsEc2InstanceTypesTimeouts")]
    public class DataAwsEc2InstanceTypesTimeouts : aws.DataAwsEc2InstanceTypes.IDataAwsEc2InstanceTypesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_types#read DataAwsEc2InstanceTypes#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
