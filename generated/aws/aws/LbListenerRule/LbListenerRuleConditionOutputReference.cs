using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.LbListenerRule.LbListenerRuleConditionOutputReference), fullyQualifiedName: "aws.lbListenerRule.LbListenerRuleConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbListenerRuleConditionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbListenerRuleConditionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbListenerRuleConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHostHeader\"}}]")]
        public virtual void PutHostHeader(aws.LbListenerRule.ILbListenerRuleConditionHostHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleConditionHostHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpHeader\"}}]")]
        public virtual void PutHttpHeader(aws.LbListenerRule.ILbListenerRuleConditionHttpHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleConditionHttpHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRequestMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpRequestMethod\"}}]")]
        public virtual void PutHttpRequestMethod(aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPathPattern", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionPathPattern\"}}]")]
        public virtual void PutPathPattern(aws.LbListenerRule.ILbListenerRuleConditionPathPattern @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleConditionPathPattern)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LbListenerRule.ILbListenerRuleConditionQueryString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListenerRule.ILbListenerRuleConditionQueryString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListenerRule.ILbListenerRuleConditionQueryString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionSourceIp\"}}]")]
        public virtual void PutSourceIp(aws.LbListenerRule.ILbListenerRuleConditionSourceIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LbListenerRule.ILbListenerRuleConditionSourceIp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostHeader")]
        public virtual void ResetHostHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpHeader")]
        public virtual void ResetHttpHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRequestMethod")]
        public virtual void ResetHttpRequestMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathPattern")]
        public virtual void ResetPathPattern()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceIp")]
        public virtual void ResetSourceIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHostHeaderOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleConditionHostHeaderOutputReference HostHeader
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleConditionHostHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpHeaderOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleConditionHttpHeaderOutputReference HttpHeader
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleConditionHttpHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpRequestMethodOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleConditionHttpRequestMethodOutputReference HttpRequestMethod
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleConditionHttpRequestMethodOutputReference>()!;
        }

        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionPathPatternOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleConditionPathPatternOutputReference PathPattern
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleConditionPathPatternOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionQueryStringList\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleConditionQueryStringList QueryString
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleConditionQueryStringList>()!;
        }

        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionSourceIpOutputReference\"}")]
        public virtual aws.LbListenerRule.LbListenerRuleConditionSourceIpOutputReference SourceIp
        {
            get => GetInstanceProperty<aws.LbListenerRule.LbListenerRuleConditionSourceIpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHostHeader\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleConditionHostHeader? HostHeaderInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionHostHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpHeaderInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleConditionHttpHeader? HttpHeaderInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionHttpHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethodInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod? HttpRequestMethodInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionHttpRequestMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathPatternInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionPathPattern\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleConditionPathPattern? PathPatternInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionPathPattern?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIpInput", typeJson: "{\"fqn\":\"aws.lbListenerRule.LbListenerRuleConditionSourceIp\"}", isOptional: true)]
        public virtual aws.LbListenerRule.ILbListenerRuleConditionSourceIp? SourceIpInput
        {
            get => GetInstanceProperty<aws.LbListenerRule.ILbListenerRuleConditionSourceIp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lbListenerRule.LbListenerRuleCondition\"}]}}", isOptional: true)]
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
                        case aws.LbListenerRule.ILbListenerRuleCondition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LbListenerRule.ILbListenerRuleCondition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
