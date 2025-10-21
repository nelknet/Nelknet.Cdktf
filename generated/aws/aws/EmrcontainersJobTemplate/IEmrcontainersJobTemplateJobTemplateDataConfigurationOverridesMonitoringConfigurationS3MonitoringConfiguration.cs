using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiInterface(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration")]
    public interface IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#log_uri EmrcontainersJobTemplate#log_uri}.</summary>
        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}")]
        string LogUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#log_uri EmrcontainersJobTemplate#log_uri}.</summary>
            [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}")]
            public string LogUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
