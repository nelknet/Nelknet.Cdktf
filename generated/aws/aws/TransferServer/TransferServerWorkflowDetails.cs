using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiByValue(fqn: "aws.transferServer.TransferServerWorkflowDetails")]
    public class TransferServerWorkflowDetails : aws.TransferServer.ITransferServerWorkflowDetails
    {
        /// <summary>on_partial_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#on_partial_upload TransferServer#on_partial_upload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onPartialUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload\"}", isOptional: true)]
        public aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload? OnPartialUpload
        {
            get;
            set;
        }

        /// <summary>on_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#on_upload TransferServer#on_upload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnUpload\"}", isOptional: true)]
        public aws.TransferServer.ITransferServerWorkflowDetailsOnUpload? OnUpload
        {
            get;
            set;
        }
    }
}
