using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshRoute.AppmeshRouteSpecTcpRouteTimeoutOutputReference), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecTcpRouteTimeoutOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecTcpRouteTimeoutOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshRouteSpecTcpRouteTimeoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecTcpRouteTimeoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdle\"}}]")]
        public virtual void PutIdle(aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdle")]
        public virtual void ResetIdle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdleOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle? IdleInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeoutIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRouteTimeout?>();
            set => SetInstanceProperty(value);
        }
    }
}
