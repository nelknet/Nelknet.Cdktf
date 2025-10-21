using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiInterface(nativeType: typeof(ILbTargetGroupTargetGroupHealthDnsFailover), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover")]
    public interface ILbTargetGroupTargetGroupHealthDnsFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_count LbTargetGroup#minimum_healthy_targets_count}.</summary>
        [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumHealthyTargetsCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_percentage LbTargetGroup#minimum_healthy_targets_percentage}.</summary>
        [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumHealthyTargetsPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbTargetGroupTargetGroupHealthDnsFailover), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealthDnsFailover")]
        internal sealed class _Proxy : DeputyBase, aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthDnsFailover
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_count LbTargetGroup#minimum_healthy_targets_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumHealthyTargetsCount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_percentage LbTargetGroup#minimum_healthy_targets_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumHealthyTargetsPercentage
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
