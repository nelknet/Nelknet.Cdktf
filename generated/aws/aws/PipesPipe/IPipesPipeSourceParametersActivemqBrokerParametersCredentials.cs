using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiInterface(nativeType: typeof(IPipesPipeSourceParametersActivemqBrokerParametersCredentials), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParametersCredentials")]
    public interface IPipesPipeSourceParametersActivemqBrokerParametersCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#basic_auth PipesPipe#basic_auth}.</summary>
        [JsiiProperty(name: "basicAuth", typeJson: "{\"primitive\":\"string\"}")]
        string BasicAuth
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipesPipeSourceParametersActivemqBrokerParametersCredentials), fullyQualifiedName: "aws.pipesPipe.PipesPipeSourceParametersActivemqBrokerParametersCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.PipesPipe.IPipesPipeSourceParametersActivemqBrokerParametersCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pipes_pipe#basic_auth PipesPipe#basic_auth}.</summary>
            [JsiiProperty(name: "basicAuth", typeJson: "{\"primitive\":\"string\"}")]
            public string BasicAuth
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
