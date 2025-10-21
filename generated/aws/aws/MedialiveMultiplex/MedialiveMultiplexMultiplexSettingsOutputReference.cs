using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveMultiplex
{
    [JsiiClass(nativeType: typeof(aws.MedialiveMultiplex.MedialiveMultiplexMultiplexSettingsOutputReference), fullyQualifiedName: "aws.medialiveMultiplex.MedialiveMultiplexMultiplexSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveMultiplexMultiplexSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveMultiplexMultiplexSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveMultiplexMultiplexSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveMultiplexMultiplexSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaximumVideoBufferDelayMilliseconds")]
        public virtual void ResetMaximumVideoBufferDelayMilliseconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransportStreamReservedBitrate")]
        public virtual void ResetTransportStreamReservedBitrate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumVideoBufferDelayMillisecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumVideoBufferDelayMillisecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportStreamBitrateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransportStreamBitrateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportStreamIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransportStreamIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transportStreamReservedBitrateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransportStreamReservedBitrateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maximumVideoBufferDelayMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumVideoBufferDelayMilliseconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportStreamBitrate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransportStreamBitrate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportStreamId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransportStreamId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transportStreamReservedBitrate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransportStreamReservedBitrate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveMultiplex.MedialiveMultiplexMultiplexSettings\"}", isOptional: true)]
        public virtual aws.MedialiveMultiplex.IMedialiveMultiplexMultiplexSettings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveMultiplex.IMedialiveMultiplexMultiplexSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
