using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendServiceFabricClusterServerX509Name), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name")]
    public interface IApiManagementBackendServiceFabricClusterServerX509Name
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#issuer_certificate_thumbprint ApiManagementBackend#issuer_certificate_thumbprint}.</summary>
        [JsiiProperty(name: "issuerCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        string IssuerCertificateThumbprint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#name ApiManagementBackend#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendServiceFabricClusterServerX509Name), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#issuer_certificate_thumbprint ApiManagementBackend#issuer_certificate_thumbprint}.</summary>
            [JsiiProperty(name: "issuerCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
            public string IssuerCertificateThumbprint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management_backend#name ApiManagementBackend#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
