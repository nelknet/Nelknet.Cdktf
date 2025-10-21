using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiByValue(fqn: "aws.sagemakerModel.SagemakerModelContainerMultiModelConfig")]
    public class SagemakerModelContainerMultiModelConfig : aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#model_cache_setting SagemakerModel#model_cache_setting}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelCacheSetting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelCacheSetting
        {
            get;
            set;
        }
    }
}
