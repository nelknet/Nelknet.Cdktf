using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiInterface(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataConfigurationOverrides), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverrides")]
    public interface IEmrcontainersJobTemplateJobTemplateDataConfigurationOverrides
    {
        /// <summary>application_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#application_configuration EmrcontainersJobTemplate#application_configuration}
        /// </remarks>
        [JsiiProperty(name: "applicationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplicationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>monitoring_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#monitoring_configuration EmrcontainersJobTemplate#monitoring_configuration}
        /// </remarks>
        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration? MonitoringConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrcontainersJobTemplateJobTemplateDataConfigurationOverrides), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverrides")]
        internal sealed class _Proxy : DeputyBase, aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverrides
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#application_configuration EmrcontainersJobTemplate#application_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApplicationConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>monitoring_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#monitoring_configuration EmrcontainersJobTemplate#monitoring_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration\"}", isOptional: true)]
            public aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration? MonitoringConfiguration
            {
                get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration?>();
            }
        }
    }
}
