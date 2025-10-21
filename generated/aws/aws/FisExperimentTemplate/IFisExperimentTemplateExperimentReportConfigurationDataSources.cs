using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiInterface(nativeType: typeof(IFisExperimentTemplateExperimentReportConfigurationDataSources), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources")]
    public interface IFisExperimentTemplateExperimentReportConfigurationDataSources
    {
        /// <summary>cloudwatch_dashboard block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#cloudwatch_dashboard FisExperimentTemplate#cloudwatch_dashboard}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchDashboard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudwatchDashboard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFisExperimentTemplateExperimentReportConfigurationDataSources), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources")]
        internal sealed class _Proxy : DeputyBase, aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_dashboard block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#cloudwatch_dashboard FisExperimentTemplate#cloudwatch_dashboard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchDashboard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSourcesCloudwatchDashboard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudwatchDashboard
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
