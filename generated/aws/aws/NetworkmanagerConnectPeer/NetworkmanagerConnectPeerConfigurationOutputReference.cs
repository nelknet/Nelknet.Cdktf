using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerConnectPeer
{
    [JsiiClass(nativeType: typeof(aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerConfigurationOutputReference), fullyQualifiedName: "aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkmanagerConnectPeerConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public NetworkmanagerConnectPeerConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerConnectPeerConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkmanagerConnectPeerConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bgpConfigurations", typeJson: "{\"fqn\":\"aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerConfigurationBgpConfigurationsList\"}")]
        public virtual aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerConfigurationBgpConfigurationsList BgpConfigurations
        {
            get => GetInstanceProperty<aws.NetworkmanagerConnectPeer.NetworkmanagerConnectPeerConfigurationBgpConfigurationsList>()!;
        }

        [JsiiProperty(name: "coreNetworkAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CoreNetworkAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "insideCidrBlocks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InsideCidrBlocks
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "peerAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkmanagerConnectPeer.NetworkmanagerConnectPeerConfiguration\"}", isOptional: true)]
        public virtual aws.NetworkmanagerConnectPeer.INetworkmanagerConnectPeerConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.NetworkmanagerConnectPeer.INetworkmanagerConnectPeerConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
