using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteOutputReference), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecGrpcRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecGrpcRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecGrpcRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshRouteSpecGrpcRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecGrpcRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteAction\"}}]")]
        public virtual void PutAction(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteMatch\"}}]")]
        public virtual void PutMatch(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeout\"}}]")]
        public virtual void PutTimeout(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMatch")]
        public virtual void ResetMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryPolicy")]
        public virtual void ResetRetryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteActionOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteMatchOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteMatchOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicyOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteAction\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteMatch\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRouteTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
