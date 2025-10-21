using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    [JsiiInterface(nativeType: typeof(ITransferConnectorSftpConfig), fullyQualifiedName: "aws.transferConnector.TransferConnectorSftpConfig")]
    public interface ITransferConnectorSftpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#trusted_host_keys TransferConnector#trusted_host_keys}.</summary>
        [JsiiProperty(name: "trustedHostKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TrustedHostKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#user_secret_id TransferConnector#user_secret_id}.</summary>
        [JsiiProperty(name: "userSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferConnectorSftpConfig), fullyQualifiedName: "aws.transferConnector.TransferConnectorSftpConfig")]
        internal sealed class _Proxy : DeputyBase, aws.TransferConnector.ITransferConnectorSftpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#trusted_host_keys TransferConnector#trusted_host_keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedHostKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TrustedHostKeys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#user_secret_id TransferConnector#user_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
