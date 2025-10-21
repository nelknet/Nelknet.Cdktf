using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ShieldProactiveEngagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.shieldProactiveEngagement.ShieldProactiveEngagementEmergencyContact")]
    public class ShieldProactiveEngagementEmergencyContact : aws.ShieldProactiveEngagement.IShieldProactiveEngagementEmergencyContact
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#email_address ShieldProactiveEngagement#email_address}.</summary>
        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string EmailAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#contact_notes ShieldProactiveEngagement#contact_notes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contactNotes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContactNotes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_proactive_engagement#phone_number ShieldProactiveEngagement#phone_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PhoneNumber
        {
            get;
            set;
        }
    }
}
