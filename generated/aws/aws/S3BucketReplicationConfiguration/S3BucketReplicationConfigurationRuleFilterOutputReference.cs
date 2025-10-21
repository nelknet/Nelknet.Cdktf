using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketReplicationConfiguration
{
    [JsiiClass(nativeType: typeof(aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterOutputReference), fullyQualifiedName: "aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class S3BucketReplicationConfigurationRuleFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public S3BucketReplicationConfigurationRuleFilterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected S3BucketReplicationConfigurationRuleFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketReplicationConfigurationRuleFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnd", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterAnd\"}}]")]
        public virtual void PutAnd(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterAnd @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterAnd)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterTag\"}}]")]
        public virtual void PutTag(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterTag @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterTag)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAnd")]
        public virtual void ResetAnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "and", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterAndOutputReference\"}")]
        public virtual aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterAndOutputReference And
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterAndOutputReference>()!;
        }

        [JsiiProperty(name: "tag", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterTagOutputReference\"}")]
        public virtual aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterTagOutputReference Tag
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterTagOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andInput", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterAnd\"}", isOptional: true)]
        public virtual aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterAnd? AndInput
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterAnd?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilterTag\"}", isOptional: true)]
        public virtual aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterTag? TagInput
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilterTag?>();
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3BucketReplicationConfiguration.S3BucketReplicationConfigurationRuleFilter\"}", isOptional: true)]
        public virtual aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilter? InternalValue
        {
            get => GetInstanceProperty<aws.S3BucketReplicationConfiguration.IS3BucketReplicationConfigurationRuleFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
