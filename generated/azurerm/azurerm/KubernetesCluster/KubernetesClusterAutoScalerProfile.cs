using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterAutoScalerProfile")]
    public class KubernetesClusterAutoScalerProfile : azurerm.KubernetesCluster.IKubernetesClusterAutoScalerProfile
    {
        private object? _balanceSimilarNodeGroups;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#balance_similar_node_groups KubernetesCluster#balance_similar_node_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "balanceSimilarNodeGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? BalanceSimilarNodeGroups
        {
            get => _balanceSimilarNodeGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _balanceSimilarNodeGroups = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#empty_bulk_delete_max KubernetesCluster#empty_bulk_delete_max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emptyBulkDeleteMax", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmptyBulkDeleteMax
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#expander KubernetesCluster#expander}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expander", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expander
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_graceful_termination_sec KubernetesCluster#max_graceful_termination_sec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxGracefulTerminationSec", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxGracefulTerminationSec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_node_provisioning_time KubernetesCluster#max_node_provisioning_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNodeProvisioningTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxNodeProvisioningTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_unready_nodes KubernetesCluster#max_unready_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnreadyNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnreadyNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#max_unready_percentage KubernetesCluster#max_unready_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnreadyPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUnreadyPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#new_pod_scale_up_delay KubernetesCluster#new_pod_scale_up_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newPodScaleUpDelay", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NewPodScaleUpDelay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_add KubernetesCluster#scale_down_delay_after_add}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownDelayAfterAdd", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownDelayAfterAdd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_delete KubernetesCluster#scale_down_delay_after_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownDelayAfterDelete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownDelayAfterDelete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_delay_after_failure KubernetesCluster#scale_down_delay_after_failure}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownDelayAfterFailure", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownDelayAfterFailure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_unneeded KubernetesCluster#scale_down_unneeded}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUnneeded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownUnneeded
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_unready KubernetesCluster#scale_down_unready}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUnready", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownUnready
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scale_down_utilization_threshold KubernetesCluster#scale_down_utilization_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownUtilizationThreshold", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScaleDownUtilizationThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#scan_interval KubernetesCluster#scan_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScanInterval
        {
            get;
            set;
        }

        private object? _skipNodesWithLocalStorage;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#skip_nodes_with_local_storage KubernetesCluster#skip_nodes_with_local_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipNodesWithLocalStorage", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipNodesWithLocalStorage
        {
            get => _skipNodesWithLocalStorage;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _skipNodesWithLocalStorage = value;
            }
        }

        private object? _skipNodesWithSystemPods;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#skip_nodes_with_system_pods KubernetesCluster#skip_nodes_with_system_pods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipNodesWithSystemPods", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipNodesWithSystemPods
        {
            get => _skipNodesWithSystemPods;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _skipNodesWithSystemPods = value;
            }
        }
    }
}
