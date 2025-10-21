using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfig
    {
        /// <summary>output_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#output_config SagemakerEndpointConfiguration#output_config}
        /// </remarks>
        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig\"}")]
        public aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig OutputConfig
        {
            get;
            set;
        }

        /// <summary>client_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#client_config SagemakerEndpointConfiguration#client_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}", isOptional: true)]
        public aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig? ClientConfig
        {
            get;
            set;
        }
    }
}
