using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorKafkaClusterApacheKafkaCluster), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster")]
    public interface IMskconnectConnectorKafkaClusterApacheKafkaCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#bootstrap_servers MskconnectConnector#bootstrap_servers}.</summary>
        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
        string BootstrapServers
        {
            get;
        }

        /// <summary>vpc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#vpc MskconnectConnector#vpc}
        /// </remarks>
        [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpc\"}")]
        aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc Vpc
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorKafkaClusterApacheKafkaCluster), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaCluster")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#bootstrap_servers MskconnectConnector#bootstrap_servers}.</summary>
            [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
            public string BootstrapServers
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>vpc block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#vpc MskconnectConnector#vpc}
            /// </remarks>
            [JsiiProperty(name: "vpc", typeJson: "{\"fqn\":\"aws.mskconnectConnector.MskconnectConnectorKafkaClusterApacheKafkaClusterVpc\"}")]
            public aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc Vpc
            {
                get => GetInstanceProperty<aws.MskconnectConnector.IMskconnectConnectorKafkaClusterApacheKafkaClusterVpc>()!;
            }
        }
    }
}
