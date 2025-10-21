using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiInterface(nativeType: typeof(ILbTargetGroupTargetGroupHealthUnhealthyStateRouting), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting")]
    public interface ILbTargetGroupTargetGroupHealthUnhealthyStateRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_count LbTargetGroup#minimum_healthy_targets_count}.</summary>
        [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumHealthyTargetsCount
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

        [JsiiTypeProxy(nativeType: typeof(ILbTargetGroupTargetGroupHealthUnhealthyStateRouting), fullyQualifiedName: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting")]
        internal sealed class _Proxy : DeputyBase, aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_count LbTargetGroup#minimum_healthy_targets_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumHealthyTargetsCount
            {
                get => GetInstanceProperty<double?>();
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
