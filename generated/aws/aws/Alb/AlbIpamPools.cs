using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Alb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.alb.AlbIpamPools")]
    public class AlbIpamPools : aws.Alb.IAlbIpamPools
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#ipv4_ipam_pool_id Alb#ipv4_ipam_pool_id}.</summary>
        [JsiiProperty(name: "ipv4IpamPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string Ipv4IpamPoolId
        {
            get;
            set;
        }
    }
}
