using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomainSamlOptions
{
    [JsiiClass(nativeType: typeof(aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsOutputReference), fullyQualifiedName: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDomainSamlOptionsSamlOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDomainSamlOptionsSamlOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchDomainSamlOptionsSamlOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainSamlOptionsSamlOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp\"}}]")]
        public virtual void PutIdp(aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdp")]
        public virtual void ResetIdp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterBackendRole")]
        public virtual void ResetMasterBackendRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterUserName")]
        public virtual void ResetMasterUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRolesKey")]
        public virtual void ResetRolesKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionTimeoutMinutes")]
        public virtual void ResetSessionTimeoutMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubjectKey")]
        public virtual void ResetSubjectKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idp", typeJson: "{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdpOutputReference\"}")]
        public virtual aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdpOutputReference Idp
        {
            get => GetInstanceProperty<aws.OpensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idpInput", typeJson: "{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp\"}", isOptional: true)]
        public virtual aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp? IdpInput
        {
            get => GetInstanceProperty<aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterBackendRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterBackendRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterUserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RolesKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeoutMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SessionTimeoutMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubjectKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "masterBackendRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterBackendRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterUserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RolesKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTimeoutMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptions? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
