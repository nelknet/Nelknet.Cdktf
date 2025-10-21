using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerConnectPeer
{
    [JsiiClass(nativeType: typeof(aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptionsOutputReference), fullyQualifiedName: "aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkmanagerConnectPeerBgpOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkmanagerConnectPeerBgpOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkmanagerConnectPeerBgpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerConnectPeerBgpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPeerAsn")]
        public virtual void ResetPeerAsn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerAsnInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PeerAsnInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "peerAsn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerAsn
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerBgpOptions\"}", isOptional: true)]
        public virtual aws.NetworkmanagerConnectPeer.INetworkmanagerConnectPeerBgpOptions? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkmanagerConnectPeer.INetworkmanagerConnectPeerBgpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
