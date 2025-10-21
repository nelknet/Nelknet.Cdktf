using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersCapacityProviderStrategy), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersCapacityProviderStrategy")]
    public interface IPipesPipeTargetParametersEcsTaskParametersCapacityProviderStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#capacity_provider PipesPipe#capacity_provider}.</summary>
        [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityProvider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#base PipesPipe#base}.</summary>
        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Base
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#weight PipesPipe#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersCapacityProviderStrategy), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersCapacityProviderStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersCapacityProviderStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#capacity_provider PipesPipe#capacity_provider}.</summary>
            [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#base PipesPipe#base}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Base
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#weight PipesPipe#weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
