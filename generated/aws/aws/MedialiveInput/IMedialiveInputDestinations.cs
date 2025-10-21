using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInput
{
    [JsiiInterface(nativeType: typeof(IMedialiveInputDestinations), fullyQualifiedName: "aws.medialiveInput.MedialiveInputDestinations")]
    public interface IMedialiveInputDestinations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#stream_name MedialiveInput#stream_name}.</summary>
        [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
        string StreamName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveInputDestinations), fullyQualifiedName: "aws.medialiveInput.MedialiveInputDestinations")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveInput.IMedialiveInputDestinations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#stream_name MedialiveInput#stream_name}.</summary>
            [JsiiProperty(name: "streamName", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
