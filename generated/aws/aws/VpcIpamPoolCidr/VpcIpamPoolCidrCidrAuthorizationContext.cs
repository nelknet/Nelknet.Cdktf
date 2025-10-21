using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcIpamPoolCidr
{
    [JsiiByValue(fqn: "aws.vpcIpamPoolCidr.VpcIpamPoolCidrCidrAuthorizationContext")]
    public class VpcIpamPoolCidrCidrAuthorizationContext : aws.VpcIpamPoolCidr.IVpcIpamPoolCidrCidrAuthorizationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#message VpcIpamPoolCidr#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_pool_cidr#signature VpcIpamPoolCidr#signature}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Signature
        {
            get;
            set;
        }
    }
}
