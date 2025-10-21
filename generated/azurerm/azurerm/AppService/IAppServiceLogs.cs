using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppService
{
    [JsiiInterface(nativeType: typeof(IAppServiceLogs), fullyQualifiedName: "azurerm.appService.AppServiceLogs")]
    public interface IAppServiceLogs
    {
        /// <summary>application_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#application_logs AppService#application_logs}
        /// </remarks>
        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsApplicationLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppService.IAppServiceLogsApplicationLogs? ApplicationLogs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#detailed_error_messages_enabled AppService#detailed_error_messages_enabled}.</summary>
        [JsiiProperty(name: "detailedErrorMessagesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DetailedErrorMessagesEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#failed_request_tracing_enabled AppService#failed_request_tracing_enabled}.</summary>
        [JsiiProperty(name: "failedRequestTracingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailedRequestTracingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#http_logs AppService#http_logs}
        /// </remarks>
        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsHttpLogs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AppService.IAppServiceLogsHttpLogs? HttpLogs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceLogs), fullyQualifiedName: "azurerm.appService.AppServiceLogs")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppService.IAppServiceLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#application_logs AppService#application_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsApplicationLogs\"}", isOptional: true)]
            public azurerm.AppService.IAppServiceLogsApplicationLogs? ApplicationLogs
            {
                get => GetInstanceProperty<azurerm.AppService.IAppServiceLogsApplicationLogs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#detailed_error_messages_enabled AppService#detailed_error_messages_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "detailedErrorMessagesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DetailedErrorMessagesEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#failed_request_tracing_enabled AppService#failed_request_tracing_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failedRequestTracingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? FailedRequestTracingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service#http_logs AppService#http_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.appService.AppServiceLogsHttpLogs\"}", isOptional: true)]
            public azurerm.AppService.IAppServiceLogsHttpLogs? HttpLogs
            {
                get => GetInstanceProperty<azurerm.AppService.IAppServiceLogsHttpLogs?>();
            }
        }
    }
}
