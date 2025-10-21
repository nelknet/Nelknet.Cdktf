using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration")]
    public interface IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#header_name ApplicationGateway#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#header_value ApplicationGateway#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#header_name ApplicationGateway#header_name}.</summary>
            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#header_value ApplicationGateway#header_value}.</summary>
            [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
