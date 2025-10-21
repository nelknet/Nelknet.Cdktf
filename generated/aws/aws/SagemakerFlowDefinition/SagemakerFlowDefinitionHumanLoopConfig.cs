using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfig")]
    public class SagemakerFlowDefinitionHumanLoopConfig : aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_task_ui_arn SagemakerFlowDefinition#human_task_ui_arn}.</summary>
        [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}")]
        public string HumanTaskUiArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_count SagemakerFlowDefinition#task_count}.</summary>
        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}")]
        public double TaskCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_description SagemakerFlowDefinition#task_description}.</summary>
        [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_title SagemakerFlowDefinition#task_title}.</summary>
        [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskTitle
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#workteam_arn SagemakerFlowDefinition#workteam_arn}.</summary>
        [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkteamArn
        {
            get;
            set;
        }

        /// <summary>public_workforce_task_price block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#public_workforce_task_price SagemakerFlowDefinition#public_workforce_task_price}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice\"}", isOptional: true)]
        public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice? PublicWorkforceTaskPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_availability_lifetime_in_seconds SagemakerFlowDefinition#task_availability_lifetime_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TaskAvailabilityLifetimeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_keywords SagemakerFlowDefinition#task_keywords}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TaskKeywords
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#task_time_limit_in_seconds SagemakerFlowDefinition#task_time_limit_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TaskTimeLimitInSeconds
        {
            get;
            set;
        }
    }
}
