using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfiguration")]
    public class PipesPipeTargetParametersEcsTaskParametersNetworkConfiguration : aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration
    {
        /// <summary>aws_vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#aws_vpc_configuration PipesPipe#aws_vpc_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsVpcConfiguration", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration\"}", isOptional: true)]
        public aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfiguration
        {
            get;
            set;
        }
    }
}
