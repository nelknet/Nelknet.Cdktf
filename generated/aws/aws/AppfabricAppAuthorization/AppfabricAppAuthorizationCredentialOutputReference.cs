using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    [JsiiClass(nativeType: typeof(aws.AppfabricAppAuthorization.AppfabricAppAuthorizationCredentialOutputReference), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppfabricAppAuthorizationCredentialOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppfabricAppAuthorizationCredentialOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppfabricAppAuthorizationCredentialOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppfabricAppAuthorizationCredentialOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApiKeyCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutApiKeyCredential(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth2Credential", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOauth2Credential(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialOauth2Credential[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialOauth2Credential).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialOauth2Credential).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiKeyCredential")]
        public virtual void ResetApiKeyCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2Credential")]
        public virtual void ResetOauth2Credential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "apiKeyCredential", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredentialList\"}")]
        public virtual aws.AppfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredentialList ApiKeyCredential
        {
            get => GetInstanceProperty<aws.AppfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredentialList>()!;
        }

        [JsiiProperty(name: "oauth2Credential", typeJson: "{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2CredentialList\"}")]
        public virtual aws.AppfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2CredentialList Oauth2Credential
        {
            get => GetInstanceProperty<aws.AppfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2CredentialList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeyCredentialInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApiKeyCredentialInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauth2CredentialInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Oauth2CredentialInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredential\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredential cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredential).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
