using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration")]
    public class FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration : aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_group_arn FisExperimentTemplate#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupArn
        {
            get;
            set;
        }
    }
}
