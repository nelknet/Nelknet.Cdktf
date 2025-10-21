using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSiteConfigAutoHealSettingTrigger), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger")]
    public interface ILinuxWebAppSiteConfigAutoHealSettingTrigger
    {
        /// <summary>requests block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#requests LinuxWebApp#requests}
        /// </remarks>
        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>slow_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#slow_request LinuxWebApp#slow_request}
        /// </remarks>
        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>slow_request_with_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#slow_request_with_path LinuxWebApp#slow_request_with_path}
        /// </remarks>
        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#status_code LinuxWebApp#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSiteConfigAutoHealSettingTrigger), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>requests block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#requests LinuxWebApp#requests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
            public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests? Requests
            {
                get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests?>();
            }

            /// <summary>slow_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#slow_request LinuxWebApp#slow_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
            public azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
            {
                get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest?>();
            }

            /// <summary>slow_request_with_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#slow_request_with_path LinuxWebApp#slow_request_with_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SlowRequestWithPath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>status_code block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#status_code LinuxWebApp#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatusCode
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
