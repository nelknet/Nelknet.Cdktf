using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayGlobal), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayGlobal")]
    public interface IApplicationGatewayGlobal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_buffering_enabled ApplicationGateway#request_buffering_enabled}.</summary>
        [JsiiProperty(name: "requestBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object RequestBufferingEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#response_buffering_enabled ApplicationGateway#response_buffering_enabled}.</summary>
        [JsiiProperty(name: "responseBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ResponseBufferingEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayGlobal), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayGlobal")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayGlobal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_buffering_enabled ApplicationGateway#request_buffering_enabled}.</summary>
            [JsiiProperty(name: "requestBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object RequestBufferingEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#response_buffering_enabled ApplicationGateway#response_buffering_enabled}.</summary>
            [JsiiProperty(name: "responseBufferingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ResponseBufferingEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
