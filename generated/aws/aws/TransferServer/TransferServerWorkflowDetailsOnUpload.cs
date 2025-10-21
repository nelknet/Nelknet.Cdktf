using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferServer.TransferServerWorkflowDetailsOnUpload")]
    public class TransferServerWorkflowDetailsOnUpload : aws.TransferServer.ITransferServerWorkflowDetailsOnUpload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#execution_role TransferServer#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ExecutionRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#workflow_id TransferServer#workflow_id}.</summary>
        [JsiiProperty(name: "workflowId", typeJson: "{\"primitive\":\"string\"}")]
        public string WorkflowId
        {
            get;
            set;
        }
    }
}
