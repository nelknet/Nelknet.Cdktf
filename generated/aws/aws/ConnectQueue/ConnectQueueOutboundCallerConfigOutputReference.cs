using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectQueue
{
    [JsiiClass(nativeType: typeof(aws.ConnectQueue.ConnectQueueOutboundCallerConfigOutputReference), fullyQualifiedName: "aws.connectQueue.ConnectQueueOutboundCallerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConnectQueueOutboundCallerConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConnectQueueOutboundCallerConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConnectQueueOutboundCallerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectQueueOutboundCallerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOutboundCallerIdName")]
        public virtual void ResetOutboundCallerIdName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundCallerIdNumberId")]
        public virtual void ResetOutboundCallerIdNumberId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutboundFlowId")]
        public virtual void ResetOutboundFlowId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundCallerIdNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundCallerIdNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundCallerIdNumberIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundCallerIdNumberIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outboundFlowIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutboundFlowIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "outboundCallerIdName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundCallerIdName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundCallerIdNumberId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundCallerIdNumberId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outboundFlowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutboundFlowId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connectQueue.ConnectQueueOutboundCallerConfig\"}", isOptional: true)]
        public virtual aws.ConnectQueue.IConnectQueueOutboundCallerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.ConnectQueue.IConnectQueueOutboundCallerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
