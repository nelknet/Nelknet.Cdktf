using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerConnectAttachment
{
    [JsiiByValue(fqn: "aws.networkmanagerConnectAttachment.NetworkmanagerConnectAttachmentOptions")]
    public class NetworkmanagerConnectAttachmentOptions : aws.NetworkmanagerConnectAttachment.INetworkmanagerConnectAttachmentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_connect_attachment#protocol NetworkmanagerConnectAttachment#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }
    }
}
