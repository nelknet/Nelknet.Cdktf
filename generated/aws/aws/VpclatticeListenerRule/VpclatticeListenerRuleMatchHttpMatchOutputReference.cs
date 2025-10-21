using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiClass(nativeType: typeof(aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchOutputReference), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpclatticeListenerRuleMatchHttpMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpclatticeListenerRuleMatchHttpMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpclatticeListenerRuleMatchHttpMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpclatticeListenerRuleMatchHttpMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHeaderMatches", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatches\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHeaderMatches(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchHeaderMatches[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchHeaderMatches).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchHeaderMatches).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPathMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch\"}}]")]
        public virtual void PutPathMatch(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaderMatches")]
        public virtual void ResetHeaderMatches()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMethod")]
        public virtual void ResetMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathMatch")]
        public virtual void ResetPathMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "headerMatches", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatchesList\"}")]
        public virtual aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatchesList HeaderMatches
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatchesList>()!;
        }

        [JsiiProperty(name: "pathMatch", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatchOutputReference\"}")]
        public virtual aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatchOutputReference PathMatch
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerMatchesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchHeaderMatches\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HeaderMatchesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathMatchInput", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatchPathMatch\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch? PathMatchInput
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatchPathMatch?>();
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpclatticeListenerRule.VpclatticeListenerRuleMatchHttpMatch\"}", isOptional: true)]
        public virtual aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch? InternalValue
        {
            get => GetInstanceProperty<aws.VpclatticeListenerRule.IVpclatticeListenerRuleMatchHttpMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
