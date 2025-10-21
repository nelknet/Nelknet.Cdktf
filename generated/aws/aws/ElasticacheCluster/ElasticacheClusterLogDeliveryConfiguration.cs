using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticacheCluster.ElasticacheClusterLogDeliveryConfiguration")]
    public class ElasticacheClusterLogDeliveryConfiguration : aws.ElasticacheCluster.IElasticacheClusterLogDeliveryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#destination ElasticacheCluster#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#destination_type ElasticacheCluster#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_format ElasticacheCluster#log_format}.</summary>
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string LogFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_type ElasticacheCluster#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        public string LogType
        {
            get;
            set;
        }
    }
}
