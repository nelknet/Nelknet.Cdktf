using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiByValue(fqn: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources")]
    public class FisExperimentTemplateExperimentReportConfigurationDataSources : aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources
    {
        private object? _cloudwatchDashboard;

        /// <summary>cloudwatch_dashboard block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#cloudwatch_dashboard FisExperimentTemplate#cloudwatch_dashboard}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchDashboard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudwatchDashboard
        {
            get => _cloudwatchDashboard;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cloudwatchDashboard = value;
            }
        }
    }
}
