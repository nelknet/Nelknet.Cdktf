using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh")]
    public class MachineLearningComputeInstanceSsh : azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#public_key MachineLearningComputeInstance#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PublicKey
        {
            get;
            set;
        }
    }
}
