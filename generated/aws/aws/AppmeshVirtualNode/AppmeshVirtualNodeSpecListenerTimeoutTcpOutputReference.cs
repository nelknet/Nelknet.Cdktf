using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutTcpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}}]")]
        public virtual void PutIdle(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdle")]
        public virtual void ResetIdle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdleOutputReference\"}")]
        public virtual aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcpIdle\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle? IdleInput
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcpIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerTimeoutTcp\"}", isOptional: true)]
        public virtual aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcp? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerTimeoutTcp?>();
            set => SetInstanceProperty(value);
        }
    }
}
