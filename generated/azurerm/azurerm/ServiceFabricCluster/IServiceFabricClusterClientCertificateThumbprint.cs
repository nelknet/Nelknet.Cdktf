using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterClientCertificateThumbprint), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateThumbprint")]
    public interface IServiceFabricClusterClientCertificateThumbprint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_admin ServiceFabricCluster#is_admin}.</summary>
        [JsiiProperty(name: "isAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object IsAdmin
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint ServiceFabricCluster#thumbprint}.</summary>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        string Thumbprint
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterClientCertificateThumbprint), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateThumbprint")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateThumbprint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_admin ServiceFabricCluster#is_admin}.</summary>
            [JsiiProperty(name: "isAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object IsAdmin
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#thumbprint ServiceFabricCluster#thumbprint}.</summary>
            [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
            public string Thumbprint
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
