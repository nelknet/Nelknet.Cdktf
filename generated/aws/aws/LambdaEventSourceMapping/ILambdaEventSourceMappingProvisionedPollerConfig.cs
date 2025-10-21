using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingProvisionedPollerConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfig")]
    public interface ILambdaEventSourceMappingProvisionedPollerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_pollers LambdaEventSourceMapping#maximum_pollers}.</summary>
        [JsiiProperty(name: "maximumPollers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumPollers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#minimum_pollers LambdaEventSourceMapping#minimum_pollers}.</summary>
        [JsiiProperty(name: "minimumPollers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumPollers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingProvisionedPollerConfig), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaEventSourceMapping.ILambdaEventSourceMappingProvisionedPollerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#maximum_pollers LambdaEventSourceMapping#maximum_pollers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumPollers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumPollers
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_event_source_mapping#minimum_pollers LambdaEventSourceMapping#minimum_pollers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumPollers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumPollers
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
