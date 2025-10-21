using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariantsRoutingConfig), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfig")]
    public interface ISagemakerEndpointConfigurationProductionVariantsRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#routing_strategy SagemakerEndpointConfiguration#routing_strategy}.</summary>
        [JsiiProperty(name: "routingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string RoutingStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariantsRoutingConfig), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariantsRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationProductionVariantsRoutingConfig
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
