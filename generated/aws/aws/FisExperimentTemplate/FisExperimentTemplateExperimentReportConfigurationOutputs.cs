using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputs")]
    public class FisExperimentTemplateExperimentReportConfigurationOutputs : aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs
    {
        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#s3_configuration FisExperimentTemplate#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputsS3Configuration\"}", isOptional: true)]
        public aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputsS3Configuration? S3Configuration
        {
            get;
            set;
        }
    }
}
