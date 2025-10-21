using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo")]
    public class MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo : aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo
    {
        /// <summary>provisioned_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#provisioned_throughput MskCluster#provisioned_throughput}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#volume_size MskCluster#volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VolumeSize
        {
            get;
            set;
        }
    }
}
