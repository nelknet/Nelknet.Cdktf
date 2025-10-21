using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.machineLearningComputeCluster.MachineLearningComputeClusterSsh")]
    public class MachineLearningComputeClusterSsh : azurerm.MachineLearningComputeCluster.IMachineLearningComputeClusterSsh
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#admin_username MachineLearningComputeCluster#admin_username}.</summary>
        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#admin_password MachineLearningComputeCluster#admin_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_cluster#key_value MachineLearningComputeCluster#key_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyValue
        {
            get;
            set;
        }
    }
}
