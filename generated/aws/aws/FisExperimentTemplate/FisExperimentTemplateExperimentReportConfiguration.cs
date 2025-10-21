using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration")]
    public class FisExperimentTemplateExperimentReportConfiguration : aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration
    {
        /// <summary>data_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#data_sources FisExperimentTemplate#data_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataSources", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources\"}", isOptional: true)]
        public aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources? DataSources
        {
            get;
            set;
        }

        /// <summary>outputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#outputs FisExperimentTemplate#outputs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputs\"}", isOptional: true)]
        public aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs? Outputs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#post_experiment_duration FisExperimentTemplate#post_experiment_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postExperimentDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostExperimentDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#pre_experiment_duration FisExperimentTemplate#pre_experiment_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preExperimentDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreExperimentDuration
        {
            get;
            set;
        }
    }
}
