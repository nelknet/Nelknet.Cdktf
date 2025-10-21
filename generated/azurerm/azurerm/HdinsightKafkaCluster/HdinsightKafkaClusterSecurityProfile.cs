using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfile")]
    public class HdinsightKafkaClusterSecurityProfile : azurerm.HdinsightKafkaCluster.IHdinsightKafkaClusterSecurityProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#aadds_resource_id HdinsightKafkaCluster#aadds_resource_id}.</summary>
        [JsiiProperty(name: "aaddsResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string AaddsResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#domain_name HdinsightKafkaCluster#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#domain_username HdinsightKafkaCluster#domain_username}.</summary>
        [JsiiProperty(name: "domainUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#domain_user_password HdinsightKafkaCluster#domain_user_password}.</summary>
        [JsiiProperty(name: "domainUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainUserPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#ldaps_urls HdinsightKafkaCluster#ldaps_urls}.</summary>
        [JsiiProperty(name: "ldapsUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LdapsUrls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#msi_resource_id HdinsightKafkaCluster#msi_resource_id}.</summary>
        [JsiiProperty(name: "msiResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string MsiResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#cluster_users_group_dns HdinsightKafkaCluster#cluster_users_group_dns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusterUsersGroupDns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ClusterUsersGroupDns
        {
            get;
            set;
        }
    }
}
