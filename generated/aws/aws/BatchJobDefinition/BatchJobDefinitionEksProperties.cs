using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchJobDefinition.BatchJobDefinitionEksProperties")]
    public class BatchJobDefinitionEksProperties : aws.BatchJobDefinition.IBatchJobDefinitionEksProperties
    {
        /// <summary>pod_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#pod_properties BatchJobDefinition#pod_properties}
        /// </remarks>
        [JsiiProperty(name: "podProperties", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties\"}")]
        public aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties PodProperties
        {
            get;
            set;
        }
    }
}
