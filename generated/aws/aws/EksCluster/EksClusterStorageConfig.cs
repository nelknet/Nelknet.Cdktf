using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiByValue(fqn: "aws.eksCluster.EksClusterStorageConfig")]
    public class EksClusterStorageConfig : aws.EksCluster.IEksClusterStorageConfig
    {
        /// <summary>block_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#block_storage EksCluster#block_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockStorage", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterStorageConfigBlockStorage\"}", isOptional: true)]
        public aws.EksCluster.IEksClusterStorageConfigBlockStorage? BlockStorage
        {
            get;
            set;
        }
    }
}
