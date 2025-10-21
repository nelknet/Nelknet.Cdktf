using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFrameCaptureSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings\"}}]")]
        public virtual void PutFrameCaptureSettings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putH264Settings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings\"}}]")]
        public virtual void PutH264Settings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putH265Settings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings\"}}]")]
        public virtual void PutH265Settings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFrameCaptureSettings")]
        public virtual void ResetFrameCaptureSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetH264Settings")]
        public virtual void ResetH264Settings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetH265Settings")]
        public virtual void ResetH265Settings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "frameCaptureSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettingsOutputReference FrameCaptureSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "h264Settings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference H264Settings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsOutputReference>()!;
        }

        [JsiiProperty(name: "h265Settings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsOutputReference H265Settings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "frameCaptureSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings? FrameCaptureSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "h264SettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings? H264SettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH264Settings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "h265SettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings? H265SettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettingsH265Settings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsVideoDescriptionsCodecSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsVideoDescriptionsCodecSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
