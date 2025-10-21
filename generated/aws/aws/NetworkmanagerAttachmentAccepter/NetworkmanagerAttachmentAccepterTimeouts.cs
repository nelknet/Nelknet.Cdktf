using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerAttachmentAccepter
{
    [JsiiByValue(fqn: "aws.networkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepterTimeouts")]
    public class NetworkmanagerAttachmentAccepterTimeouts : aws.NetworkmanagerAttachmentAccepter.INetworkmanagerAttachmentAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#create NetworkmanagerAttachmentAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
