using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfoStorageInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo")]
    public interface IMskClusterBrokerNodeGroupInfoStorageInfo
    {
        /// <summary>ebs_storage_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#ebs_storage_info MskCluster#ebs_storage_info}
        /// </remarks>
        [JsiiProperty(name: "ebsStorageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfoStorageInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ebs_storage_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#ebs_storage_info MskCluster#ebs_storage_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsStorageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo?>();
            }
        }
    }
}
