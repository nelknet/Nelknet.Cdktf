using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigOutputReference), fullyQualifiedName: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontOriginRequestPolicyCookiesConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontOriginRequestPolicyCookiesConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontOriginRequestPolicyCookiesConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyCookiesConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}}]")]
        public virtual void PutCookies(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfigCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfigCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCookies")]
        public virtual void ResetCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookiesOutputReference\"}")]
        public virtual aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CookieBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfigCookies? CookiesInput
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfigCookies?>();
        }

        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
