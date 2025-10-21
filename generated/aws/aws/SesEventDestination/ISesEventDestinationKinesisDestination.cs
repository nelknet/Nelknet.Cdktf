using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesEventDestination
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationKinesisDestination), fullyQualifiedName: "aws.sesEventDestination.SesEventDestinationKinesisDestination")]
    public interface ISesEventDestinationKinesisDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#role_arn SesEventDestination#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#stream_arn SesEventDestination#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        string StreamArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationKinesisDestination), fullyQualifiedName: "aws.sesEventDestination.SesEventDestinationKinesisDestination")]
        internal sealed class _Proxy : DeputyBase, aws.SesEventDestination.ISesEventDestinationKinesisDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#role_arn SesEventDestination#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#stream_arn SesEventDestination#stream_arn}.</summary>
            [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
