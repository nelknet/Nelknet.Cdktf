using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSettingTrigger), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTrigger")]
    public interface IWindowsWebAppSiteConfigAutoHealSettingTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#private_memory_kb WindowsWebApp#private_memory_kb}.</summary>
        [JsiiProperty(name: "privateMemoryKb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrivateMemoryKb
        {
            get
            {
                return null;
            }
        }

        /// <summary>requests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#requests WindowsWebApp#requests}
        /// </remarks>
        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>slow_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#slow_request WindowsWebApp#slow_request}
        /// </remarks>
        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>slow_request_with_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#slow_request_with_path WindowsWebApp#slow_request_with_path}
        /// </remarks>
        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SlowRequestWithPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>status_code block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#status_code WindowsWebApp#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSiteConfigAutoHealSettingTrigger), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTrigger")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#private_memory_kb WindowsWebApp#private_memory_kb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateMemoryKb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrivateMemoryKb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>requests block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#requests WindowsWebApp#requests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests? Requests
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests?>();
            }

            /// <summary>slow_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#slow_request WindowsWebApp#slow_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
            public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
            {
                get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest?>();
            }

            /// <summary>slow_request_with_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#slow_request_with_path WindowsWebApp#slow_request_with_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SlowRequestWithPath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>status_code block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#status_code WindowsWebApp#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatusCode
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
