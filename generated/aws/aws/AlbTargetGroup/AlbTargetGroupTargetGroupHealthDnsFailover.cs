using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiByValue(fqn: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealthDnsFailover")]
    public class AlbTargetGroupTargetGroupHealthDnsFailover : aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthDnsFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#minimum_healthy_targets_count AlbTargetGroup#minimum_healthy_targets_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumHealthyTargetsCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#minimum_healthy_targets_percentage AlbTargetGroup#minimum_healthy_targets_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumHealthyTargetsPercentage
        {
            get;
            set;
        }
    }
}
