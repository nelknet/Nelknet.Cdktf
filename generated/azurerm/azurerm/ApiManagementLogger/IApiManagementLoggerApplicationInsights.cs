using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementLogger
{
    [JsiiInterface(nativeType: typeof(IApiManagementLoggerApplicationInsights), fullyQualifiedName: "azurerm.apiManagementLogger.ApiManagementLoggerApplicationInsights")]
    public interface IApiManagementLoggerApplicationInsights
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}.</summary>
        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#instrumentation_key ApiManagementLogger#instrumentation_key}.</summary>
        [JsiiProperty(name: "instrumentationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstrumentationKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementLoggerApplicationInsights), fullyQualifiedName: "azurerm.apiManagementLogger.ApiManagementLoggerApplicationInsights")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementLogger.IApiManagementLoggerApplicationInsights
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#connection_string ApiManagementLogger#connection_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_logger#instrumentation_key ApiManagementLogger#instrumentation_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instrumentationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstrumentationKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
