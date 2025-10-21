using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig")]
    public interface ISagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#routing_strategy SagemakerEndpointConfiguration#routing_strategy}.</summary>
        [JsiiProperty(name: "routingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string RoutingStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#routing_strategy SagemakerEndpointConfiguration#routing_strategy}.</summary>
            [JsiiProperty(name: "routingStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string RoutingStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
