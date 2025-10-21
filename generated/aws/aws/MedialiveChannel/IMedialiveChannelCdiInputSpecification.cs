using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelCdiInputSpecification), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelCdiInputSpecification")]
    public interface IMedialiveChannelCdiInputSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#resolution MedialiveChannel#resolution}.</summary>
        [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}")]
        string Resolution
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelCdiInputSpecification), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelCdiInputSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelCdiInputSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#resolution MedialiveChannel#resolution}.</summary>
            [JsiiProperty(name: "resolution", typeJson: "{\"primitive\":\"string\"}")]
            public string Resolution
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
