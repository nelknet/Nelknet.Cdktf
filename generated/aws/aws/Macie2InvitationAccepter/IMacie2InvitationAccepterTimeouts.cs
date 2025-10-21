using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2InvitationAccepter
{
    [JsiiInterface(nativeType: typeof(IMacie2InvitationAccepterTimeouts), fullyQualifiedName: "aws.macie2InvitationAccepter.Macie2InvitationAccepterTimeouts")]
    public interface IMacie2InvitationAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter#create Macie2InvitationAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2InvitationAccepterTimeouts), fullyQualifiedName: "aws.macie2InvitationAccepter.Macie2InvitationAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2InvitationAccepter.IMacie2InvitationAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter#create Macie2InvitationAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
