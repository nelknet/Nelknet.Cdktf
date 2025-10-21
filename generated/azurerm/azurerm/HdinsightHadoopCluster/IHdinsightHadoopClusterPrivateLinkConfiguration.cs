using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightHadoopClusterPrivateLinkConfiguration), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfiguration")]
    public interface IHdinsightHadoopClusterPrivateLinkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#group_id HdinsightHadoopCluster#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
        string GroupId
        {
            get;
        }

        /// <summary>ip_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#ip_configuration HdinsightHadoopCluster#ip_configuration}
        /// </remarks>
        [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfigurationIpConfiguration\"}")]
        azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfigurationIpConfiguration IpConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#name HdinsightHadoopCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightHadoopClusterPrivateLinkConfiguration), fullyQualifiedName: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#group_id HdinsightHadoopCluster#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ip_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#ip_configuration HdinsightHadoopCluster#ip_configuration}
            /// </remarks>
            [JsiiProperty(name: "ipConfiguration", typeJson: "{\"fqn\":\"azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfigurationIpConfiguration\"}")]
            public azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfigurationIpConfiguration IpConfiguration
            {
                get => GetInstanceProperty<azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterPrivateLinkConfigurationIpConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#name HdinsightHadoopCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
