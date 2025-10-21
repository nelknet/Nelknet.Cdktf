using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingplansScalingPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilter")]
    public class AutoscalingplansScalingPlanApplicationSourceTagFilter : aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSourceTagFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#key AutoscalingplansScalingPlan#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#values AutoscalingplansScalingPlan#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
