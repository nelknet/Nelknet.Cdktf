using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lb.LbIpamPools")]
    public class LbIpamPools : aws.Lb.ILbIpamPools
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#ipv4_ipam_pool_id Lb#ipv4_ipam_pool_id}.</summary>
        [JsiiProperty(name: "ipv4IpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string Ipv4IpamPoolId
        {
            get;
            set;
        }
    }
}
