using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerLink
{
    [JsiiClass(nativeType: typeof(aws.NetworkmanagerLink.NetworkmanagerLinkBandwidthOutputReference), fullyQualifiedName: "aws.networkmanagerLink.NetworkmanagerLinkBandwidthOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkmanagerLinkBandwidthOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkmanagerLinkBandwidthOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkmanagerLinkBandwidthOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerLinkBandwidthOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDownloadSpeed")]
        public virtual void ResetDownloadSpeed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUploadSpeed")]
        public virtual void ResetUploadSpeed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "downloadSpeedInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DownloadSpeedInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uploadSpeedInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UploadSpeedInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "downloadSpeed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DownloadSpeed
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uploadSpeed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UploadSpeed
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkmanagerLink.NetworkmanagerLinkBandwidth\"}", isOptional: true)]
        public virtual aws.NetworkmanagerLink.INetworkmanagerLinkBandwidth? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkmanagerLink.INetworkmanagerLinkBandwidth?>();
            set => SetInstanceProperty(value);
        }
    }
}
