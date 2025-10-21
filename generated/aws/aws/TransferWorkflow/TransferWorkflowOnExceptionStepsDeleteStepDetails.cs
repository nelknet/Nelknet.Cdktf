using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiByValue(fqn: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetails")]
    public class TransferWorkflowOnExceptionStepsDeleteStepDetails : aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#name TransferWorkflow#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#source_file_location TransferWorkflow#source_file_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceFileLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceFileLocation
        {
            get;
            set;
        }
    }
}
