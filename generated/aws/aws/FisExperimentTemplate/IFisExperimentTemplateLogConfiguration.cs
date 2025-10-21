using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiInterface(nativeType: typeof(IFisExperimentTemplateLogConfiguration), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfiguration")]
    public interface IFisExperimentTemplateLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_schema_version FisExperimentTemplate#log_schema_version}.</summary>
        [JsiiProperty(name: "logSchemaVersion", typeJson: "{\"primitive\":\"number\"}")]
        double LogSchemaVersion
        {
            get;
        }

        /// <summary>cloudwatch_logs_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#cloudwatch_logs_configuration FisExperimentTemplate#cloudwatch_logs_configuration}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLogsConfiguration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#s3_configuration FisExperimentTemplate#s3_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationS3Configuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration? S3Configuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFisExperimentTemplateLogConfiguration), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_schema_version FisExperimentTemplate#log_schema_version}.</summary>
            [JsiiProperty(name: "logSchemaVersion", typeJson: "{\"primitive\":\"number\"}")]
            public double LogSchemaVersion
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>cloudwatch_logs_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#cloudwatch_logs_configuration FisExperimentTemplate#cloudwatch_logs_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogsConfiguration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration\"}", isOptional: true)]
            public aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfiguration
            {
                get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration?>();
            }

            /// <summary>s3_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#s3_configuration FisExperimentTemplate#s3_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationS3Configuration\"}", isOptional: true)]
            public aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration? S3Configuration
            {
                get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration?>();
            }
        }
    }
}
