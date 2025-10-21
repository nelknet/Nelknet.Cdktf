using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiInterface(nativeType: typeof(IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard")]
    public interface IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#dashboard_arn FisExperimentTemplate#dashboard_arn}.</summary>
        [JsiiProperty(name: "dashboardArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DashboardArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard")]
        internal sealed class _Proxy : DeputyBase, aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#dashboard_arn FisExperimentTemplate#dashboard_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dashboardArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DashboardArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
