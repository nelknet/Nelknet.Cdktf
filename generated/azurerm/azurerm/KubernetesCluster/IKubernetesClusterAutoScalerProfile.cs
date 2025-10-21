using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterAutoScalerProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile")]
    public interface IKubernetesClusterAutoScalerProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#balance_similar_node_groups KubernetesCluster#balance_similar_node_groups}.</summary>
        [JsiiProperty(name: "balanceSimilarNodeGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? BalanceSimilarNodeGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#empty_bulk_delete_max KubernetesCluster#empty_bulk_delete_max}.</summary>
        [JsiiProperty(name: "emptyBulkDeleteMax", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmptyBulkDeleteMax
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#expander KubernetesCluster#expander}.</summary>
        [JsiiProperty(name: "expander", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expander
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_graceful_termination_sec KubernetesCluster#max_graceful_termination_sec}.</summary>
        [JsiiProperty(name: "maxGracefulTerminationSec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxGracefulTerminationSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_node_provisioning_time KubernetesCluster#max_node_provisioning_time}.</summary>
        [JsiiProperty(name: "maxNodeProvisioningTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxNodeProvisioningTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_unready_nodes KubernetesCluster#max_unready_nodes}.</summary>
        [JsiiProperty(name: "maxUnreadyNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnreadyNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_unready_percentage KubernetesCluster#max_unready_percentage}.</summary>
        [JsiiProperty(name: "maxUnreadyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnreadyPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#new_pod_scale_up_delay KubernetesCluster#new_pod_scale_up_delay}.</summary>
        [JsiiProperty(name: "newPodScaleUpDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NewPodScaleUpDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_add KubernetesCluster#scale_down_delay_after_add}.</summary>
        [JsiiProperty(name: "scaleDownDelayAfterAdd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownDelayAfterAdd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_delete KubernetesCluster#scale_down_delay_after_delete}.</summary>
        [JsiiProperty(name: "scaleDownDelayAfterDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownDelayAfterDelete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_failure KubernetesCluster#scale_down_delay_after_failure}.</summary>
        [JsiiProperty(name: "scaleDownDelayAfterFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownDelayAfterFailure
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_unneeded KubernetesCluster#scale_down_unneeded}.</summary>
        [JsiiProperty(name: "scaleDownUnneeded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownUnneeded
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_unready KubernetesCluster#scale_down_unready}.</summary>
        [JsiiProperty(name: "scaleDownUnready", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownUnready
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_utilization_threshold KubernetesCluster#scale_down_utilization_threshold}.</summary>
        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScaleDownUtilizationThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scan_interval KubernetesCluster#scan_interval}.</summary>
        [JsiiProperty(name: "scanInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScanInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#skip_nodes_with_local_storage KubernetesCluster#skip_nodes_with_local_storage}.</summary>
        [JsiiProperty(name: "skipNodesWithLocalStorage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipNodesWithLocalStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#skip_nodes_with_system_pods KubernetesCluster#skip_nodes_with_system_pods}.</summary>
        [JsiiProperty(name: "skipNodesWithSystemPods", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SkipNodesWithSystemPods
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterAutoScalerProfile), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#balance_similar_node_groups KubernetesCluster#balance_similar_node_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "balanceSimilarNodeGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? BalanceSimilarNodeGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#empty_bulk_delete_max KubernetesCluster#empty_bulk_delete_max}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emptyBulkDeleteMax", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmptyBulkDeleteMax
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#expander KubernetesCluster#expander}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expander", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expander
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_graceful_termination_sec KubernetesCluster#max_graceful_termination_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxGracefulTerminationSec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxGracefulTerminationSec
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_node_provisioning_time KubernetesCluster#max_node_provisioning_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxNodeProvisioningTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxNodeProvisioningTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_unready_nodes KubernetesCluster#max_unready_nodes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnreadyNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnreadyNodes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_unready_percentage KubernetesCluster#max_unready_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnreadyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnreadyPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#new_pod_scale_up_delay KubernetesCluster#new_pod_scale_up_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "newPodScaleUpDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NewPodScaleUpDelay
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_add KubernetesCluster#scale_down_delay_after_add}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownDelayAfterAdd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownDelayAfterAdd
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_delete KubernetesCluster#scale_down_delay_after_delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownDelayAfterDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownDelayAfterDelete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_failure KubernetesCluster#scale_down_delay_after_failure}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownDelayAfterFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownDelayAfterFailure
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_unneeded KubernetesCluster#scale_down_unneeded}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUnneeded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownUnneeded
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_unready KubernetesCluster#scale_down_unready}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUnready", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownUnready
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_utilization_threshold KubernetesCluster#scale_down_utilization_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScaleDownUtilizationThreshold
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scan_interval KubernetesCluster#scan_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scanInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScanInterval
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#skip_nodes_with_local_storage KubernetesCluster#skip_nodes_with_local_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipNodesWithLocalStorage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipNodesWithLocalStorage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#skip_nodes_with_system_pods KubernetesCluster#skip_nodes_with_system_pods}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skipNodesWithSystemPods", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SkipNodesWithSystemPods
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
