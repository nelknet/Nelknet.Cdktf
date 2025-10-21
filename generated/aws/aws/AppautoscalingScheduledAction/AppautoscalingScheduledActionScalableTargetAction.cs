using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppautoscalingScheduledAction
{
    [JsiiByValue(fqn: "aws.appautoscalingScheduledAction.AppautoscalingScheduledActionScalableTargetAction")]
    public class AppautoscalingScheduledActionScalableTargetAction : aws.AppautoscalingScheduledAction.IAppautoscalingScheduledActionScalableTargetAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#max_capacity AppautoscalingScheduledAction#max_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#min_capacity AppautoscalingScheduledAction#min_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinCapacity
        {
            get;
            set;
        }
    }
}
