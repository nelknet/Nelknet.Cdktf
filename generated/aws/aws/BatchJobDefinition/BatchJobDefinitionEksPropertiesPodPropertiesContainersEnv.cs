using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesContainersEnv")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesContainersEnv : aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainersEnv
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#name BatchJobDefinition#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#value BatchJobDefinition#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
