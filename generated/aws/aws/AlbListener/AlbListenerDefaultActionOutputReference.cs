using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListener
{
    [JsiiClass(nativeType: typeof(aws.AlbListener.AlbListenerDefaultActionOutputReference), fullyQualifiedName: "aws.albListener.AlbListenerDefaultActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbListenerDefaultActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbListenerDefaultActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbListenerDefaultActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerDefaultActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthenticateCognito", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionAuthenticateCognito\"}}]")]
        public virtual void PutAuthenticateCognito(aws.AlbListener.IAlbListenerDefaultActionAuthenticateCognito @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListener.IAlbListenerDefaultActionAuthenticateCognito)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthenticateOidc", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionAuthenticateOidc\"}}]")]
        public virtual void PutAuthenticateOidc(aws.AlbListener.IAlbListenerDefaultActionAuthenticateOidc @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListener.IAlbListenerDefaultActionAuthenticateOidc)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionFixedResponse\"}}]")]
        public virtual void PutFixedResponse(aws.AlbListener.IAlbListenerDefaultActionFixedResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListener.IAlbListenerDefaultActionFixedResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionForward\"}}]")]
        public virtual void PutForward(aws.AlbListener.IAlbListenerDefaultActionForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListener.IAlbListenerDefaultActionForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListener.AlbListenerDefaultActionRedirect\"}}]")]
        public virtual void PutRedirect(aws.AlbListener.IAlbListenerDefaultActionRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListener.IAlbListenerDefaultActionRedirect)}, new object[]{@value});
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

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionAuthenticateCognitoOutputReference\"}")]
        public virtual aws.AlbListener.AlbListenerDefaultActionAuthenticateCognitoOutputReference AuthenticateCognito
        {
            get => GetInstanceProperty<aws.AlbListener.AlbListenerDefaultActionAuthenticateCognitoOutputReference>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionAuthenticateOidcOutputReference\"}")]
        public virtual aws.AlbListener.AlbListenerDefaultActionAuthenticateOidcOutputReference AuthenticateOidc
        {
            get => GetInstanceProperty<aws.AlbListener.AlbListenerDefaultActionAuthenticateOidcOutputReference>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionFixedResponseOutputReference\"}")]
        public virtual aws.AlbListener.AlbListenerDefaultActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.AlbListener.AlbListenerDefaultActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionForwardOutputReference\"}")]
        public virtual aws.AlbListener.AlbListenerDefaultActionForwardOutputReference Forward
        {
            get => GetInstanceProperty<aws.AlbListener.AlbListenerDefaultActionForwardOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionRedirectOutputReference\"}")]
        public virtual aws.AlbListener.AlbListenerDefaultActionRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<aws.AlbListener.AlbListenerDefaultActionRedirectOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognitoInput", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
        public virtual aws.AlbListener.IAlbListenerDefaultActionAuthenticateCognito? AuthenticateCognitoInput
        {
            get => GetInstanceProperty<aws.AlbListener.IAlbListenerDefaultActionAuthenticateCognito?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidcInput", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionAuthenticateOidc\"}", isOptional: true)]
        public virtual aws.AlbListener.IAlbListenerDefaultActionAuthenticateOidc? AuthenticateOidcInput
        {
            get => GetInstanceProperty<aws.AlbListener.IAlbListenerDefaultActionAuthenticateOidc?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedResponseInput", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionFixedResponse\"}", isOptional: true)]
        public virtual aws.AlbListener.IAlbListenerDefaultActionFixedResponse? FixedResponseInput
        {
            get => GetInstanceProperty<aws.AlbListener.IAlbListenerDefaultActionFixedResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionForward\"}", isOptional: true)]
        public virtual aws.AlbListener.IAlbListenerDefaultActionForward? ForwardInput
        {
            get => GetInstanceProperty<aws.AlbListener.IAlbListenerDefaultActionForward?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"fqn\":\"aws.albListener.AlbListenerDefaultActionRedirect\"}", isOptional: true)]
        public virtual aws.AlbListener.IAlbListenerDefaultActionRedirect? RedirectInput
        {
            get => GetInstanceProperty<aws.AlbListener.IAlbListenerDefaultActionRedirect?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.albListener.AlbListenerDefaultAction\"}]}}", isOptional: true)]
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
                        case aws.AlbListener.IAlbListenerDefaultAction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListener.IAlbListenerDefaultAction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
