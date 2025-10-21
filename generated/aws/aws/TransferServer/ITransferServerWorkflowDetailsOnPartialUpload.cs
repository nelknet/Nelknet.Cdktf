using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiInterface(nativeType: typeof(ITransferServerWorkflowDetailsOnPartialUpload), fullyQualifiedName: "aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload")]
    public interface ITransferServerWorkflowDetailsOnPartialUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#execution_role TransferServer#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRole
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#workflow_id TransferServer#workflow_id}.</summary>
        [JsiiProperty(name: "workflowId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkflowId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferServerWorkflowDetailsOnPartialUpload), fullyQualifiedName: "aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload")]
        internal sealed class _Proxy : DeputyBase, aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#execution_role TransferServer#execution_role}.</summary>
            [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#workflow_id TransferServer#workflow_id}.</summary>
            [JsiiProperty(name: "workflowId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkflowId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
