using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8SettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8SettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8SettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8SettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8SettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8SettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAudioFramesPerPes")]
        public virtual void ResetAudioFramesPerPes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudioPids")]
        public virtual void ResetAudioPids()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcmPid")]
        public virtual void ResetEcmPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNielsenId3Behavior")]
        public virtual void ResetNielsenId3Behavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatInterval")]
        public virtual void ResetPatInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPcrControl")]
        public virtual void ResetPcrControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPcrPeriod")]
        public virtual void ResetPcrPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPcrPid")]
        public virtual void ResetPcrPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPmtInterval")]
        public virtual void ResetPmtInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPmtPid")]
        public virtual void ResetPmtPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProgramNum")]
        public virtual void ResetProgramNum()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScte35Behavior")]
        public virtual void ResetScte35Behavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScte35Pid")]
        public virtual void ResetScte35Pid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimedMetadataBehavior")]
        public virtual void ResetTimedMetadataBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimedMetadataPid")]
        public virtual void ResetTimedMetadataPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportStreamId")]
        public virtual void ResetTransportStreamId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVideoPid")]
        public virtual void ResetVideoPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioFramesPerPesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AudioFramesPerPesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioPidsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudioPidsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecmPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EcmPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nielsenId3BehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NielsenId3BehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PatIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pcrControlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PcrControlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pcrPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PcrPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pcrPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PcrPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pmtIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PmtIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pmtPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PmtPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "programNumInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProgramNumInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scte35BehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Scte35BehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scte35PidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Scte35PidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimedMetadataBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timedMetadataPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimedMetadataPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportStreamIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransportStreamIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "videoPidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VideoPidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "audioFramesPerPes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AudioFramesPerPes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audioPids", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AudioPids
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ecmPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcmPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nielsenId3Behavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NielsenId3Behavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "patInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PatInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pcrControl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PcrControl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pcrPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PcrPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pcrPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PcrPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pmtInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PmtInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pmtPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmtPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "programNum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProgramNum
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scte35Behavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scte35Behavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scte35Pid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scte35Pid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timedMetadataBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimedMetadataBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timedMetadataPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimedMetadataPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransportStreamId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "videoPid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VideoPid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3U8Settings?>();
            set => SetInstanceProperty(value);
        }
    }
}
