using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEmailMessage")]
        public virtual void ResetEmailMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailSubject")]
        public virtual void ResetEmailSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsMessage")]
        public virtual void ResetSmsMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailSubjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailSubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailSubject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InternalValue
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
