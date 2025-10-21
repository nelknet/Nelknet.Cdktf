using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RoleManagementPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.roleManagementPolicy.RoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications")]
    public class RoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications : azurerm.RoleManagementPolicy.IRoleManagementPolicyNotificationRulesEligibleActivationsApproverNotifications
    {
        private object _defaultRecipients;

        /// <summary>Whether the default recipients are notified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#default_recipients RoleManagementPolicy#default_recipients}
        /// </remarks>
        [JsiiProperty(name: "defaultRecipients", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object DefaultRecipients
        {
            get => _defaultRecipients;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultRecipients = value;
            }
        }

        /// <summary>What level of notifications are sent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#notification_level RoleManagementPolicy#notification_level}
        /// </remarks>
        [JsiiProperty(name: "notificationLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string NotificationLevel
        {
            get;
            set;
        }

        /// <summary>The additional recipients to notify.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/role_management_policy#additional_recipients RoleManagementPolicy#additional_recipients}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdditionalRecipients
        {
            get;
            set;
        }
    }
}
