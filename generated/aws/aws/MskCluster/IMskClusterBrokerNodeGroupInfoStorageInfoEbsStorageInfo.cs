using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo")]
    public interface IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo
    {
        /// <summary>provisioned_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#provisioned_throughput MskCluster#provisioned_throughput}
        /// </remarks>
        [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#volume_size MskCluster#volume_size}.</summary>
        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provisioned_throughput block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#provisioned_throughput MskCluster#provisioned_throughput}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedThroughput", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput? ProvisionedThroughput
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfoEbsStorageInfoProvisionedThroughput?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#volume_size MskCluster#volume_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
