using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfiguration")]
    public class FisExperimentTemplateLogConfiguration : aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_schema_version FisExperimentTemplate#log_schema_version}.</summary>
        [JsiiProperty(name: "logSchemaVersion", typeJson: "{\"primitive\":\"number\"}")]
        public double LogSchemaVersion
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logs_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#cloudwatch_logs_configuration FisExperimentTemplate#cloudwatch_logs_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsConfiguration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration\"}", isOptional: true)]
        public aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfiguration
        {
            get;
            set;
        }

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#s3_configuration FisExperimentTemplate#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationS3Configuration\"}", isOptional: true)]
        public aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration? S3Configuration
        {
            get;
            set;
        }
    }
}
