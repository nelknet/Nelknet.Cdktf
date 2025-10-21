using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayRedirectConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRedirectConfiguration")]
    public interface IApplicationGatewayRedirectConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#redirect_type ApplicationGateway#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#include_path ApplicationGateway#include_path}.</summary>
        [JsiiProperty(name: "includePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#include_query_string ApplicationGateway#include_query_string}.</summary>
        [JsiiProperty(name: "includeQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeQueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#target_listener_name ApplicationGateway#target_listener_name}.</summary>
        [JsiiProperty(name: "targetListenerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetListenerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#target_url ApplicationGateway#target_url}.</summary>
        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayRedirectConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRedirectConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayRedirectConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#redirect_type ApplicationGateway#redirect_type}.</summary>
            [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#include_path ApplicationGateway#include_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includePath", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludePath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#include_query_string ApplicationGateway#include_query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeQueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#target_listener_name ApplicationGateway#target_listener_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetListenerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetListenerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#target_url ApplicationGateway#target_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
