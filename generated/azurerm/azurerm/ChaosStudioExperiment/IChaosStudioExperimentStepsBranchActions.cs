using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ChaosStudioExperiment
{
    [JsiiInterface(nativeType: typeof(IChaosStudioExperimentStepsBranchActions), fullyQualifiedName: "azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranchActions")]
    public interface IChaosStudioExperimentStepsBranchActions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#action_type ChaosStudioExperiment#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#duration ChaosStudioExperiment#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#parameters ChaosStudioExperiment#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#selector_name ChaosStudioExperiment#selector_name}.</summary>
        [JsiiProperty(name: "selectorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectorName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#urn ChaosStudioExperiment#urn}.</summary>
        [JsiiProperty(name: "urn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Urn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IChaosStudioExperimentStepsBranchActions), fullyQualifiedName: "azurerm.chaosStudioExperiment.ChaosStudioExperimentStepsBranchActions")]
        internal sealed class _Proxy : DeputyBase, azurerm.ChaosStudioExperiment.IChaosStudioExperimentStepsBranchActions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#action_type ChaosStudioExperiment#action_type}.</summary>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#duration ChaosStudioExperiment#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#parameters ChaosStudioExperiment#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#selector_name ChaosStudioExperiment#selector_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "selectorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectorName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/chaos_studio_experiment#urn ChaosStudioExperiment#urn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "urn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Urn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
