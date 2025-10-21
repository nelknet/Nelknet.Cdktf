using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.LbListenerRule.LbListenerRuleActionOutputReference), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbListenerRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbListenerRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbListenerRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticateCognito", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionAuthenticateCognito\"}}]")]
        public virtual void PutAuthenticateCognito(aws.LbListenerRule.ILbListenerRuleActionAuthenticateCognito @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleActionAuthenticateCognito)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticateOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionAuthenticateOidc\"}}]")]
        public virtual void PutAuthenticateOidc(aws.LbListenerRule.ILbListenerRuleActionAuthenticateOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleActionAuthenticateOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionFixedResponse\"}}]")]
        public virtual void PutFixedResponse(aws.LbListenerRule.ILbListenerRuleActionFixedResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleActionFixedResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionForward\"}}]")]
        public virtual void PutForward(aws.LbListenerRule.ILbListenerRuleActionForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleActionForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionRedirect\"}}]")]
        public virtual void PutRedirect(aws.LbListenerRule.ILbListenerRuleActionRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleActionRedirect)}, new object[]{@value});
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

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionAuthenticateCognitoOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleActionAuthenticateCognitoOutputReference AuthenticateCognito
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleActionAuthenticateCognitoOutputReference>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionAuthenticateOidcOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleActionAuthenticateOidcOutputReference AuthenticateOidc
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleActionAuthenticateOidcOutputReference>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionFixedResponseOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionForwardOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleActionForwardOutputReference Forward
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleActionForwardOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionRedirectOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleActionRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleActionRedirectOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognitoInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionAuthenticateCognito\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleActionAuthenticateCognito? AuthenticateCognitoInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleActionAuthenticateCognito?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidcInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionAuthenticateOidc\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleActionAuthenticateOidc? AuthenticateOidcInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleActionAuthenticateOidc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedResponseInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionFixedResponse\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleActionFixedResponse? FixedResponseInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleActionFixedResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionForward\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleActionForward? ForwardInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleActionForward?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleActionRedirect\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleActionRedirect? RedirectInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleActionRedirect?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lbListenerRule.LbListenerRuleAction\"}]}}", isOptional: true)]
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
                        case aws.LbListenerRule.ILbListenerRuleAction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListenerRule.ILbListenerRuleAction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
