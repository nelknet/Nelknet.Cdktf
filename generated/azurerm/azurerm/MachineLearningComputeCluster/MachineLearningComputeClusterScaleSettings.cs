using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.machineLearningComputeCluster.MachineLearningComputeClusterScaleSettings")]
    public class MachineLearningComputeClusterScaleSettings : azurerm.MachineLearningComputeCluster.IMachineLearningComputeClusterScaleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#max_node_count MachineLearningComputeCluster#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxNodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#min_node_count MachineLearningComputeCluster#min_node_count}.</summary>
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinNodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#scale_down_nodes_after_idle_duration MachineLearningComputeCluster#scale_down_nodes_after_idle_duration}.</summary>
        [JsiiProperty(name: "scaleDownNodesAfterIdleDuration", typeJson: "{\"primitive\":\"string\"}")]
        public string ScaleDownNodesAfterIdleDuration
        {
            get;
            set;
        }
    }
}
