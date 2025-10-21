using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir : aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#size_limit BatchJobDefinition#size_limit}.</summary>
        [JsiiProperty(name: "sizeLimit", typeJson: "{\"primitive\":\"string\"}")]
        public string SizeLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#medium BatchJobDefinition#medium}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "medium", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Medium
        {
            get;
            set;
        }
    }
}
