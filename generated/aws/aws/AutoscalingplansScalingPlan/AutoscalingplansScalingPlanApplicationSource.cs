using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingplansScalingPlan
{
    [JsiiByValue(fqn: "aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSource")]
    public class AutoscalingplansScalingPlanApplicationSource : aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#cloudformation_stack_arn AutoscalingplansScalingPlan#cloudformation_stack_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudformationStackArn
        {
            get;
            set;
        }

        private object? _tagFilter;

        /// <summary>tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#tag_filter AutoscalingplansScalingPlan#tag_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TagFilter
        {
            get => _tagFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSourceTagFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSourceTagFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tagFilter = value;
            }
        }
    }
}
