using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAutomation
{
    [JsiiInterface(nativeType: typeof(ISecurityCenterAutomationSourceRuleSetRule), fullyQualifiedName: "azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSetRule")]
    public interface ISecurityCenterAutomationSourceRuleSetRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#expected_value SecurityCenterAutomation#expected_value}.</summary>
        [JsiiProperty(name: "expectedValue", typeJson: "{\"primitive\":\"string\"}")]
        string ExpectedValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#operator SecurityCenterAutomation#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#property_path SecurityCenterAutomation#property_path}.</summary>
        [JsiiProperty(name: "propertyPath", typeJson: "{\"primitive\":\"string\"}")]
        string PropertyPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#property_type SecurityCenterAutomation#property_type}.</summary>
        [JsiiProperty(name: "propertyType", typeJson: "{\"primitive\":\"string\"}")]
        string PropertyType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityCenterAutomationSourceRuleSetRule), fullyQualifiedName: "azurerm.securityCenterAutomation.SecurityCenterAutomationSourceRuleSetRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.SecurityCenterAutomation.ISecurityCenterAutomationSourceRuleSetRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#expected_value SecurityCenterAutomation#expected_value}.</summary>
            [JsiiProperty(name: "expectedValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ExpectedValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#operator SecurityCenterAutomation#operator}.</summary>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#property_path SecurityCenterAutomation#property_path}.</summary>
            [JsiiProperty(name: "propertyPath", typeJson: "{\"primitive\":\"string\"}")]
            public string PropertyPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_automation#property_type SecurityCenterAutomation#property_type}.</summary>
            [JsiiProperty(name: "propertyType", typeJson: "{\"primitive\":\"string\"}")]
            public string PropertyType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
