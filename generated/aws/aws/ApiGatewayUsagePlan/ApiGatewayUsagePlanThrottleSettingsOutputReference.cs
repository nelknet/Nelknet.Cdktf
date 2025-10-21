using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayUsagePlan
{
    [JsiiClass(nativeType: typeof(aws.ApiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettingsOutputReference), fullyQualifiedName: "aws.apiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiGatewayUsagePlanThrottleSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiGatewayUsagePlanThrottleSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiGatewayUsagePlanThrottleSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlanThrottleSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBurstLimit")]
        public virtual void ResetBurstLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRateLimit")]
        public virtual void ResetRateLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "burstLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BurstLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RateLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "burstLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BurstLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rateLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RateLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apiGatewayUsagePlan.ApiGatewayUsagePlanThrottleSettings\"}", isOptional: true)]
        public virtual aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings? InternalValue
        {
            get => GetInstanceProperty<aws.ApiGatewayUsagePlan.IApiGatewayUsagePlanThrottleSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
