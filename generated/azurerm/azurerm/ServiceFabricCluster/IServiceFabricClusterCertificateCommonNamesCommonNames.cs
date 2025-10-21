using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterCertificateCommonNamesCommonNames), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNames")]
    public interface IServiceFabricClusterCertificateCommonNamesCommonNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_common_name ServiceFabricCluster#certificate_common_name}.</summary>
        [JsiiProperty(name: "certificateCommonName", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateCommonName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_issuer_thumbprint ServiceFabricCluster#certificate_issuer_thumbprint}.</summary>
        [JsiiProperty(name: "certificateIssuerThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateIssuerThumbprint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterCertificateCommonNamesCommonNames), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesCommonNames")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNamesCommonNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_common_name ServiceFabricCluster#certificate_common_name}.</summary>
            [JsiiProperty(name: "certificateCommonName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateCommonName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#certificate_issuer_thumbprint ServiceFabricCluster#certificate_issuer_thumbprint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateIssuerThumbprint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateIssuerThumbprint
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
