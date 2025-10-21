using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontResponseHeadersPolicy
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentSecurityPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}}]")]
        public virtual void PutContentSecurityPolicy(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContentTypeOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}}]")]
        public virtual void PutContentTypeOptions(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrameOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}}]")]
        public virtual void PutFrameOptions(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReferrerPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}}]")]
        public virtual void PutReferrerPolicy(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStrictTransportSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}}]")]
        public virtual void PutStrictTransportSecurity(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXssProtection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}}]")]
        public virtual void PutXssProtection(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContentSecurityPolicy")]
        public virtual void ResetContentSecurityPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentTypeOptions")]
        public virtual void ResetContentTypeOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrameOptions")]
        public virtual void ResetFrameOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReferrerPolicy")]
        public virtual void ResetReferrerPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStrictTransportSecurity")]
        public virtual void ResetStrictTransportSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXssProtection")]
        public virtual void ResetXssProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicyOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicyOutputReference ContentSecurityPolicy
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptionsOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptionsOutputReference ContentTypeOptions
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptionsOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptionsOutputReference FrameOptions
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicyOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicyOutputReference ReferrerPolicy
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurityOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurityOutputReference StrictTransportSecurity
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtectionOutputReference\"}")]
        public virtual aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtectionOutputReference XssProtection
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtectionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentSecurityPolicyInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicyInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentTypeOptionsInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptionsInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frameOptionsInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptionsInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referrerPolicyInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicyInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strictTransportSecurityInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurityInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xssProtectionInput", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtectionInput
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
