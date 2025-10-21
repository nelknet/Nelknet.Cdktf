using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentOptions")]
    public class FisExperimentTemplateExperimentOptions : aws.FisExperimentTemplate.IFisExperimentTemplateExperimentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#account_targeting FisExperimentTemplate#account_targeting}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountTargeting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountTargeting
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#empty_target_resolution_mode FisExperimentTemplate#empty_target_resolution_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emptyTargetResolutionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmptyTargetResolutionMode
        {
            get;
            set;
        }
    }
}
