using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterClientAuthentication")]
    public class MskconnectConnectorKafkaClusterClientAuthentication : aws.MskconnectConnector.IMskconnectConnectorKafkaClusterClientAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#authentication_type MskconnectConnector#authentication_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationType
        {
            get;
            set;
        }
    }
}
