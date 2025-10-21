using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupInstanceRefresh")]
    public class AutoscalingGroupInstanceRefresh : aws.AutoscalingGroup.IAutoscalingGroupInstanceRefresh
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#strategy AutoscalingGroup#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public string Strategy
        {
            get;
            set;
        }

        /// <summary>preferences block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#preferences AutoscalingGroup#preferences}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupInstanceRefreshPreferences? Preferences
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#triggers AutoscalingGroup#triggers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Triggers
        {
            get;
            set;
        }
    }
}
