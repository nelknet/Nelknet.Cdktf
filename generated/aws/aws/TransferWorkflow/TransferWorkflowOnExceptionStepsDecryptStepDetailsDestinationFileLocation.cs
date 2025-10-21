using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiByValue(fqn: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation")]
    public class TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation : aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation
    {
        /// <summary>efs_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
        {
            get;
            set;
        }

        /// <summary>s3_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
        {
            get;
            set;
        }
    }
}
