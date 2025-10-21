using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferWorkflow
{
    [JsiiInterface(nativeType: typeof(ITransferWorkflowStepsDeleteStepDetails), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetails")]
    public interface ITransferWorkflowStepsDeleteStepDetails
    {
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

        [JsiiTypeProxy(nativeType: typeof(ITransferWorkflowStepsDeleteStepDetails), fullyQualifiedName: "aws.transferWorkflow.TransferWorkflowStepsDeleteStepDetails")]
        internal sealed class _Proxy : DeputyBase, aws.TransferWorkflow.ITransferWorkflowStepsDeleteStepDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_workflow#name TransferWorkflow#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
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
