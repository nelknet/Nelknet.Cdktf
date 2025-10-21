using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerAttachmentAccepter
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerAttachmentAccepterTimeouts), fullyQualifiedName: "aws.networkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepterTimeouts")]
    public interface INetworkmanagerAttachmentAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#create NetworkmanagerAttachmentAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerAttachmentAccepterTimeouts), fullyQualifiedName: "aws.networkmanagerAttachmentAccepter.NetworkmanagerAttachmentAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerAttachmentAccepter.INetworkmanagerAttachmentAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_attachment_accepter#create NetworkmanagerAttachmentAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
