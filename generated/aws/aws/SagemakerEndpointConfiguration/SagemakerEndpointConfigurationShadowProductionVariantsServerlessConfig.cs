using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig")]
    public class SagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#max_concurrency SagemakerEndpointConfiguration#max_concurrency}.</summary>
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxConcurrency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#memory_size_in_mb SagemakerEndpointConfiguration#memory_size_in_mb}.</summary>
        [JsiiProperty(name: "memorySizeInMb", typeJson: "{\"primitive\":\"number\"}")]
        public double MemorySizeInMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#provisioned_concurrency SagemakerEndpointConfiguration#provisioned_concurrency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedConcurrency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProvisionedConcurrency
        {
            get;
            set;
        }
    }
}
