using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts")]
    public interface IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#port_end KubernetesCluster#port_end}.</summary>
        [JsiiProperty(name: "portEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PortEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#port_start KubernetesCluster#port_start}.</summary>
        [JsiiProperty(name: "portStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PortStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#protocol KubernetesCluster#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#port_end KubernetesCluster#port_end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PortEnd
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#port_start KubernetesCluster#port_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "portStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PortStart
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#protocol KubernetesCluster#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
