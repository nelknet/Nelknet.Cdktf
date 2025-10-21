using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowOnExceptionSteps), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionSteps")]
    public interface ITransferWorkflowOnExceptionSteps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#type TransferWorkflow#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>copy_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#copy_step_details TransferWorkflow#copy_step_details}
        /// </remarks>
        [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails? CopyStepDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#custom_step_details TransferWorkflow#custom_step_details}
        /// </remarks>
        [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails? CustomStepDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>decrypt_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#decrypt_step_details TransferWorkflow#decrypt_step_details}
        /// </remarks>
        [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails? DecryptStepDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>delete_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#delete_step_details TransferWorkflow#delete_step_details}
        /// </remarks>
        [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails? DeleteStepDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#tag_step_details TransferWorkflow#tag_step_details}
        /// </remarks>
        [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails? TagStepDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowOnExceptionSteps), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowOnExceptionSteps")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowOnExceptionSteps
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

            /// <summary>copy_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#copy_step_details TransferWorkflow#copy_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails? CopyStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails?>();
            }

            /// <summary>custom_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#custom_step_details TransferWorkflow#custom_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails? CustomStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails?>();
            }

            /// <summary>decrypt_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#decrypt_step_details TransferWorkflow#decrypt_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails? DecryptStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails?>();
            }

            /// <summary>delete_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#delete_step_details TransferWorkflow#delete_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails? DeleteStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails?>();
            }

            /// <summary>tag_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#tag_step_details TransferWorkflow#tag_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails? TagStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails?>();
            }
        }
    }
}
