using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterClientCertificateCommonName), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonName")]
    public interface IServiceFabricClusterClientCertificateCommonName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#common_name ServiceFabricCluster#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        string CommonName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_admin ServiceFabricCluster#is_admin}.</summary>
        [JsiiProperty(name: "isAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object IsAdmin
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#issuer_thumbprint ServiceFabricCluster#issuer_thumbprint}.</summary>
        [JsiiProperty(name: "issuerThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IssuerThumbprint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterClientCertificateCommonName), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonName")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#common_name ServiceFabricCluster#common_name}.</summary>
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CommonName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_admin ServiceFabricCluster#is_admin}.</summary>
            [JsiiProperty(name: "isAdmin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object IsAdmin
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#issuer_thumbprint ServiceFabricCluster#issuer_thumbprint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "issuerThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IssuerThumbprint
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
