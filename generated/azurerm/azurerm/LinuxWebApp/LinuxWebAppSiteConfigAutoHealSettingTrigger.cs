using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiByValue(fqn: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger")]
    public class LinuxWebAppSiteConfigAutoHealSettingTrigger : azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger
    {
        /// <summary>requests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#requests LinuxWebApp#requests}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests? Requests
        {
            get;
            set;
        }

        /// <summary>slow_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#slow_request LinuxWebApp#slow_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
        {
            get;
            set;
        }

        private object? _slowRequestWithPath;

        /// <summary>slow_request_with_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#slow_request_with_path LinuxWebApp#slow_request_with_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _slowRequestWithPath = value;
            }
        }

        private object? _statusCode;

        /// <summary>status_code block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#status_code LinuxWebApp#status_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _statusCode = value;
            }
        }
    }
}
