using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterServiceMeshProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile")]
    public interface IKubernetesClusterServiceMeshProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#mode KubernetesCluster#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#revisions KubernetesCluster#revisions}.</summary>
        [JsiiProperty(name: "revisions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Revisions
        {
            get;
        }

        /// <summary>certificate_authority block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#certificate_authority KubernetesCluster#certificate_authority}
        /// </remarks>
        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfileCertificateAuthority\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfileCertificateAuthority? CertificateAuthority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#external_ingress_gateway_enabled KubernetesCluster#external_ingress_gateway_enabled}.</summary>
        [JsiiProperty(name: "externalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalIngressGatewayEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#internal_ingress_gateway_enabled KubernetesCluster#internal_ingress_gateway_enabled}.</summary>
        [JsiiProperty(name: "internalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InternalIngressGatewayEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterServiceMeshProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#mode KubernetesCluster#mode}.</summary>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#revisions KubernetesCluster#revisions}.</summary>
            [JsiiProperty(name: "revisions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Revisions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>certificate_authority block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#certificate_authority KubernetesCluster#certificate_authority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterServiceMeshProfileCertificateAuthority\"}", isOptional: true)]
            public azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfileCertificateAuthority? CertificateAuthority
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterServiceMeshProfileCertificateAuthority?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#external_ingress_gateway_enabled KubernetesCluster#external_ingress_gateway_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExternalIngressGatewayEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#internal_ingress_gateway_enabled KubernetesCluster#internal_ingress_gateway_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InternalIngressGatewayEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
