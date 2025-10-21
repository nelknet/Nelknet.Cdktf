using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeInstance
{
    [JsiiInterface(nativeType: typeof(IMachineLearningComputeInstanceSsh), fullyQualifiedName: "azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh")]
    public interface IMachineLearningComputeInstanceSsh
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#public_key MachineLearningComputeInstance#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMachineLearningComputeInstanceSsh), fullyQualifiedName: "azurerm.machineLearningComputeInstance.MachineLearningComputeInstanceSsh")]
        internal sealed class _Proxy : DeputyBase, azurerm.MachineLearningComputeInstance.IMachineLearningComputeInstanceSsh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_compute_instance#public_key MachineLearningComputeInstance#public_key}.</summary>
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
