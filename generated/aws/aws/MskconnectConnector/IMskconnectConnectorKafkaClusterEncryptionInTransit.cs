using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorKafkaClusterEncryptionInTransit), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransit")]
    public interface IMskconnectConnectorKafkaClusterEncryptionInTransit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#encryption_type MskconnectConnector#encryption_type}.</summary>
        [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorKafkaClusterEncryptionInTransit), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorKafkaClusterEncryptionInTransit")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorKafkaClusterEncryptionInTransit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#encryption_type MskconnectConnector#encryption_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
