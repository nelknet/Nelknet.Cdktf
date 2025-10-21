using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingplansScalingPlan
{
    [JsiiInterface(nativeType: typeof(IAutoscalingplansScalingPlanApplicationSource), fullyQualifiedName: "aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSource")]
    public interface IAutoscalingplansScalingPlanApplicationSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#cloudformation_stack_arn AutoscalingplansScalingPlan#cloudformation_stack_arn}.</summary>
        [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudformationStackArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#tag_filter AutoscalingplansScalingPlan#tag_filter}
        /// </remarks>
        [JsiiProperty(name: "tagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingplansScalingPlanApplicationSource), fullyQualifiedName: "aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSource")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingplansScalingPlan.IAutoscalingplansScalingPlanApplicationSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#cloudformation_stack_arn AutoscalingplansScalingPlan#cloudformation_stack_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudformationStackArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>tag_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscalingplans_scaling_plan#tag_filter AutoscalingplansScalingPlan#tag_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplansScalingPlan.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TagFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
