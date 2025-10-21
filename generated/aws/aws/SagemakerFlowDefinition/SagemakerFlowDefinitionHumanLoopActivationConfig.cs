using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    [JsiiByValue(fqn: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfig")]
    public class SagemakerFlowDefinitionHumanLoopActivationConfig : aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfig
    {
        /// <summary>human_loop_activation_conditions_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_activation_conditions_config SagemakerFlowDefinition#human_loop_activation_conditions_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "humanLoopActivationConditionsConfig", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig\"}", isOptional: true)]
        public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig? HumanLoopActivationConditionsConfig
        {
            get;
            set;
        }
    }
}
