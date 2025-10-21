using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiClass(nativeType: typeof(aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsOutputReference), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LightsailDistributionCacheBehaviorSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LightsailDistributionCacheBehaviorSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LightsailDistributionCacheBehaviorSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailDistributionCacheBehaviorSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putForwardedCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookies\"}}]")]
        public virtual void PutForwardedCookies(aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForwardedHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders\"}}]")]
        public virtual void PutForwardedHeaders(aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForwardedQueryStrings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings\"}}]")]
        public virtual void PutForwardedQueryStrings(aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowedHttpMethods")]
        public virtual void ResetAllowedHttpMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCachedHttpMethods")]
        public virtual void ResetCachedHttpMethods()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTtl")]
        public virtual void ResetDefaultTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardedCookies")]
        public virtual void ResetForwardedCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardedHeaders")]
        public virtual void ResetForwardedHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardedQueryStrings")]
        public virtual void ResetForwardedQueryStrings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumTtl")]
        public virtual void ResetMaximumTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumTtl")]
        public virtual void ResetMinimumTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "forwardedCookies", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookiesOutputReference\"}")]
        public virtual aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookiesOutputReference ForwardedCookies
        {
            get => GetInstanceProperty<aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookiesOutputReference>()!;
        }

        [JsiiProperty(name: "forwardedHeaders", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference\"}")]
        public virtual aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference ForwardedHeaders
        {
            get => GetInstanceProperty<aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "forwardedQueryStrings", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStringsOutputReference\"}")]
        public virtual aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStringsOutputReference ForwardedQueryStrings
        {
            get => GetInstanceProperty<aws.LightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStringsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedHttpMethodsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AllowedHttpMethodsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachedHttpMethodsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CachedHttpMethodsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardedCookiesInput", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedCookies\"}", isOptional: true)]
        public virtual aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies? ForwardedCookiesInput
        {
            get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedCookies?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardedHeadersInput", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedHeaders\"}", isOptional: true)]
        public virtual aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders? ForwardedHeadersInput
        {
            get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardedQueryStringsInput", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettingsForwardedQueryStrings\"}", isOptional: true)]
        public virtual aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings? ForwardedQueryStringsInput
        {
            get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettingsForwardedQueryStrings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllowedHttpMethods
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cachedHttpMethods", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CachedHttpMethods
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lightsailDistribution.LightsailDistributionCacheBehaviorSettings\"}", isOptional: true)]
        public virtual aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettings? InternalValue
        {
            get => GetInstanceProperty<aws.LightsailDistribution.ILightsailDistributionCacheBehaviorSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
