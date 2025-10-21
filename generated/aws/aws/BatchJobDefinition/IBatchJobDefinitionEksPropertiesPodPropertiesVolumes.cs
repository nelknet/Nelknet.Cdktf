using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodPropertiesVolumes), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes")]
    public interface IBatchJobDefinitionEksPropertiesPodPropertiesVolumes
    {
        /// <summary>empty_dir block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#empty_dir BatchJobDefinition#empty_dir}
        /// </remarks>
        [JsiiProperty(name: "emptyDir", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>host_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#host_path BatchJobDefinition#host_path}
        /// </remarks>
        [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath? HostPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#name BatchJobDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#secret BatchJobDefinition#secret}
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret? Secret
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionEksPropertiesPodPropertiesVolumes), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>empty_dir block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#empty_dir BatchJobDefinition#empty_dir}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emptyDir", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir\"}", isOptional: true)]
            public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDir
            {
                get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir?>();
            }

            /// <summary>host_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#host_path BatchJobDefinition#host_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath\"}", isOptional: true)]
            public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath? HostPath
            {
                get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#name BatchJobDefinition#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#secret BatchJobDefinition#secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret\"}", isOptional: true)]
            public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret? Secret
            {
                get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret?>();
            }
        }
    }
}
