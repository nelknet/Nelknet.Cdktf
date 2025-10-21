using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleConditionOutputReference), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketWebsiteConfigurationRoutingRuleConditionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketWebsiteConfigurationRoutingRuleConditionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketWebsiteConfigurationRoutingRuleConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketWebsiteConfigurationRoutingRuleConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHttpErrorCodeReturnedEquals")]
        public virtual void ResetHttpErrorCodeReturnedEquals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyPrefixEquals")]
        public virtual void ResetKeyPrefixEquals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpErrorCodeReturnedEqualsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpErrorCodeReturnedEqualsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyPrefixEqualsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyPrefixEqualsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "httpErrorCodeReturnedEquals", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpErrorCodeReturnedEquals
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyPrefixEquals", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyPrefixEquals
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleCondition\"}", isOptional: true)]
        public virtual aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
