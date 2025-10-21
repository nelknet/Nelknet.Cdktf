using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ChaosStudioExperiment
{
    [JsiiInterface(nativeType: typeof(IChaosStudioExperimentSteps), fullyQualifiedName: "azurerm.chaosStudioExperiment.ChaosStudioExperimentSteps")]
    public interface IChaosStudioExperimentSteps
    {
        /// <summary>branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#branch ChaosStudioExperiment#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranch\"},\"kind\":\"array\"}}]}}")]
        object Branch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#name ChaosStudioExperiment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IChaosStudioExperimentSteps), fullyQualifiedName: "azurerm.chaosStudioExperiment.ChaosStudioExperimentSteps")]
        internal sealed class _Proxy : DeputyBase, azurerm.ChaosStudioExperiment.IChaosStudioExperimentSteps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>branch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#branch ChaosStudioExperiment#branch}
            /// </remarks>
            [JsiiProperty(name: "branch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranch\"},\"kind\":\"array\"}}]}}")]
            public object Branch
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#name ChaosStudioExperiment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
