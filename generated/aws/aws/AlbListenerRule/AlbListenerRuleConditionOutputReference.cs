using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbListenerRule
{
    [JsiiClass(nativeType: typeof(aws.AlbListenerRule.AlbListenerRuleConditionOutputReference), fullyQualifiedName: "aws.albListenerRule.AlbListenerRuleConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbListenerRuleConditionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbListenerRuleConditionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbListenerRuleConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHostHeader\"}}]")]
        public virtual void PutHostHeader(aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpHeader\"}}]")]
        public virtual void PutHttpHeader(aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRequestMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpRequestMethod\"}}]")]
        public virtual void PutHttpRequestMethod(aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPathPattern", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionPathPattern\"}}]")]
        public virtual void PutPathPattern(aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryString(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.AlbListenerRule.IAlbListenerRuleConditionQueryString[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleConditionQueryString).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleConditionQueryString).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceIp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionSourceIp\"}}]")]
        public virtual void PutSourceIp(aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp)}, new object[]{@value});
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

        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHostHeaderOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleConditionHostHeaderOutputReference HostHeader
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleConditionHostHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpHeaderOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleConditionHttpHeaderOutputReference HttpHeader
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleConditionHttpHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpRequestMethodOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleConditionHttpRequestMethodOutputReference HttpRequestMethod
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleConditionHttpRequestMethodOutputReference>()!;
        }

        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionPathPatternOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleConditionPathPatternOutputReference PathPattern
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleConditionPathPatternOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionQueryStringList\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleConditionQueryStringList QueryString
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleConditionQueryStringList>()!;
        }

        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionSourceIpOutputReference\"}")]
        public virtual aws.AlbListenerRule.AlbListenerRuleConditionSourceIpOutputReference SourceIp
        {
            get => GetInstanceProperty<aws.AlbListenerRule.AlbListenerRuleConditionSourceIpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostHeaderInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader? HostHeaderInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionHostHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpHeaderInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader? HttpHeaderInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionHttpHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRequestMethodInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethodInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionHttpRequestMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathPatternInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern? PathPatternInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionPathPattern?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIpInput", typeJson: "{\"fqn\":\"aws.albListenerRule.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
        public virtual aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp? SourceIpInput
        {
            get => GetInstanceProperty<aws.AlbListenerRule.IAlbListenerRuleConditionSourceIp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.albListenerRule.AlbListenerRuleCondition\"}]}}", isOptional: true)]
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
                        case aws.AlbListenerRule.IAlbListenerRuleCondition cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AlbListenerRule.IAlbListenerRuleCondition).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
