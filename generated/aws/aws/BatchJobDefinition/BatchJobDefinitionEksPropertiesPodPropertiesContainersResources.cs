using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesContainersResources")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesContainersResources : aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesContainersResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#limits BatchJobDefinition#limits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Limits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#requests BatchJobDefinition#requests}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Requests
        {
            get;
            set;
        }
    }
}
