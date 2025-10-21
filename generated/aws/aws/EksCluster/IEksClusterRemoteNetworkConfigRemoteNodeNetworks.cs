using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterRemoteNetworkConfigRemoteNodeNetworks), fullyQualifiedName: "aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks")]
    public interface IEksClusterRemoteNetworkConfigRemoteNodeNetworks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#cidrs EksCluster#cidrs}.</summary>
        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Cidrs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterRemoteNetworkConfigRemoteNodeNetworks), fullyQualifiedName: "aws.eksCluster.EksClusterRemoteNetworkConfigRemoteNodeNetworks")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterRemoteNetworkConfigRemoteNodeNetworks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#cidrs EksCluster#cidrs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Cidrs
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
