using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiClass(nativeType: typeof(aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsOutputReference), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination\"}}]")]
        public virtual void PutDestination(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination)}, new object[]{@value});
        }

        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestinationOutputReference\"}")]
        public virtual aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestinationOutputReference Destination
        {
            get => GetInstanceProperty<aws.MedialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination? DestinationInput
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings\"}", isOptional: true)]
        public virtual aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? InternalValue
        {
            get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
