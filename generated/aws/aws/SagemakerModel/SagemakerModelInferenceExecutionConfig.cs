using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelInferenceExecutionConfig")]
    public class SagemakerModelInferenceExecutionConfig : aws.SagemakerModel.ISagemakerModelInferenceExecutionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#mode SagemakerModel#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
