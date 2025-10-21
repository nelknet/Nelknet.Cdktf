using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesVolumes : aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes
    {
        /// <summary>empty_dir block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#empty_dir BatchJobDefinition#empty_dir}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emptyDir", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir\"}", isOptional: true)]
        public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDir
        {
            get;
            set;
        }

        /// <summary>host_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#host_path BatchJobDefinition#host_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath\"}", isOptional: true)]
        public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath? HostPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#name BatchJobDefinition#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#secret BatchJobDefinition#secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret\"}", isOptional: true)]
        public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret? Secret
        {
            get;
            set;
        }
    }
}
