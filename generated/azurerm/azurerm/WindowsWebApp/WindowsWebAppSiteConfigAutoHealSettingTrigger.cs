using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiByValue(fqn: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTrigger")]
    public class WindowsWebAppSiteConfigAutoHealSettingTrigger : azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#private_memory_kb WindowsWebApp#private_memory_kb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateMemoryKb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PrivateMemoryKb
        {
            get;
            set;
        }

        /// <summary>requests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#requests WindowsWebApp#requests}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests? Requests
        {
            get;
            set;
        }

        /// <summary>slow_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#slow_request WindowsWebApp#slow_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        public azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
        {
            get;
            set;
        }

        private object? _slowRequestWithPath;

        /// <summary>slow_request_with_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#slow_request_with_path WindowsWebApp#slow_request_with_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SlowRequestWithPath
        {
            get => _slowRequestWithPath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slowRequestWithPath = value;
            }
        }

        private object? _statusCode;

        /// <summary>status_code block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#status_code WindowsWebApp#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StatusCode
        {
            get => _statusCode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statusCode = value;
            }
        }
    }
}
