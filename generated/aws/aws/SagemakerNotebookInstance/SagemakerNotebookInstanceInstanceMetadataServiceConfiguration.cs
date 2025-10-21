using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerNotebookInstance
{
    [JsiiByValue(fqn: "aws.sagemakerNotebookInstance.SagemakerNotebookInstanceInstanceMetadataServiceConfiguration")]
    public class SagemakerNotebookInstanceInstanceMetadataServiceConfiguration : aws.SagemakerNotebookInstance.ISagemakerNotebookInstanceInstanceMetadataServiceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_notebook_instance#minimum_instance_metadata_service_version SagemakerNotebookInstance#minimum_instance_metadata_service_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumInstanceMetadataServiceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumInstanceMetadataServiceVersion
        {
            get;
            set;
        }
    }
}
