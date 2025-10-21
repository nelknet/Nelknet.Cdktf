using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage")]
    public class PipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage : aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersOverridesEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#size_in_gib PipesPipe#size_in_gib}.</summary>
        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeInGib
        {
            get;
            set;
        }
    }
}
