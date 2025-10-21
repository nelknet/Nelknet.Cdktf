using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiInterface(nativeType: typeof(ITransferServerProtocolDetails), fullyQualifiedName: "aws.transferServer.TransferServerProtocolDetails")]
    public interface ITransferServerProtocolDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#as2_transports TransferServer#as2_transports}.</summary>
        [JsiiProperty(name: "as2Transports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? As2Transports
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#passive_ip TransferServer#passive_ip}.</summary>
        [JsiiProperty(name: "passiveIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PassiveIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#set_stat_option TransferServer#set_stat_option}.</summary>
        [JsiiProperty(name: "setStatOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SetStatOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#tls_session_resumption_mode TransferServer#tls_session_resumption_mode}.</summary>
        [JsiiProperty(name: "tlsSessionResumptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TlsSessionResumptionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferServerProtocolDetails), fullyQualifiedName: "aws.transferServer.TransferServerProtocolDetails")]
        internal sealed class _Proxy : DeputyBase, aws.TransferServer.ITransferServerProtocolDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#as2_transports TransferServer#as2_transports}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "as2Transports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? As2Transports
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#passive_ip TransferServer#passive_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passiveIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PassiveIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#set_stat_option TransferServer#set_stat_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "setStatOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SetStatOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#tls_session_resumption_mode TransferServer#tls_session_resumption_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tlsSessionResumptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TlsSessionResumptionMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
