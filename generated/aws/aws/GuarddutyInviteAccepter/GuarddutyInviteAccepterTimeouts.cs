using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyInviteAccepter
{
    [JsiiByValue(fqn: "aws.guarddutyInviteAccepter.GuarddutyInviteAccepterTimeouts")]
    public class GuarddutyInviteAccepterTimeouts : aws.GuarddutyInviteAccepter.IGuarddutyInviteAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#create GuarddutyInviteAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
