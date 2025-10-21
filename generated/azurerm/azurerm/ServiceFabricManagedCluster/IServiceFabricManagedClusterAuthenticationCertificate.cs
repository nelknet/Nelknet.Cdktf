using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricManagedCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricManagedClusterAuthenticationCertificate), fullyQualifiedName: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificate")]
    public interface IServiceFabricManagedClusterAuthenticationCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#thumbprint ServiceFabricManagedCluster#thumbprint}.</summary>
        [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        string Thumbprint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#type ServiceFabricManagedCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#common_name ServiceFabricManagedCluster#common_name}.</summary>
        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommonName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricManagedClusterAuthenticationCertificate), fullyQualifiedName: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterAuthenticationCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterAuthenticationCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#thumbprint ServiceFabricManagedCluster#thumbprint}.</summary>
            [JsiiProperty(name: "thumbprint", typeJson: "{\"primitive\":\"string\"}")]
            public string Thumbprint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#type ServiceFabricManagedCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#common_name ServiceFabricManagedCluster#common_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommonName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
