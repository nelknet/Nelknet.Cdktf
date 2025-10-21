using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowSteps), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowSteps")]
    public interface ITransferWorkflowSteps
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
        [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails? CopyStepDetails
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
        [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCustomStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails? CustomStepDetails
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
        [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails? DecryptStepDetails
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
        [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails? DeleteStepDetails
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
        [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsTagStepDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails? TagStepDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowSteps), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowSteps")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowSteps
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
            [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCopyStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails? CopyStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsCopyStepDetails?>();
            }

            /// <summary>custom_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#custom_step_details TransferWorkflow#custom_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsCustomStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails? CustomStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsCustomStepDetails?>();
            }

            /// <summary>decrypt_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#decrypt_step_details TransferWorkflow#decrypt_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDecryptStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails? DecryptStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsDecryptStepDetails?>();
            }

            /// <summary>delete_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#delete_step_details TransferWorkflow#delete_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails? DeleteStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails?>();
            }

            /// <summary>tag_step_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#tag_step_details TransferWorkflow#tag_step_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowStepsTagStepDetails\"}", isOptional: true)]
            public aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails? TagStepDetails
            {
                get => GetInstanceProperty<aws.TransferWorkflow.ITransferWorkflowStepsTagStepDetails?>();
            }
        }
    }
}
