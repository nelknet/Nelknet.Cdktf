using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination\"}}]")]
        public virtual void PutDestination(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateMode")]
        public virtual void ResetCertificateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionRetryInterval")]
        public virtual void ResetConnectionRetryInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumRetries")]
        public virtual void ResetNumRetries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestinationOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionRetryIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionRetryIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "certificateMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionRetryInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionRetryInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
