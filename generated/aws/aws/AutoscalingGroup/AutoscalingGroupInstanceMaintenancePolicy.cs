using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupInstanceMaintenancePolicy")]
    public class AutoscalingGroupInstanceMaintenancePolicy : aws.AutoscalingGroup.IAutoscalingGroupInstanceMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_healthy_percentage AutoscalingGroup#max_healthy_percentage}.</summary>
        [JsiiProperty(name: "maxHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxHealthyPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_healthy_percentage AutoscalingGroup#min_healthy_percentage}.</summary>
        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double MinHealthyPercentage
        {
            get;
            set;
        }
    }
}
