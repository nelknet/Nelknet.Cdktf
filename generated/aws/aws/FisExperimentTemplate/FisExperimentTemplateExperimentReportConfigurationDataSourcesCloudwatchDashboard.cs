using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard")]
    public class FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard : aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#dashboard_arn FisExperimentTemplate#dashboard_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dashboardArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DashboardArn
        {
            get;
            set;
        }
    }
}
