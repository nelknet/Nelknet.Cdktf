using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ShieldProactiveEngagement
{
    [JsiiInterface(nativeType: typeof(IShieldProactiveEngagementEmergencyContact), fullyQualifiedName: "aws.shieldProactiveEngagement.ShieldProactiveEngagementEmergencyContact")]
    public interface IShieldProactiveEngagementEmergencyContact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#email_address ShieldProactiveEngagement#email_address}.</summary>
        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        string EmailAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#contact_notes ShieldProactiveEngagement#contact_notes}.</summary>
        [JsiiProperty(name: "contactNotes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContactNotes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#phone_number ShieldProactiveEngagement#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PhoneNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IShieldProactiveEngagementEmergencyContact), fullyQualifiedName: "aws.shieldProactiveEngagement.ShieldProactiveEngagementEmergencyContact")]
        internal sealed class _Proxy : DeputyBase, aws.ShieldProactiveEngagement.IShieldProactiveEngagementEmergencyContact
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#email_address ShieldProactiveEngagement#email_address}.</summary>
            [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string EmailAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#contact_notes ShieldProactiveEngagement#contact_notes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contactNotes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContactNotes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#phone_number ShieldProactiveEngagement#phone_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PhoneNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
