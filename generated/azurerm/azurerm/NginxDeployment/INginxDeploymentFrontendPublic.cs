using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    [JsiiInterface(nativeType: typeof(INginxDeploymentFrontendPublic), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentFrontendPublic")]
    public interface INginxDeploymentFrontendPublic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#ip_address NginxDeployment#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INginxDeploymentFrontendPublic), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentFrontendPublic")]
        internal sealed class _Proxy : DeputyBase, azurerm.NginxDeployment.INginxDeploymentFrontendPublic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#ip_address NginxDeployment#ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpAddress
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
