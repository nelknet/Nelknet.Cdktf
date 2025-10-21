using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSourceControl
{
    [JsiiInterface(nativeType: typeof(IAutomationSourceControlSecurity), fullyQualifiedName: "azurerm.automationSourceControl.AutomationSourceControlSecurity")]
    public interface IAutomationSourceControlSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#token AutomationSourceControl#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#token_type AutomationSourceControl#token_type}.</summary>
        [JsiiProperty(name: "tokenType", typeJson: "{\"primitive\":\"string\"}")]
        string TokenType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#refresh_token AutomationSourceControl#refresh_token}.</summary>
        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationSourceControlSecurity), fullyQualifiedName: "azurerm.automationSourceControl.AutomationSourceControlSecurity")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationSourceControl.IAutomationSourceControlSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#token AutomationSourceControl#token}.</summary>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#token_type AutomationSourceControl#token_type}.</summary>
            [JsiiProperty(name: "tokenType", typeJson: "{\"primitive\":\"string\"}")]
            public string TokenType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_source_control#refresh_token AutomationSourceControl#refresh_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
