using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementProtocols), fullyQualifiedName: "azurerm.apiManagement.ApiManagementProtocols")]
    public interface IApiManagementProtocols
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#enable_http2 ApiManagement#enable_http2}.</summary>
        [JsiiProperty(name: "enableHttp2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableHttp2
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementProtocols), fullyQualifiedName: "azurerm.apiManagement.ApiManagementProtocols")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementProtocols
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#enable_http2 ApiManagement#enable_http2}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableHttp2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableHttp2
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
