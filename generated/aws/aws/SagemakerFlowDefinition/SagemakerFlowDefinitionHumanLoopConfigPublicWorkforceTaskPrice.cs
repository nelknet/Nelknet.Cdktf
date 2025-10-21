using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    [JsiiByValue(fqn: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice")]
    public class SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice : aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice
    {
        /// <summary>amount_in_usd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#amount_in_usd SagemakerFlowDefinition#amount_in_usd}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountInUsd", typeJson: "{\"fqn\":\"aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd\"}", isOptional: true)]
        public aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd? AmountInUsd
        {
            get;
            set;
        }
    }
}
