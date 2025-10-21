using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling")]
    public class SagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsManagedInstanceScaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#max_instance_count SagemakerEndpointConfiguration#max_instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#min_instance_count SagemakerEndpointConfiguration#min_instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#status SagemakerEndpointConfiguration#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
