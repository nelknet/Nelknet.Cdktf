using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings")]
    public interface IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_frames_per_pes MedialiveChannel#audio_frames_per_pes}.</summary>
        [JsiiProperty(name: "audioFramesPerPes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AudioFramesPerPes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_pids MedialiveChannel#audio_pids}.</summary>
        [JsiiProperty(name: "audioPids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AudioPids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ecm_pid MedialiveChannel#ecm_pid}.</summary>
        [JsiiProperty(name: "ecmPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EcmPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_id3_behavior MedialiveChannel#nielsen_id3_behavior}.</summary>
        [JsiiProperty(name: "nielsenId3Behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NielsenId3Behavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pat_interval MedialiveChannel#pat_interval}.</summary>
        [JsiiProperty(name: "patInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PatInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_control MedialiveChannel#pcr_control}.</summary>
        [JsiiProperty(name: "pcrControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PcrControl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_period MedialiveChannel#pcr_period}.</summary>
        [JsiiProperty(name: "pcrPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PcrPeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_pid MedialiveChannel#pcr_pid}.</summary>
        [JsiiProperty(name: "pcrPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PcrPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pmt_interval MedialiveChannel#pmt_interval}.</summary>
        [JsiiProperty(name: "pmtInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PmtInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pmt_pid MedialiveChannel#pmt_pid}.</summary>
        [JsiiProperty(name: "pmtPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PmtPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_num MedialiveChannel#program_num}.</summary>
        [JsiiProperty(name: "programNum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProgramNum
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_behavior MedialiveChannel#scte35_behavior}.</summary>
        [JsiiProperty(name: "scte35Behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scte35Behavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_pid MedialiveChannel#scte35_pid}.</summary>
        [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scte35Pid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_behavior MedialiveChannel#timed_metadata_behavior}.</summary>
        [JsiiProperty(name: "timedMetadataBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimedMetadataBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_pid MedialiveChannel#timed_metadata_pid}.</summary>
        [JsiiProperty(name: "timedMetadataPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimedMetadataPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#transport_stream_id MedialiveChannel#transport_stream_id}.</summary>
        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TransportStreamId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_pid MedialiveChannel#video_pid}.</summary>
        [JsiiProperty(name: "videoPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VideoPid
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_frames_per_pes MedialiveChannel#audio_frames_per_pes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioFramesPerPes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AudioFramesPerPes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#audio_pids MedialiveChannel#audio_pids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "audioPids", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AudioPids
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#ecm_pid MedialiveChannel#ecm_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ecmPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EcmPid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#nielsen_id3_behavior MedialiveChannel#nielsen_id3_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nielsenId3Behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NielsenId3Behavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pat_interval MedialiveChannel#pat_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "patInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PatInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_control MedialiveChannel#pcr_control}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pcrControl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PcrControl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_period MedialiveChannel#pcr_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pcrPeriod", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PcrPeriod
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pcr_pid MedialiveChannel#pcr_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pcrPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PcrPid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pmt_interval MedialiveChannel#pmt_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pmtInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PmtInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#pmt_pid MedialiveChannel#pmt_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pmtPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PmtPid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#program_num MedialiveChannel#program_num}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "programNum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProgramNum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_behavior MedialiveChannel#scte35_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scte35Behavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scte35Behavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#scte35_pid MedialiveChannel#scte35_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scte35Pid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_behavior MedialiveChannel#timed_metadata_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timedMetadataBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimedMetadataBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#timed_metadata_pid MedialiveChannel#timed_metadata_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timedMetadataPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimedMetadataPid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#transport_stream_id MedialiveChannel#transport_stream_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TransportStreamId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#video_pid MedialiveChannel#video_pid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "videoPid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VideoPid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
