using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionOutputReference), fullyQualifiedName: "aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLbListenerRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLbListenerRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsLbListenerRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putForward", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"}}]")]
        public virtual void PutForward(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleActionForward)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetForward")]
        public virtual void ResetForward()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateCognitoOutputReference\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateCognitoOutputReference AuthenticateCognito
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateCognitoOutputReference>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateOidcOutputReference\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateOidcOutputReference AuthenticateOidc
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionAuthenticateOidcOutputReference>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionFixedResponseOutputReference\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionFixedResponseOutputReference FixedResponse
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionFixedResponseOutputReference>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardOutputReference\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardOutputReference Forward
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionForwardOutputReference>()!;
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionRedirectOutputReference\"}")]
        public virtual aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<aws.DataAwsLbListenerRule.DataAwsLbListenerRuleActionRedirectOutputReference>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleActionForward\"}]}}", isOptional: true)]
        public virtual object? ForwardInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dataAwsLbListenerRule.DataAwsLbListenerRuleAction\"}]}}", isOptional: true)]
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
                        case aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleAction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsLbListenerRule.IDataAwsLbListenerRuleAction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
