using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransit")]
    public class MskconnectConnectorKafkaClusterEncryptionInTransit : aws.MskconnectConnector.IMskconnectConnectorKafkaClusterEncryptionInTransit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#encryption_type MskconnectConnector#encryption_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionType
        {
            get;
            set;
        }
    }
}
