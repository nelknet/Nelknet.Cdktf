using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetails")]
    public class TransferWorkflowStepsDecryptStepDetails : aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#type TransferWorkflow#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>destination_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#destination_file_location TransferWorkflow#destination_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#name TransferWorkflow#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#overwrite_existing TransferWorkflow#overwrite_existing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overwriteExisting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OverwriteExisting
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
