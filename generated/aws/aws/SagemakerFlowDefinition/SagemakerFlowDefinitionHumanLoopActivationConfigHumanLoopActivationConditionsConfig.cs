using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig")]
    public class SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig : aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#human_loop_activation_conditions SagemakerFlowDefinition#human_loop_activation_conditions}.</summary>
        [JsiiProperty(name: "humanLoopActivationConditions", typeJson: "{\"primitive\":\"string\"}")]
        public string HumanLoopActivationConditions
        {
            get;
            set;
        }
    }
}
