using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyInviteAccepter
{
    [JsiiInterface(nativeType: typeof(IGuarddutyInviteAccepterTimeouts), fullyQualifiedName: "aws.guarddutyInviteAccepter.GuarddutyInviteAccepterTimeouts")]
    public interface IGuarddutyInviteAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#create GuarddutyInviteAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyInviteAccepterTimeouts), fullyQualifiedName: "aws.guarddutyInviteAccepter.GuarddutyInviteAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyInviteAccepter.IGuarddutyInviteAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#create GuarddutyInviteAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
