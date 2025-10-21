using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheReplicationGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticacheReplicationGroup.ElasticacheReplicationGroupLogDeliveryConfiguration")]
    public class ElasticacheReplicationGroupLogDeliveryConfiguration : aws.ElasticacheReplicationGroup.IElasticacheReplicationGroupLogDeliveryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#destination ElasticacheReplicationGroup#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#destination_type ElasticacheReplicationGroup#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_format ElasticacheReplicationGroup#log_format}.</summary>
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string LogFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_type ElasticacheReplicationGroup#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        public string LogType
        {
            get;
            set;
        }
    }
}
