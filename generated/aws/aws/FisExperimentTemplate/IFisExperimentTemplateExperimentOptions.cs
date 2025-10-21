using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiInterface(nativeType: typeof(IFisExperimentTemplateExperimentOptions), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptions")]
    public interface IFisExperimentTemplateExperimentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#account_targeting FisExperimentTemplate#account_targeting}.</summary>
        [JsiiProperty(name: "accountTargeting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountTargeting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#empty_target_resolution_mode FisExperimentTemplate#empty_target_resolution_mode}.</summary>
        [JsiiProperty(name: "emptyTargetResolutionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmptyTargetResolutionMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFisExperimentTemplateExperimentOptions), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptions")]
        internal sealed class _Proxy : DeputyBase, aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#account_targeting FisExperimentTemplate#account_targeting}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountTargeting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountTargeting
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#empty_target_resolution_mode FisExperimentTemplate#empty_target_resolution_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emptyTargetResolutionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmptyTargetResolutionMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
