using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutGrpcOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdle\"}}]")]
        public virtual void PutIdle(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest\"}}]")]
        public virtual void PutPerRequest(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdle")]
        public virtual void ResetIdle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerRequest")]
        public virtual void ResetPerRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdleOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdleOutputReference>()!;
        }

        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequestOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequestOutputReference PerRequest
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcIdle\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle? IdleInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRequestInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest? PerRequestInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpcPerRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutGrpc\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpc? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutGrpc?>();
            set => SetInstanceProperty(value);
        }
    }
}
