using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling")]
    public interface ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#max_instance_count SagemakerEndpointConfiguration#max_instance_count}.</summary>
        [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#min_instance_count SagemakerEndpointConfiguration#min_instance_count}.</summary>
        [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#status SagemakerEndpointConfiguration#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#max_instance_count SagemakerEndpointConfiguration#max_instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#min_instance_count SagemakerEndpointConfiguration#min_instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#status SagemakerEndpointConfiguration#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
