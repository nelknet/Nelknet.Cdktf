using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSettingAction), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingAction")]
    public interface IWindowsWebAppSiteConfigAutoHealSettingAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#action_type WindowsWebApp#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        /// <summary>custom_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#custom_action WindowsWebApp#custom_action}
        /// </remarks>
        [JsiiProperty(name: "customAction", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction? CustomAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#minimum_process_execution_time WindowsWebApp#minimum_process_execution_time}.</summary>
        [JsiiProperty(name: "minimumProcessExecutionTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumProcessExecutionTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSettingAction), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#action_type WindowsWebApp#action_type}.</summary>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#custom_action WindowsWebApp#custom_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customAction", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingActionCustomAction\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction? CustomAction
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingActionCustomAction?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#minimum_process_execution_time WindowsWebApp#minimum_process_execution_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumProcessExecutionTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumProcessExecutionTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
