using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcIpamPool
{
    [JsiiByValue(fqn: "aws.dataAwsVpcIpamPool.DataAwsVpcIpamPoolTimeouts")]
    public class DataAwsVpcIpamPoolTimeouts : aws.DataAwsVpcIpamPool.IDataAwsVpcIpamPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam_pool#read DataAwsVpcIpamPool#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
