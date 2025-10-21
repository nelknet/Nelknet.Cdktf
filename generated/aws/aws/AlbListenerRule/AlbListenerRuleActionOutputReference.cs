using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.AlbListenerRule.AlbListenerRuleActionOutputReference), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbListenerRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbListenerRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbListenerRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticateCognito", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionAuthenticateCognito\"}}]")]
        public virtual void PutAuthenticateCognito(aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateCognito @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateCognito)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticateOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionAuthenticateOidc\"}}]")]
        public virtual void PutAuthenticateOidc(aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionFixedResponse\"}}]")]
        public virtual void PutFixedResponse(aws.AlbListenerRule.IAlbListenerRuleActionFixedResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleActionFixedResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionForward\"}}]")]
        public virtual void PutForward(aws.AlbListenerRule.IAlbListenerRuleActionForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleActionForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionRedirect\"}}]")]
        public virtual void PutRedirect(aws.AlbListenerRule.IAlbListenerRuleActionRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleActionRedirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticateCognito")]
        public virtual void ResetAuthenticateCognito()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthenticateOidc")]
        public virtual void ResetAuthenticateOidc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedResponse")]
        public virtual void ResetFixedResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForward")]
        public virtual void ResetForward()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrder")]
        public virtual void ResetOrder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirect")]
        public virtual void ResetRedirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGroupArn")]
        public virtual void ResetTargetGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionAuthenticateCognitoOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleActionAuthenticateCognitoOutputReference AuthenticateCognito
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleActionAuthenticateCognitoOutputReference>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionAuthenticateOidcOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleActionAuthenticateOidcOutputReference AuthenticateOidc
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleActionAuthenticateOidcOutputReference>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionFixedResponseOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionForwardOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleActionForwardOutputReference Forward
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleActionForwardOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionRedirectOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleActionRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleActionRedirectOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognitoInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateCognito? AuthenticateCognitoInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateCognito?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidcInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateOidc? AuthenticateOidcInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleActionAuthenticateOidc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedResponseInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionFixedResponse\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleActionFixedResponse? FixedResponseInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleActionFixedResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionForward\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleActionForward? ForwardInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleActionForward?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleActionRedirect\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleActionRedirect? RedirectInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleActionRedirect?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.albListenerRule.AlbListenerRuleAction\"}]}}", isOptional: true)]
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
                        case aws.AlbListenerRule.IAlbListenerRuleAction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleAction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
