using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfiguration")]
    public interface IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration
    {
        /// <summary>aws_vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#aws_vpc_configuration PipesPipe#aws_vpc_configuration}
        /// </remarks>
        [JsiiProperty(name: "awsVpcConfiguration", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_vpc_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#aws_vpc_configuration PipesPipe#aws_vpc_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsVpcConfiguration", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration\"}", isOptional: true)]
            public aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfiguration
            {
                get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration?>();
            }
        }
    }
}
