using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiByValue(fqn: "aws.transferServer.TransferServerProtocolDetails")]
    public class TransferServerProtocolDetails : aws.TransferServer.ITransferServerProtocolDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#as2_transports TransferServer#as2_transports}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "as2Transports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? As2Transports
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#passive_ip TransferServer#passive_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passiveIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PassiveIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#set_stat_option TransferServer#set_stat_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "setStatOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetStatOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#tls_session_resumption_mode TransferServer#tls_session_resumption_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsSessionResumptionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsSessionResumptionMode
        {
            get;
            set;
        }
    }
}
