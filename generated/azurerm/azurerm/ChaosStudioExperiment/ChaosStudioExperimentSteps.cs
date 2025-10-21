using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ChaosStudioExperiment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.chaosStudioExperiment.ChaosStudioExperimentSteps")]
    public class ChaosStudioExperimentSteps : azurerm.ChaosStudioExperiment.IChaosStudioExperimentSteps
    {
        private object _branch;

        /// <summary>branch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#branch ChaosStudioExperiment#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranch\"},\"kind\":\"array\"}}]}}")]
        public object Branch
        {
            get => _branch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ChaosStudioExperiment.IChaosStudioExperimentStepsBranch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ChaosStudioExperiment.IChaosStudioExperimentStepsBranch).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ChaosStudioExperiment.IChaosStudioExperimentStepsBranch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _branch = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#name ChaosStudioExperiment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
