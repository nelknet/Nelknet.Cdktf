using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig")]
    public class SagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#routing_strategy SagemakerEndpointConfiguration#routing_strategy}.</summary>
        [JsiiProperty(name: "routingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string RoutingStrategy
        {
            get;
            set;
        }
    }
}
