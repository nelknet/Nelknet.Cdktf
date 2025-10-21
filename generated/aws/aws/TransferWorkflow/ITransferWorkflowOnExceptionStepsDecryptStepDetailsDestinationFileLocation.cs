using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation")]
    public interface ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation
    {
        /// <summary>efs_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
        /// </remarks>
        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
        /// </remarks>
        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation?>();
            }

            /// <summary>s3_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocationS3FileLocation?>();
            }
        }
    }
}
