using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#max_concurrent_invocations_per_instance SagemakerEndpointConfiguration#max_concurrent_invocations_per_instance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentInvocationsPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentInvocationsPerInstance
        {
            get;
            set;
        }
    }
}
