using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowOnExceptionStepsDecryptStepDetails), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails")]
    public interface ITransferWorkflowOnExceptionStepsDecryptStepDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#type TransferWorkflow#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>destination_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#destination_file_location TransferWorkflow#destination_file_location}
        /// </remarks>
        [JsiiProperty(name: "destinationFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#name TransferWorkflow#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#overwrite_existing TransferWorkflow#overwrite_existing}.</summary>
        [JsiiProperty(name: "overwriteExisting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OverwriteExisting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#source_file_location TransferWorkflow#source_file_location}.</summary>
        [JsiiProperty(name: "sourceFileLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceFileLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowOnExceptionStepsDecryptStepDetails), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#type TransferWorkflow#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>destination_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#destination_file_location TransferWorkflow#destination_file_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationFileLocation", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation? DestinationFileLocation
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetailsDestinationFileLocation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#name TransferWorkflow#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#overwrite_existing TransferWorkflow#overwrite_existing}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overwriteExisting", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OverwriteExisting
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#source_file_location TransferWorkflow#source_file_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceFileLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceFileLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
