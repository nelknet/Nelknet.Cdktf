using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiByValue(fqn: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealth")]
    public class LbTargetGroupTargetGroupHealth : aws.LbTargetGroup.ILbTargetGroupTargetGroupHealth
    {
        /// <summary>dns_failover block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#dns_failover LbTargetGroup#dns_failover}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
        public aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover? DnsFailover
        {
            get;
            set;
        }

        /// <summary>unhealthy_state_routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#unhealthy_state_routing LbTargetGroup#unhealthy_state_routing}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        public aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRouting
        {
            get;
            set;
        }
    }
}
