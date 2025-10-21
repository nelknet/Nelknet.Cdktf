using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFlowDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerFlowDefinition.SagemakerFlowDefinitionHumanLoopRequestSource")]
    public class SagemakerFlowDefinitionHumanLoopRequestSource : aws.SagemakerFlowDefinition.ISagemakerFlowDefinitionHumanLoopRequestSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_flow_definition#aws_managed_human_loop_request_source SagemakerFlowDefinition#aws_managed_human_loop_request_source}.</summary>
        [JsiiProperty(name: "awsManagedHumanLoopRequestSource", typeJson: "{\"primitive\":\"string\"}")]
        public string AwsManagedHumanLoopRequestSource
        {
            get;
            set;
        }
    }
}
