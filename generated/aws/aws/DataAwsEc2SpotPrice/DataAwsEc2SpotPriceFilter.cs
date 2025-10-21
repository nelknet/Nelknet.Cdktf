using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2SpotPrice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2SpotPrice.DataAwsEc2SpotPriceFilter")]
    public class DataAwsEc2SpotPriceFilter : aws.DataAwsEc2SpotPrice.IDataAwsEc2SpotPriceFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#name DataAwsEc2SpotPrice#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#values DataAwsEc2SpotPrice#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
