using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiByValue(fqn: "aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocation")]
    public class TransferWorkflowStepsCopyStepDetailsDestinationFileLocation : aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocation
    {
        /// <summary>efs_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
        {
            get;
            set;
        }

        /// <summary>s3_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
        {
            get;
            set;
        }
    }
}
