using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterRemoteNetworkConfig), fullyQualifiedName: "aws.eksCluster.EksClusterRemoteNetworkConfig")]
    public interface IEksClusterRemoteNetworkConfig
    {
        /// <summary>remote_node_networks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#remote_node_networks EksCluster#remote_node_networks}
        /// </remarks>
        [JsiiProperty(name: "remoteNodeNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks\"}")]
        aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks RemoteNodeNetworks
        {
            get;
        }

        /// <summary>remote_pod_networks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#remote_pod_networks EksCluster#remote_pod_networks}
        /// </remarks>
        [JsiiProperty(name: "remotePodNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworks\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks? RemotePodNetworks
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterRemoteNetworkConfig), fullyQualifiedName: "aws.eksCluster.EksClusterRemoteNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterRemoteNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>remote_node_networks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#remote_node_networks EksCluster#remote_node_networks}
            /// </remarks>
            [JsiiProperty(name: "remoteNodeNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks\"}")]
            public aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks RemoteNodeNetworks
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks>()!;
            }

            /// <summary>remote_pod_networks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#remote_pod_networks EksCluster#remote_pod_networks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remotePodNetworks", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterRemoteNetworkConfigRemotePodNetworks\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks? RemotePodNetworks
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterRemoteNetworkConfigRemotePodNetworks?>();
            }
        }
    }
}
