using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowStepsCopyStepDetailsDestinationFileLocation), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocation")]
    public interface ITransferWorkflowStepsCopyStepDetailsDestinationFileLocation
    {
        /// <summary>efs_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
        /// </remarks>
        [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
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
        [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowStepsCopyStepDetailsDestinationFileLocation), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocation")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#efs_file_location TransferWorkflow#efs_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efsFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation? EfsFileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationEfsFileLocation?>();
            }

            /// <summary>s3_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#s3_file_location TransferWorkflow#s3_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3FileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation? S3FileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetailsDestinationFileLocationS3FileLocation?>();
            }
        }
    }
}
