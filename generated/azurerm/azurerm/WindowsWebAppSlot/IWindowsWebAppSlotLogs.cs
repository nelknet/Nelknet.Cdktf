using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppSlotLogs), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogs")]
    public interface IWindowsWebAppSlotLogs
    {
        /// <summary>application_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#application_logs WindowsWebAppSlot#application_logs}
        /// </remarks>
        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs? ApplicationLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#detailed_error_messages WindowsWebAppSlot#detailed_error_messages}.</summary>
        [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DetailedErrorMessages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#failed_request_tracing WindowsWebAppSlot#failed_request_tracing}.</summary>
        [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailedRequestTracing
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#http_logs WindowsWebAppSlot#http_logs}
        /// </remarks>
        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs? HttpLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppSlotLogs), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#application_logs WindowsWebAppSlot#application_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsApplicationLogs\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs? ApplicationLogs
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsApplicationLogs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#detailed_error_messages WindowsWebAppSlot#detailed_error_messages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DetailedErrorMessages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#failed_request_tracing WindowsWebAppSlot#failed_request_tracing}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FailedRequestTracing
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app_slot#http_logs WindowsWebAppSlot#http_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotLogsHttpLogs\"}", isOptional: true)]
            public azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs? HttpLogs
            {
                get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotLogsHttpLogs?>();
            }
        }
    }
}
