using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElastictranscoderPreset
{
    [JsiiClass(nativeType: typeof(aws.ElastictranscoderPreset.ElastictranscoderPresetAudioOutputReference), fullyQualifiedName: "aws.elastictranscoderPreset.ElastictranscoderPresetAudioOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ElastictranscoderPresetAudioOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ElastictranscoderPresetAudioOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ElastictranscoderPresetAudioOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPresetAudioOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAudioPackingMode")]
        public virtual void ResetAudioPackingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitRate")]
        public virtual void ResetBitRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChannels")]
        public virtual void ResetChannels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodec")]
        public virtual void ResetCodec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSampleRate")]
        public virtual void ResetSampleRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "audioPackingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudioPackingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BitRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChannelsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codecInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CodecInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sampleRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SampleRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "audioPackingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AudioPackingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bitRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BitRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Channels
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "codec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Codec
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sampleRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SampleRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoderPreset.ElastictranscoderPresetAudio\"}", isOptional: true)]
        public virtual aws.ElastictranscoderPreset.IElastictranscoderPresetAudio? InternalValue
        {
            get => GetInstanceProperty<aws.ElastictranscoderPreset.IElastictranscoderPresetAudio?>();
            set => SetInstanceProperty(value);
        }
    }
}
