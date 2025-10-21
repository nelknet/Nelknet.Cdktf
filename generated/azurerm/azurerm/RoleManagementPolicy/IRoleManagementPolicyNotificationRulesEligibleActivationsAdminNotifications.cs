using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications")]
    public interface IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications
    {
        /// <summary>Whether the default recipients are notified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#default_recipients RoleManagementPolicy#default_recipients}
        /// </remarks>
        [JsiiProperty(name: "defaultRecipients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object DefaultRecipients
        {
            get;
        }

        /// <summary>What level of notifications are sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#notification_level RoleManagementPolicy#notification_level}
        /// </remarks>
        [JsiiProperty(name: "notificationLevel", typeJson: "{\"primitive\":\"string\"}")]
        string NotificationLevel
        {
            get;
        }

        /// <summary>The additional recipients to notify.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#additional_recipients RoleManagementPolicy#additional_recipients}
        /// </remarks>
        [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalRecipients
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications), fullyQualifiedName: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications")]
        internal sealed class _Proxy : DeputyBase, azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsAdminNotifications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the default recipients are notified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#default_recipients RoleManagementPolicy#default_recipients}
            /// </remarks>
            [JsiiProperty(name: "defaultRecipients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object DefaultRecipients
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>What level of notifications are sent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#notification_level RoleManagementPolicy#notification_level}
            /// </remarks>
            [JsiiProperty(name: "notificationLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string NotificationLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The additional recipients to notify.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#additional_recipients RoleManagementPolicy#additional_recipients}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalRecipients
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
