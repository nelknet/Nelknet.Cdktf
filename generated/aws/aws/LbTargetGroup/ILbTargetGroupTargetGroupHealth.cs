using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiInterface(nativeType: typeof(ILbTargetGroupTargetGroupHealth), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealth")]
    public interface ILbTargetGroupTargetGroupHealth
    {
        /// <summary>dns_failover block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#dns_failover LbTargetGroup#dns_failover}
        /// </remarks>
        [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover? DnsFailover
        {
            get
            {
                return null;
            }
        }

        /// <summary>unhealthy_state_routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#unhealthy_state_routing LbTargetGroup#unhealthy_state_routing}
        /// </remarks>
        [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRouting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbTargetGroupTargetGroupHealth), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealth")]
        internal sealed class _Proxy : DeputyBase, aws.LbTargetGroup.ILbTargetGroupTargetGroupHealth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dns_failover block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#dns_failover LbTargetGroup#dns_failover}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
            public aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover? DnsFailover
            {
                get => GetInstanceProperty<aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover?>();
            }

            /// <summary>unhealthy_state_routing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#unhealthy_state_routing LbTargetGroup#unhealthy_state_routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
            public aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRouting
            {
                get => GetInstanceProperty<aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting?>();
            }
        }
    }
}
