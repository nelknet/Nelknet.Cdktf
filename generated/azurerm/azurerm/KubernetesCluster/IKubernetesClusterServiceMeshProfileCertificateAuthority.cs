using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterServiceMeshProfileCertificateAuthority), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfileCertificateAuthority")]
    public interface IKubernetesClusterServiceMeshProfileCertificateAuthority
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cert_chain_object_name KubernetesCluster#cert_chain_object_name}.</summary>
        [JsiiProperty(name: "certChainObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string CertChainObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cert_object_name KubernetesCluster#cert_object_name}.</summary>
        [JsiiProperty(name: "certObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string CertObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_object_name KubernetesCluster#key_object_name}.</summary>
        [JsiiProperty(name: "keyObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string KeyObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_id KubernetesCluster#key_vault_id}.</summary>
        [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#root_cert_object_name KubernetesCluster#root_cert_object_name}.</summary>
        [JsiiProperty(name: "rootCertObjectName", typeJson: "{\"primitive\":\"string\"}")]
        string RootCertObjectName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterServiceMeshProfileCertificateAuthority), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfileCertificateAuthority")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfileCertificateAuthority
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cert_chain_object_name KubernetesCluster#cert_chain_object_name}.</summary>
            [JsiiProperty(name: "certChainObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertChainObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#cert_object_name KubernetesCluster#cert_object_name}.</summary>
            [JsiiProperty(name: "certObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string CertObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_object_name KubernetesCluster#key_object_name}.</summary>
            [JsiiProperty(name: "keyObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#key_vault_id KubernetesCluster#key_vault_id}.</summary>
            [JsiiProperty(name: "keyVaultId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#root_cert_object_name KubernetesCluster#root_cert_object_name}.</summary>
            [JsiiProperty(name: "rootCertObjectName", typeJson: "{\"primitive\":\"string\"}")]
            public string RootCertObjectName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
