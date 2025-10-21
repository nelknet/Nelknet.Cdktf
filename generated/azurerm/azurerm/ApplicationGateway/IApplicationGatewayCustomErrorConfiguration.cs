using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayCustomErrorConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayCustomErrorConfiguration")]
    public interface IApplicationGatewayCustomErrorConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#custom_error_page_url ApplicationGateway#custom_error_page_url}.</summary>
        [JsiiProperty(name: "customErrorPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        string CustomErrorPageUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#status_code ApplicationGateway#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        string StatusCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayCustomErrorConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayCustomErrorConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayCustomErrorConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#custom_error_page_url ApplicationGateway#custom_error_page_url}.</summary>
            [JsiiProperty(name: "customErrorPageUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomErrorPageUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#status_code ApplicationGateway#status_code}.</summary>
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
            public string StatusCode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
