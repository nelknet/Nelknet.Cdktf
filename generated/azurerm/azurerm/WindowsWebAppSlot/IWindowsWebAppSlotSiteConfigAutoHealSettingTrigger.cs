using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTrigger")]
    public interface IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#private_memory_kb WindowsWebAppSlot#private_memory_kb}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#requests WindowsWebAppSlot#requests}
        /// </remarks>
        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerRequests? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>slow_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#slow_request WindowsWebAppSlot#slow_request}
        /// </remarks>
        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>slow_request_with_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#slow_request_with_path WindowsWebAppSlot#slow_request_with_path}
        /// </remarks>
        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#status_code WindowsWebAppSlot#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTrigger")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTrigger
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#private_memory_kb WindowsWebAppSlot#private_memory_kb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateMemoryKb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrivateMemoryKb
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>requests block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#requests WindowsWebAppSlot#requests}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerRequests? Requests
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerRequests?>();
            }

            /// <summary>slow_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#slow_request WindowsWebAppSlot#slow_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequest
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequest?>();
            }

            /// <summary>slow_request_with_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#slow_request_with_path WindowsWebAppSlot#slow_request_with_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SlowRequestWithPath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>status_code block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#status_code WindowsWebAppSlot#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StatusCode
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
