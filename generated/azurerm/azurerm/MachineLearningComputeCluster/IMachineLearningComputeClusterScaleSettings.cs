using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeCluster
{
    [JsiiInterface(nativeType: typeof(IMachineLearningComputeClusterScaleSettings), fullyQualifiedName: "azurerm.machineLearningComputeCluster.MachineLearningComputeClusterScaleSettings")]
    public interface IMachineLearningComputeClusterScaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#max_node_count MachineLearningComputeCluster#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#min_node_count MachineLearningComputeCluster#min_node_count}.</summary>
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#scale_down_nodes_after_idle_duration MachineLearningComputeCluster#scale_down_nodes_after_idle_duration}.</summary>
        [JsiiProperty(name: "scaleDownNodesAfterIdleDuration", typeJson: "{\"primitive\":\"string\"}")]
        string ScaleDownNodesAfterIdleDuration
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMachineLearningComputeClusterScaleSettings), fullyQualifiedName: "azurerm.machineLearningComputeCluster.MachineLearningComputeClusterScaleSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.MachineLearningComputeCluster.IMachineLearningComputeClusterScaleSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#max_node_count MachineLearningComputeCluster#max_node_count}.</summary>
            [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#min_node_count MachineLearningComputeCluster#min_node_count}.</summary>
            [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#scale_down_nodes_after_idle_duration MachineLearningComputeCluster#scale_down_nodes_after_idle_duration}.</summary>
            [JsiiProperty(name: "scaleDownNodesAfterIdleDuration", typeJson: "{\"primitive\":\"string\"}")]
            public string ScaleDownNodesAfterIdleDuration
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
