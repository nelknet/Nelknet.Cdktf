using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.FrontdoorRulesEngine
{
    [JsiiClass(nativeType: typeof(azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineRuleActionOutputReference), fullyQualifiedName: "azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FrontdoorRulesEngineRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FrontdoorRulesEngineRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FrontdoorRulesEngineRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FrontdoorRulesEngineRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequestHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionRequestHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionRequestHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionRequestHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResponseHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeader\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResponseHeader(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionResponseHeader[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionResponseHeader).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleActionResponseHeader).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRequestHeader")]
        public virtual void ResetRequestHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseHeader")]
        public virtual void ResetResponseHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "requestHeader", typeJson: "{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeaderList\"}")]
        public virtual azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeaderList RequestHeader
        {
            get => GetInstanceProperty<azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeaderList>()!;
        }

        [JsiiProperty(name: "responseHeader", typeJson: "{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeaderList\"}")]
        public virtual azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeaderList ResponseHeader
        {
            get => GetInstanceProperty<azurerm.FrontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeaderList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionRequestHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseHeaderInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleActionResponseHeader\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResponseHeaderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.frontdoorRulesEngine.FrontdoorRulesEngineRuleAction\"}", isOptional: true)]
        public virtual azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction? InternalValue
        {
            get => GetInstanceProperty<azurerm.FrontdoorRulesEngine.IFrontdoorRulesEngineRuleAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
