using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiClass(nativeType: typeof(aws.TransferServer.TransferServerWorkflowDetailsOutputReference), fullyQualifiedName: "aws.transferServer.TransferServerWorkflowDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TransferServerWorkflowDetailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TransferServerWorkflowDetailsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferServerWorkflowDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TransferServerWorkflowDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putOnPartialUpload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload\"}}]")]
        public virtual void PutOnPartialUpload(aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOnUpload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnUpload\"}}]")]
        public virtual void PutOnUpload(aws.TransferServer.ITransferServerWorkflowDetailsOnUpload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TransferServer.ITransferServerWorkflowDetailsOnUpload)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOnPartialUpload")]
        public virtual void ResetOnPartialUpload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnUpload")]
        public virtual void ResetOnUpload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "onPartialUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnPartialUploadOutputReference\"}")]
        public virtual aws.TransferServer.TransferServerWorkflowDetailsOnPartialUploadOutputReference OnPartialUpload
        {
            get => GetInstanceProperty<aws.TransferServer.TransferServerWorkflowDetailsOnPartialUploadOutputReference>()!;
        }

        [JsiiProperty(name: "onUpload", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnUploadOutputReference\"}")]
        public virtual aws.TransferServer.TransferServerWorkflowDetailsOnUploadOutputReference OnUpload
        {
            get => GetInstanceProperty<aws.TransferServer.TransferServerWorkflowDetailsOnUploadOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "onPartialUploadInput", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnPartialUpload\"}", isOptional: true)]
        public virtual aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload? OnPartialUploadInput
        {
            get => GetInstanceProperty<aws.TransferServer.ITransferServerWorkflowDetailsOnPartialUpload?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onUploadInput", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetailsOnUpload\"}", isOptional: true)]
        public virtual aws.TransferServer.ITransferServerWorkflowDetailsOnUpload? OnUploadInput
        {
            get => GetInstanceProperty<aws.TransferServer.ITransferServerWorkflowDetailsOnUpload?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.transferServer.TransferServerWorkflowDetails\"}", isOptional: true)]
        public virtual aws.TransferServer.ITransferServerWorkflowDetails? InternalValue
        {
            get => GetInstanceProperty<aws.TransferServer.ITransferServerWorkflowDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
