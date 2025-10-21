using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelDestinations), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelDestinations")]
    public interface IMedialiveChannelDestinations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#id MedialiveChannel#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>media_package_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_package_settings MedialiveChannel#media_package_settings}
        /// </remarks>
        [JsiiProperty(name: "mediaPackageSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelDestinationsMediaPackageSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MediaPackageSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>multiplex_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_settings MedialiveChannel#multiplex_settings}
        /// </remarks>
        [JsiiProperty(name: "multiplexSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelDestinationsMultiplexSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelDestinationsMultiplexSettings? MultiplexSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#settings MedialiveChannel#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelDestinationsSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Settings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelDestinations), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelDestinations")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelDestinations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#id MedialiveChannel#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>media_package_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#media_package_settings MedialiveChannel#media_package_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mediaPackageSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelDestinationsMediaPackageSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MediaPackageSettings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>multiplex_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#multiplex_settings MedialiveChannel#multiplex_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "multiplexSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelDestinationsMultiplexSettings\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelDestinationsMultiplexSettings? MultiplexSettings
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelDestinationsMultiplexSettings?>();
            }

            /// <summary>settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#settings MedialiveChannel#settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelDestinationsSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Settings
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
