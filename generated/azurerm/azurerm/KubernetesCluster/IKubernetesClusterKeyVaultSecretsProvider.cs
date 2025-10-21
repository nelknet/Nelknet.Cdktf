using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterKeyVaultSecretsProvider), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider")]
    public interface IKubernetesClusterKeyVaultSecretsProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#secret_rotation_enabled KubernetesCluster#secret_rotation_enabled}.</summary>
        [JsiiProperty(name: "secretRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecretRotationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#secret_rotation_interval KubernetesCluster#secret_rotation_interval}.</summary>
        [JsiiProperty(name: "secretRotationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretRotationInterval
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterKeyVaultSecretsProvider), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterKeyVaultSecretsProvider")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterKeyVaultSecretsProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#secret_rotation_enabled KubernetesCluster#secret_rotation_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretRotationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SecretRotationEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#secret_rotation_interval KubernetesCluster#secret_rotation_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretRotationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretRotationInterval
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
