using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterEncryptionConfig), fullyQualifiedName: "aws.eksCluster.EksClusterEncryptionConfig")]
    public interface IEksClusterEncryptionConfig
    {
        /// <summary>provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#provider EksCluster#provider}
        /// </remarks>
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfigProvider\"}")]
        aws.EksCluster.IEksClusterEncryptionConfigProvider Provider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#resources EksCluster#resources}.</summary>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterEncryptionConfig), fullyQualifiedName: "aws.eksCluster.EksClusterEncryptionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterEncryptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#provider EksCluster#provider}
            /// </remarks>
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterEncryptionConfigProvider\"}")]
            public aws.EksCluster.IEksClusterEncryptionConfigProvider Provider
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterEncryptionConfigProvider>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#resources EksCluster#resources}.</summary>
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Resources
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
