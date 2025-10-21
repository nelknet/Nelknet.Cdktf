using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity")]
    public interface IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
    {
        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_authentication MskCluster#client_authentication}
        /// </remarks>
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_authentication MskCluster#client_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication? ClientAuthentication
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfoVpcConnectivityClientAuthentication?>();
            }
        }
    }
}
