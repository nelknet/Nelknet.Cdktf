using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterStorageConfig), fullyQualifiedName: "aws.eksCluster.EksClusterStorageConfig")]
    public interface IEksClusterStorageConfig
    {
        /// <summary>block_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#block_storage EksCluster#block_storage}
        /// </remarks>
        [JsiiProperty(name: "blockStorage", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigBlockStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterStorageConfigBlockStorage? BlockStorage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterStorageConfig), fullyQualifiedName: "aws.eksCluster.EksClusterStorageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterStorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>block_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#block_storage EksCluster#block_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blockStorage", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigBlockStorage\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterStorageConfigBlockStorage? BlockStorage
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterStorageConfigBlockStorage?>();
            }
        }
    }
}
