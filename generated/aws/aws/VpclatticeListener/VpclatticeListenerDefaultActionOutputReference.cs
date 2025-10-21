using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiClass(nativeType: typeof(aws.VpclatticeListener.VpclatticeListenerDefaultActionOutputReference), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpclatticeListenerDefaultActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpclatticeListenerDefaultActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpclatticeListenerDefaultActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeListenerDefaultActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFixedResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse\"}}]")]
        public virtual void PutFixedResponse(aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForward\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutForward(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponseOutputReference\"}")]
        public virtual aws.VpclatticeListener.VpclatticeListenerDefaultActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.VpclatticeListener.VpclatticeListenerDefaultActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardList\"}")]
        public virtual aws.VpclatticeListener.VpclatticeListenerDefaultActionForwardList Forward
        {
            get => GetInstanceProperty<aws.VpclatticeListener.VpclatticeListenerDefaultActionForwardList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedResponseInput", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse\"}", isOptional: true)]
        public virtual aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse? FixedResponseInput
        {
            get => GetInstanceProperty<aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ForwardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultAction\"}", isOptional: true)]
        public virtual aws.VpclatticeListener.IVpclatticeListenerDefaultAction? InternalValue
        {
            get => GetInstanceProperty<aws.VpclatticeListener.IVpclatticeListenerDefaultAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
