using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference), fullyQualifiedName: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQueryStrings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}}]")]
        public virtual void PutQueryStrings(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetQueryStrings")]
        public virtual void ResetQueryStrings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStringsOutputReference\"}")]
        public virtual aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStringsOutputReference QueryStrings
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStringsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryStringBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringsInput", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings? QueryStringsInput
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings?>();
        }

        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryStringBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig\"}", isOptional: true)]
        public virtual aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
