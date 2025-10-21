using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiInterface(nativeType: typeof(ITransferServerWorkflowDetails), fullyQualifiedName: "aws.transferServer.TransferServerWorkflowDetails")]
    public interface ITransferServerWorkflowDetails
    {
        /// <summary>on_partial_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#on_partial_upload TransferServer#on_partial_upload}
        /// </remarks>
        [JsiiProperty(name: "onPartialUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload? OnPartialUpload
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_upload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#on_upload TransferServer#on_upload}
        /// </remarks>
        [JsiiProperty(name: "onUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnUpload\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TransferServer.ITransferServerWorkflowDetailsOnUpload? OnUpload
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferServerWorkflowDetails), fullyQualifiedName: "aws.transferServer.TransferServerWorkflowDetails")]
        internal sealed class _Proxy : DeputyBase, aws.TransferServer.ITransferServerWorkflowDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_partial_upload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#on_partial_upload TransferServer#on_partial_upload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onPartialUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload\"}", isOptional: true)]
            public aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload? OnPartialUpload
            {
                get => GetInstanceProperty<aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload?>();
            }

            /// <summary>on_upload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#on_upload TransferServer#on_upload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnUpload\"}", isOptional: true)]
            public aws.TransferServer.ITransferServerWorkflowDetailsOnUpload? OnUpload
            {
                get => GetInstanceProperty<aws.TransferServer.ITransferServerWorkflowDetailsOnUpload?>();
            }
        }
    }
}
