using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ChaosStudioExperiment
{
    [JsiiInterface(nativeType: typeof(IChaosStudioExperimentStepsBranch), fullyQualifiedName: "azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranch")]
    public interface IChaosStudioExperimentStepsBranch
    {
        /// <summary>actions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#actions ChaosStudioExperiment#actions}
        /// </remarks>
        [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranchActions\"},\"kind\":\"array\"}}]}}")]
        object Actions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#name ChaosStudioExperiment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IChaosStudioExperimentStepsBranch), fullyQualifiedName: "azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranch")]
        internal sealed class _Proxy : DeputyBase, azurerm.ChaosStudioExperiment.IChaosStudioExperimentStepsBranch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>actions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#actions ChaosStudioExperiment#actions}
            /// </remarks>
            [JsiiProperty(name: "actions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranchActions\"},\"kind\":\"array\"}}]}}")]
            public object Actions
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
