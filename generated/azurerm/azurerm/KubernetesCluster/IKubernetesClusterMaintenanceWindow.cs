using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterMaintenanceWindow), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow")]
    public interface IKubernetesClusterMaintenanceWindow
    {
        /// <summary>allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#allowed KubernetesCluster#allowed}
        /// </remarks>
        [JsiiProperty(name: "allowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Allowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>not_allowed block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#not_allowed KubernetesCluster#not_allowed}
        /// </remarks>
        [JsiiProperty(name: "notAllowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NotAllowed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterMaintenanceWindow), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allowed block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#allowed KubernetesCluster#allowed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Allowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>not_allowed block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#not_allowed KubernetesCluster#not_allowed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notAllowed", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterMaintenanceWindowNotAllowed\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NotAllowed
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
