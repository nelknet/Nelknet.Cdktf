using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsMotionGraphicsConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsMotionGraphicsConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsMotionGraphicsConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsMotionGraphicsConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMotionGraphicsSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings\"}}]")]
        public virtual void PutMotionGraphicsSettings(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMotionGraphicsInsertion")]
        public virtual void ResetMotionGraphicsInsertion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "motionGraphicsSettings", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsOutputReference MotionGraphicsSettings
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "motionGraphicsInsertionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MotionGraphicsInsertionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "motionGraphicsSettingsInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings? MotionGraphicsSettingsInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings?>();
        }

        [JsiiProperty(name: "motionGraphicsInsertion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MotionGraphicsInsertion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsMotionGraphicsConfiguration\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsMotionGraphicsConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
