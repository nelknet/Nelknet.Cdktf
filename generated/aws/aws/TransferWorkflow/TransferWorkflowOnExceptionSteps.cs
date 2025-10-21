using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferWorkflow.TransferWorkflowOnExceptionSteps")]
    public class TransferWorkflowOnExceptionSteps : aws.TransferWorkflow.ITransferWorkflowOnExceptionSteps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#type TransferWorkflow#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>copy_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#copy_step_details TransferWorkflow#copy_step_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "copyStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCopyStepDetails\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCopyStepDetails? CopyStepDetails
        {
            get;
            set;
        }

        /// <summary>custom_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#custom_step_details TransferWorkflow#custom_step_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsCustomStepDetails\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsCustomStepDetails? CustomStepDetails
        {
            get;
            set;
        }

        /// <summary>decrypt_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#decrypt_step_details TransferWorkflow#decrypt_step_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "decryptStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDecryptStepDetails\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDecryptStepDetails? DecryptStepDetails
        {
            get;
            set;
        }

        /// <summary>delete_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#delete_step_details TransferWorkflow#delete_step_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deleteStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsDeleteStepDetails\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsDeleteStepDetails? DeleteStepDetails
        {
            get;
            set;
        }

        /// <summary>tag_step_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#tag_step_details TransferWorkflow#tag_step_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagStepDetails", typeJson: "{\"fqn\":\"aws.transferWorkflow.TransferWorkflowOnExceptionStepsTagStepDetails\"}", isOptional: true)]
        public aws.TransferWorkflow.ITransferWorkflowOnExceptionStepsTagStepDetails? TagStepDetails
        {
            get;
            set;
        }
    }
}
