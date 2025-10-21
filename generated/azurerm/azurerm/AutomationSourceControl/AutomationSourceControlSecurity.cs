using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSourceControl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.automationSourceControl.AutomationSourceControlSecurity")]
    public class AutomationSourceControlSecurity : azurerm.AutomationSourceControl.IAutomationSourceControlSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#token AutomationSourceControl#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#token_type AutomationSourceControl#token_type}.</summary>
        [JsiiProperty(name: "tokenType", typeJson: "{\"primitive\":\"string\"}")]
        public string TokenType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#refresh_token AutomationSourceControl#refresh_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefreshToken
        {
            get;
            set;
        }
    }
}
