using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiInterface(nativeType: typeof(IFisExperimentTemplateExperimentReportConfiguration), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration")]
    public interface IFisExperimentTemplateExperimentReportConfiguration
    {
        /// <summary>data_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#data_sources FisExperimentTemplate#data_sources}
        /// </remarks>
        [JsiiProperty(name: "dataSources", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources? DataSources
        {
            get
            {
                return null;
            }
        }

        /// <summary>outputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#outputs FisExperimentTemplate#outputs}
        /// </remarks>
        [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs? Outputs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#post_experiment_duration FisExperimentTemplate#post_experiment_duration}.</summary>
        [JsiiProperty(name: "postExperimentDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostExperimentDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#pre_experiment_duration FisExperimentTemplate#pre_experiment_duration}.</summary>
        [JsiiProperty(name: "preExperimentDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreExperimentDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFisExperimentTemplateExperimentReportConfiguration), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#data_sources FisExperimentTemplate#data_sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSources", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationDataSources\"}", isOptional: true)]
            public aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources? DataSources
            {
                get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationDataSources?>();
            }

            /// <summary>outputs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#outputs FisExperimentTemplate#outputs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputs", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateExperimentReportConfigurationOutputs\"}", isOptional: true)]
            public aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs? Outputs
            {
                get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateExperimentReportConfigurationOutputs?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#post_experiment_duration FisExperimentTemplate#post_experiment_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postExperimentDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostExperimentDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#pre_experiment_duration FisExperimentTemplate#pre_experiment_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preExperimentDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreExperimentDuration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
