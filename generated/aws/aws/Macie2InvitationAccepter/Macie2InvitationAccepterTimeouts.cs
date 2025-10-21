using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2InvitationAccepter
{
    [JsiiByValue(fqn: "aws.macie2InvitationAccepter.Macie2InvitationAccepterTimeouts")]
    public class Macie2InvitationAccepterTimeouts : aws.Macie2InvitationAccepter.IMacie2InvitationAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter#create Macie2InvitationAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
