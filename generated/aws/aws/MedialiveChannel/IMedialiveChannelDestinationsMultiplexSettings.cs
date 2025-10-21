using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelDestinationsMultiplexSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelDestinationsMultiplexSettings")]
    public interface IMedialiveChannelDestinationsMultiplexSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_id MedialiveChannel#multiplex_id}.</summary>
        [JsiiProperty(name: "multiplexId", typeJson: "{\"primitive\":\"string\"}")]
        string MultiplexId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_name MedialiveChannel#program_name}.</summary>
        [JsiiProperty(name: "programName", typeJson: "{\"primitive\":\"string\"}")]
        string ProgramName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelDestinationsMultiplexSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelDestinationsMultiplexSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelDestinationsMultiplexSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_id MedialiveChannel#multiplex_id}.</summary>
            [JsiiProperty(name: "multiplexId", typeJson: "{\"primitive\":\"string\"}")]
            public string MultiplexId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_name MedialiveChannel#program_name}.</summary>
            [JsiiProperty(name: "programName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProgramName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
