using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo")]
    public class MskClusterBrokerNodeGroupInfoStorageInfo : aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo
    {
        /// <summary>ebs_storage_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#ebs_storage_info MskCluster#ebs_storage_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsStorageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo? EbsStorageInfo
        {
            get;
            set;
        }
    }
}
