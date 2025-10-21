using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ContactList
{
    [JsiiInterface(nativeType: typeof(ISesv2ContactListTopic), fullyQualifiedName: "aws.sesv2ContactList.Sesv2ContactListTopic")]
    public interface ISesv2ContactListTopic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#default_subscription_status Sesv2ContactList#default_subscription_status}.</summary>
        [JsiiProperty(name: "defaultSubscriptionStatus", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultSubscriptionStatus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#display_name Sesv2ContactList#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#topic_name Sesv2ContactList#topic_name}.</summary>
        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        string TopicName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#description Sesv2ContactList#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ContactListTopic), fullyQualifiedName: "aws.sesv2ContactList.Sesv2ContactListTopic")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ContactList.ISesv2ContactListTopic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#default_subscription_status Sesv2ContactList#default_subscription_status}.</summary>
            [JsiiProperty(name: "defaultSubscriptionStatus", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultSubscriptionStatus
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#display_name Sesv2ContactList#display_name}.</summary>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#topic_name Sesv2ContactList#topic_name}.</summary>
            [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_contact_list#description Sesv2ContactList#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
