using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAutomation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSetRule")]
    public class SecurityCenterAutomationSourceRuleSetRule : azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSourceRuleSetRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#expected_value SecurityCenterAutomation#expected_value}.</summary>
        [JsiiProperty(name: "expectedValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ExpectedValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#operator SecurityCenterAutomation#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#property_path SecurityCenterAutomation#property_path}.</summary>
        [JsiiProperty(name: "propertyPath", typeJson: "{\"primitive\":\"string\"}")]
        public string PropertyPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#property_type SecurityCenterAutomation#property_type}.</summary>
        [JsiiProperty(name: "propertyType", typeJson: "{\"primitive\":\"string\"}")]
        public string PropertyType
        {
            get;
            set;
        }
    }
}
