using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfigOutputReference), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CognitoUserPoolAdminCreateUserConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CognitoUserPoolAdminCreateUserConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CognitoUserPoolAdminCreateUserConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolAdminCreateUserConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInviteMessageTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}}]")]
        public virtual void PutInviteMessageTemplate(aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowAdminCreateUserOnly")]
        public virtual void ResetAllowAdminCreateUserOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInviteMessageTemplate")]
        public virtual void ResetInviteMessageTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference InviteMessageTemplate
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowAdminCreateUserOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowAdminCreateUserOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inviteMessageTemplateInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplateInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate?>();
        }

        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AllowAdminCreateUserOnly
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
