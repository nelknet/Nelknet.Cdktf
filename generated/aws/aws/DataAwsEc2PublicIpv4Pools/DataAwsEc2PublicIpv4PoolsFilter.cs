using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2PublicIpv4Pools
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2PublicIpv4Pools.DataAwsEc2PublicIpv4PoolsFilter")]
    public class DataAwsEc2PublicIpv4PoolsFilter : aws.DataAwsEc2PublicIpv4Pools.IDataAwsEc2PublicIpv4PoolsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pools#name DataAwsEc2PublicIpv4Pools#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_public_ipv4_pools#values DataAwsEc2PublicIpv4Pools#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
