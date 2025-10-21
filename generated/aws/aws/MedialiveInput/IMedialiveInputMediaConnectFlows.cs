using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInput
{
    [JsiiInterface(nativeType: typeof(IMedialiveInputMediaConnectFlows), fullyQualifiedName: "aws.medialiveInput.MedialiveInputMediaConnectFlows")]
    public interface IMedialiveInputMediaConnectFlows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#flow_arn MedialiveInput#flow_arn}.</summary>
        [JsiiProperty(name: "flowArn", typeJson: "{\"primitive\":\"string\"}")]
        string FlowArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveInputMediaConnectFlows), fullyQualifiedName: "aws.medialiveInput.MedialiveInputMediaConnectFlows")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveInput.IMedialiveInputMediaConnectFlows
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#flow_arn MedialiveInput#flow_arn}.</summary>
            [JsiiProperty(name: "flowArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FlowArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
