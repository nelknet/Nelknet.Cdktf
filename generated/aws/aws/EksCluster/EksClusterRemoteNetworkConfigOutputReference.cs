using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiClass(nativeType: typeof(aws.EksCluster.EksClusterRemoteNetworkConfigOutputReference), fullyQualifiedName: "aws.eksCluster.EksClusterRemoteNetworkConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EksClusterRemoteNetworkConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EksClusterRemoteNetworkConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EksClusterRemoteNetworkConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterRemoteNetworkConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRemoteNodeNetworks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks\"}}]")]
        public virtual void PutRemoteNodeNetworks(aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemotePodNetworks", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworks\"}}]")]
        public virtual void PutRemotePodNetworks(aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRemotePodNetworks")]
        public virtual void ResetRemotePodNetworks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "remoteNodeNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworksOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworksOutputReference RemoteNodeNetworks
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworksOutputReference>()!;
        }

        [JsiiProperty(name: "remotePodNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworksOutputReference\"}")]
        public virtual aws.EksCluster.EksClusterRemoteNetworkConfigRemotePodNetworksOutputReference RemotePodNetworks
        {
            get => GetInstanceProperty<aws.EksCluster.EksClusterRemoteNetworkConfigRemotePodNetworksOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteNodeNetworksInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks? RemoteNodeNetworksInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remotePodNetworksInput", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworks\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks? RemotePodNetworksInput
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfig\"}", isOptional: true)]
        public virtual aws.EksCluster.IEksClusterRemoteNetworkConfig? InternalValue
        {
            get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
