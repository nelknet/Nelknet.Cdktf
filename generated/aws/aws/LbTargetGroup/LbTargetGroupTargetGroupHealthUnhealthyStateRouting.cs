using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    [JsiiByValue(fqn: "aws.lbTargetGroup.LbTargetGroupTargetGroupHealthUnhealthyStateRouting")]
    public class LbTargetGroupTargetGroupHealthUnhealthyStateRouting : aws.LbTargetGroup.ILbTargetGroupTargetGroupHealthUnhealthyStateRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_count LbTargetGroup#minimum_healthy_targets_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumHealthyTargetsCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#minimum_healthy_targets_percentage LbTargetGroup#minimum_healthy_targets_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumHealthyTargetsPercentage
        {
            get;
            set;
        }
    }
}
