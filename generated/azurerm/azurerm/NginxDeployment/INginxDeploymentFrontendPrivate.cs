using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    [JsiiInterface(nativeType: typeof(INginxDeploymentFrontendPrivate), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentFrontendPrivate")]
    public interface INginxDeploymentFrontendPrivate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#allocation_method NginxDeployment#allocation_method}.</summary>
        [JsiiProperty(name: "allocationMethod", typeJson: "{\"primitive\":\"string\"}")]
        string AllocationMethod
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#ip_address NginxDeployment#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#subnet_id NginxDeployment#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INginxDeploymentFrontendPrivate), fullyQualifiedName: "azurerm.nginxDeployment.NginxDeploymentFrontendPrivate")]
        internal sealed class _Proxy : DeputyBase, azurerm.NginxDeployment.INginxDeploymentFrontendPrivate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#allocation_method NginxDeployment#allocation_method}.</summary>
            [JsiiProperty(name: "allocationMethod", typeJson: "{\"primitive\":\"string\"}")]
            public string AllocationMethod
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#ip_address NginxDeployment#ip_address}.</summary>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#subnet_id NginxDeployment#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
