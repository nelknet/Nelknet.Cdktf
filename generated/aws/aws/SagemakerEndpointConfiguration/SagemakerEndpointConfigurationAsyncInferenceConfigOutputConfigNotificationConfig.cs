using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#error_topic SagemakerEndpointConfiguration#error_topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorTopic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ErrorTopic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#include_inference_response_in SagemakerEndpointConfiguration#include_inference_response_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeInferenceResponseIn", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludeInferenceResponseIn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#success_topic SagemakerEndpointConfiguration#success_topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successTopic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SuccessTopic
        {
            get;
            set;
        }
    }
}
