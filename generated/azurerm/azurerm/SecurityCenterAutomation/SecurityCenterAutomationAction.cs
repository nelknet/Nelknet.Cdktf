using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAutomation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.securityCenterAutomation.SecurityCenterAutomationAction")]
    public class SecurityCenterAutomationAction : azurerm.SecurityCenterAutomation.ISecurityCenterAutomationAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#resource_id SecurityCenterAutomation#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#type SecurityCenterAutomation#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#connection_string SecurityCenterAutomation#connection_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#trigger_url SecurityCenterAutomation#trigger_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggerUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TriggerUrl
        {
            get;
            set;
        }
    }
}
