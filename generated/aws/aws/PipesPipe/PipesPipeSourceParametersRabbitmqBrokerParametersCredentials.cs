using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pipesPipe.PipesPipeSourceParametersRabbitmqBrokerParametersCredentials")]
    public class PipesPipeSourceParametersRabbitmqBrokerParametersCredentials : aws.PipesPipe.IPipesPipeSourceParametersRabbitmqBrokerParametersCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#basic_auth PipesPipe#basic_auth}.</summary>
        [JsiiProperty(name: "basicAuth", typeJson: "{\"primitive\":\"string\"}")]
        public string BasicAuth
        {
            get;
            set;
        }
    }
}
