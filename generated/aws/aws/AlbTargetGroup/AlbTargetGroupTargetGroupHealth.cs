using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiByValue(fqn: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealth")]
    public class AlbTargetGroupTargetGroupHealth : aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealth
    {
        /// <summary>dns_failover block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#dns_failover AlbTargetGroup#dns_failover}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
        public aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover? DnsFailover
        {
            get;
            set;
        }

        /// <summary>unhealthy_state_routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#unhealthy_state_routing AlbTargetGroup#unhealthy_state_routing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        public aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRouting
        {
            get;
            set;
        }
    }
}
