using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshRoute.AppmeshRouteSpecHttpRouteOutputReference), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecHttpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecHttpRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshRouteSpecHttpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteAction\"}}]")]
        public virtual void PutAction(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatch\"}}]")]
        public virtual void PutMatch(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout\"}}]")]
        public virtual void PutTimeout(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout)}, new object[]{@value});
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

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteActionOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttpRouteActionOutputReference Action
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttpRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatchOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttpRouteMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttpRouteMatchOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeoutOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttpRouteTimeoutOutputReference Timeout
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttpRouteTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteAction\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction? ActionInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatch\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch? MatchInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteTimeout\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout? TimeoutInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
