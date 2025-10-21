using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster")]
    public class MskconnectConnectorKafkaClusterApacheKafkaCluster : aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#bootstrap_servers MskconnectConnector#bootstrap_servers}.</summary>
        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
        public string BootstrapServers
        {
            get;
            set;
        }

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#vpc MskconnectConnector#vpc}
        /// </remarks>
        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpc\"}")]
        public aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc Vpc
        {
            get;
            set;
        }
    }
}
