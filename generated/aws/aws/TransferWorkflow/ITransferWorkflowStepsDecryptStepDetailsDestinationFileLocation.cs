using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocation), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocation")]
    public interface ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocation
    {
        /// <summary>efs_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
        /// </remarks>
        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
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
        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocation), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocation")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationEfsFileLocation?>();
            }

            /// <summary>s3_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetailsDestinationFileLocationS3FileLocation?>();
            }
        }
    }
}
