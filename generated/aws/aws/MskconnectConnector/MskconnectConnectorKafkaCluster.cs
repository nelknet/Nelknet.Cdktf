using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorKafkaCluster")]
    public class MskconnectConnectorKafkaCluster : aws.MskconnectConnector.IMskconnectConnectorKafkaCluster
    {
        /// <summary>apache_kafka_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#apache_kafka_cluster MskconnectConnector#apache_kafka_cluster}
        /// </remarks>
        [JsiiProperty(name: "apacheKafkaCluster", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster\"}")]
        public aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster ApacheKafkaCluster
        {
            get;
            set;
        }
    }
}
