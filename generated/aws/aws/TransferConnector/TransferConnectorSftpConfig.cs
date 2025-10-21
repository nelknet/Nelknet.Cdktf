using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    [JsiiByValue(fqn: "aws.transferConnector.TransferConnectorSftpConfig")]
    public class TransferConnectorSftpConfig : aws.TransferConnector.ITransferConnectorSftpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#trusted_host_keys TransferConnector#trusted_host_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedHostKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TrustedHostKeys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#user_secret_id TransferConnector#user_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserSecretId
        {
            get;
            set;
        }
    }
}
