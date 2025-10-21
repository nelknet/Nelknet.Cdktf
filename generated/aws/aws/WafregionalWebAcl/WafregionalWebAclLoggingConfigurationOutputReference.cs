using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAcl
{
    [JsiiClass(nativeType: typeof(aws.WafregionalWebAcl.WafregionalWebAclLoggingConfigurationOutputReference), fullyQualifiedName: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafregionalWebAclLoggingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafregionalWebAclLoggingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WafregionalWebAclLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafregionalWebAclLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRedactedFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields\"}}]")]
        public virtual void PutRedactedFields(aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRedactedFields")]
        public virtual void ResetRedactedFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "redactedFields", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference\"}")]
        public virtual aws.WafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference RedactedFields
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFieldsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redactedFieldsInput", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public virtual aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields? RedactedFieldsInput
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields?>();
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
