using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2InstanceTypeOffering
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2InstanceTypeOffering.DataAwsEc2InstanceTypeOfferingFilter")]
    public class DataAwsEc2InstanceTypeOfferingFilter : aws.DataAwsEc2InstanceTypeOffering.IDataAwsEc2InstanceTypeOfferingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#name DataAwsEc2InstanceTypeOffering#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_instance_type_offering#values DataAwsEc2InstanceTypeOffering#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
