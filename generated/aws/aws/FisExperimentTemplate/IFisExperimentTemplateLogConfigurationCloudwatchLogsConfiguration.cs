using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiInterface(nativeType: typeof(IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration")]
    public interface IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_group_arn FisExperimentTemplate#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_group_arn FisExperimentTemplate#log_group_arn}.</summary>
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
