using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2CoipPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2CoipPool.DataAwsEc2CoipPoolFilter")]
    public class DataAwsEc2CoipPoolFilter : aws.DataAwsEc2CoipPool.IDataAwsEc2CoipPoolFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#name DataAwsEc2CoipPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_coip_pool#values DataAwsEc2CoipPool#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
