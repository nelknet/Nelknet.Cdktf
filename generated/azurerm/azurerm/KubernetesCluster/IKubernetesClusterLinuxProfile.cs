using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterLinuxProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfile")]
    public interface IKubernetesClusterLinuxProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#admin_username KubernetesCluster#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        string AdminUsername
        {
            get;
        }

        /// <summary>ssh_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ssh_key KubernetesCluster#ssh_key}
        /// </remarks>
        [JsiiProperty(name: "sshKey", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey\"}")]
        azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey SshKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterLinuxProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterLinuxProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterLinuxProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#admin_username KubernetesCluster#admin_username}.</summary>
            [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminUsername
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ssh_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#ssh_key KubernetesCluster#ssh_key}
            /// </remarks>
            [JsiiProperty(name: "sshKey", typeJson: "{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterLinuxProfileSshKey\"}")]
            public azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey SshKey
            {
                get => GetInstanceProperty<azurerm.KubernetesCluster.IKubernetesClusterLinuxProfileSshKey>()!;
            }
        }
    }
}
