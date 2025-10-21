using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListener
{
    [JsiiClass(nativeType: typeof(aws.LbListener.LbListenerDefaultActionOutputReference), fullyQualifiedName: "aws.lbListener.LbListenerDefaultActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbListenerDefaultActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbListenerDefaultActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbListenerDefaultActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerDefaultActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticateCognito", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionAuthenticateCognito\"}}]")]
        public virtual void PutAuthenticateCognito(aws.LbListener.ILbListenerDefaultActionAuthenticateCognito @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerDefaultActionAuthenticateCognito)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticateOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionAuthenticateOidc\"}}]")]
        public virtual void PutAuthenticateOidc(aws.LbListener.ILbListenerDefaultActionAuthenticateOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerDefaultActionAuthenticateOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionFixedResponse\"}}]")]
        public virtual void PutFixedResponse(aws.LbListener.ILbListenerDefaultActionFixedResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerDefaultActionFixedResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionForward\"}}]")]
        public virtual void PutForward(aws.LbListener.ILbListenerDefaultActionForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerDefaultActionForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListener.LbListenerDefaultActionRedirect\"}}]")]
        public virtual void PutRedirect(aws.LbListener.ILbListenerDefaultActionRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListener.ILbListenerDefaultActionRedirect)}, new object[]{@value});
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

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionAuthenticateCognitoOutputReference\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionAuthenticateCognitoOutputReference AuthenticateCognito
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionAuthenticateCognitoOutputReference>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionAuthenticateOidcOutputReference\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionAuthenticateOidcOutputReference AuthenticateOidc
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionAuthenticateOidcOutputReference>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionFixedResponseOutputReference\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionForwardOutputReference\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionForwardOutputReference Forward
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionForwardOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionRedirectOutputReference\"}")]
        public virtual aws.LbListener.LbListenerDefaultActionRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<aws.LbListener.LbListenerDefaultActionRedirectOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognitoInput", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerDefaultActionAuthenticateCognito? AuthenticateCognitoInput
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerDefaultActionAuthenticateCognito?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidcInput", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerDefaultActionAuthenticateOidc? AuthenticateOidcInput
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerDefaultActionAuthenticateOidc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedResponseInput", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionFixedResponse\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerDefaultActionFixedResponse? FixedResponseInput
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerDefaultActionFixedResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionForward\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerDefaultActionForward? ForwardInput
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerDefaultActionForward?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"fqn\":\"aws.lbListener.LbListenerDefaultActionRedirect\"}", isOptional: true)]
        public virtual aws.LbListener.ILbListenerDefaultActionRedirect? RedirectInput
        {
            get => GetInstanceProperty<aws.LbListener.ILbListenerDefaultActionRedirect?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lbListener.LbListenerDefaultAction\"}]}}", isOptional: true)]
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
                        case aws.LbListener.ILbListenerDefaultAction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListener.ILbListenerDefaultAction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
