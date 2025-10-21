using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecHttpRouteRetryPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecHttpRouteRetryPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshRouteSpecHttpRouteRetryPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteRetryPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPerRetryTimeout", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}}]")]
        public virtual void PutPerRetryTimeout(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpRetryEvents")]
        public virtual void ResetHttpRetryEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpRetryEvents")]
        public virtual void ResetTcpRetryEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeoutOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeoutOutputReference PerRetryTimeout
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeoutOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRetryEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HttpRetryEventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxRetriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxRetriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRetryTimeoutInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout? PerRetryTimeoutInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpRetryEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TcpRetryEventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HttpRetryEvents
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRetries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TcpRetryEvents
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteRetryPolicy\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteRetryPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
