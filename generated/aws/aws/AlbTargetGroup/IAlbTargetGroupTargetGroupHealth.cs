using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiInterface(nativeType: typeof(IAlbTargetGroupTargetGroupHealth), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealth")]
    public interface IAlbTargetGroupTargetGroupHealth
    {
        /// <summary>dns_failover block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#dns_failover AlbTargetGroup#dns_failover}
        /// </remarks>
        [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover? DnsFailover
        {
            get
            {
                return null;
            }
        }

        /// <summary>unhealthy_state_routing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#unhealthy_state_routing AlbTargetGroup#unhealthy_state_routing}
        /// </remarks>
        [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRouting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbTargetGroupTargetGroupHealth), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealth")]
        internal sealed class _Proxy : DeputyBase, aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dns_failover block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#dns_failover AlbTargetGroup#dns_failover}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsFailover", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover\"}", isOptional: true)]
            public aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover? DnsFailover
            {
                get => GetInstanceProperty<aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover?>();
            }

            /// <summary>unhealthy_state_routing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#unhealthy_state_routing AlbTargetGroup#unhealthy_state_routing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unhealthyStateRouting", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
            public aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting? UnhealthyStateRouting
            {
                get => GetInstanceProperty<aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting?>();
            }
        }
    }
}
