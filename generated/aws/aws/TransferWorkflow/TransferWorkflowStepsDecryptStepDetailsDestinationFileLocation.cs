using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiByValue(fqn: "aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocation")]
    public class TransferWorkflowStepsDecryptStepDetailsDestinationFileLocation : aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocation
    {
        /// <summary>efs_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
        {
            get;
            set;
        }

        /// <summary>s3_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
        {
            get;
            set;
        }
    }
}
