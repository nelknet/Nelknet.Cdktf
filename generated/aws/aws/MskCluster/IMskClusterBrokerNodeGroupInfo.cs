using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterBrokerNodeGroupInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfo")]
    public interface IMskClusterBrokerNodeGroupInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_subnets MskCluster#client_subnets}.</summary>
        [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ClientSubnets
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#instance_type MskCluster#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#security_groups MskCluster#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SecurityGroups
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#az_distribution MskCluster#az_distribution}.</summary>
        [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AzDistribution
        {
            get
            {
                return null;
            }
        }

        /// <summary>connectivity_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#connectivity_info MskCluster#connectivity_info}
        /// </remarks>
        [JsiiProperty(name: "connectivityInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>storage_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#storage_info MskCluster#storage_info}
        /// </remarks>
        [JsiiProperty(name: "storageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo? StorageInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterBrokerNodeGroupInfo), fullyQualifiedName: "aws.mskCluster.MskClusterBrokerNodeGroupInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterBrokerNodeGroupInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#client_subnets MskCluster#client_subnets}.</summary>
            [JsiiProperty(name: "clientSubnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ClientSubnets
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#instance_type MskCluster#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#security_groups MskCluster#security_groups}.</summary>
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SecurityGroups
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#az_distribution MskCluster#az_distribution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "azDistribution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AzDistribution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connectivity_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#connectivity_info MskCluster#connectivity_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectivityInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoConnectivityInfo\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo? ConnectivityInfo
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoConnectivityInfo?>();
            }

            /// <summary>storage_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#storage_info MskCluster#storage_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageInfo", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterBrokerNodeGroupInfoStorageInfo\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo? StorageInfo
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterBrokerNodeGroupInfoStorageInfo?>();
            }
        }
    }
}
