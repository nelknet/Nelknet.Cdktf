using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorRuleConditionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorRuleConditionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorRuleConditionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorRuleConditionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientPortCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientPortCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPortCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPortCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsClientPortCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookiesCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCookiesCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsCookiesCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsCookiesCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsCookiesCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostNameCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHostNameCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostNameCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostNameCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHostNameCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpVersionCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpVersionCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersionCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersionCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsHttpVersionCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIsDeviceCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIsDeviceCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsIsDeviceCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsIsDeviceCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsIsDeviceCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostArgsCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPostArgsCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgsCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgsCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsPostArgsCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryStringCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryStringCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryStringCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryStringCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsQueryStringCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoteAddressCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRemoteAddressCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddressCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddressCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRemoteAddressCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestBodyCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestBodyCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBodyCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBodyCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestBodyCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestHeaderCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestHeaderCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeaderCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeaderCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestHeaderCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestMethodCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestMethodCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethodCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethodCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestMethodCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestSchemeCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestSchemeCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestSchemeCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestSchemeCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestSchemeCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestUriCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestUriCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUriCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUriCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsRequestUriCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerPortCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutServerPortCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPortCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPortCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsServerPortCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSocketAddressCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSocketAddressCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddressCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddressCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSocketAddressCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSslProtocolCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSslProtocolCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocolCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocolCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsSslProtocolCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlFileExtensionCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUrlFileExtensionCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFileExtensionCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFileExtensionCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFileExtensionCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlFilenameCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUrlFilenameCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFilenameCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFilenameCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlFilenameCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlPathCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUrlPathCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlPathCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlPathCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditionsUrlPathCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientPortCondition")]
        public virtual void ResetClientPortCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCookiesCondition")]
        public virtual void ResetCookiesCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostNameCondition")]
        public virtual void ResetHostNameCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpVersionCondition")]
        public virtual void ResetHttpVersionCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDeviceCondition")]
        public virtual void ResetIsDeviceCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostArgsCondition")]
        public virtual void ResetPostArgsCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryStringCondition")]
        public virtual void ResetQueryStringCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteAddressCondition")]
        public virtual void ResetRemoteAddressCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestBodyCondition")]
        public virtual void ResetRequestBodyCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestHeaderCondition")]
        public virtual void ResetRequestHeaderCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestMethodCondition")]
        public virtual void ResetRequestMethodCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestSchemeCondition")]
        public virtual void ResetRequestSchemeCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequestUriCondition")]
        public virtual void ResetRequestUriCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerPortCondition")]
        public virtual void ResetServerPortCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSocketAddressCondition")]
        public virtual void ResetSocketAddressCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslProtocolCondition")]
        public virtual void ResetSslProtocolCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlFileExtensionCondition")]
        public virtual void ResetUrlFileExtensionCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlFilenameCondition")]
        public virtual void ResetUrlFilenameCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlPathCondition")]
        public virtual void ResetUrlPathCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientPortCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortConditionList ClientPortCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortConditionList>()!;
        }

        [JsiiProperty(name: "cookiesCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesConditionList CookiesCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesConditionList>()!;
        }

        [JsiiProperty(name: "hostNameCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameConditionList HostNameCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameConditionList>()!;
        }

        [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionConditionList HttpVersionCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionConditionList>()!;
        }

        [JsiiProperty(name: "isDeviceCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceConditionList IsDeviceCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceConditionList>()!;
        }

        [JsiiProperty(name: "postArgsCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsConditionList PostArgsCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsConditionList>()!;
        }

        [JsiiProperty(name: "queryStringCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringConditionList QueryStringCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringConditionList>()!;
        }

        [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressConditionList RemoteAddressCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressConditionList>()!;
        }

        [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyConditionList RequestBodyCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyConditionList>()!;
        }

        [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderConditionList RequestHeaderCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderConditionList>()!;
        }

        [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodConditionList RequestMethodCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodConditionList>()!;
        }

        [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeConditionList RequestSchemeCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeConditionList>()!;
        }

        [JsiiProperty(name: "requestUriCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriConditionList RequestUriCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriConditionList>()!;
        }

        [JsiiProperty(name: "serverPortCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortConditionList ServerPortCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortConditionList>()!;
        }

        [JsiiProperty(name: "socketAddressCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressConditionList SocketAddressCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressConditionList>()!;
        }

        [JsiiProperty(name: "sslProtocolCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolConditionList SslProtocolCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolConditionList>()!;
        }

        [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionConditionList UrlFileExtensionCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionConditionList>()!;
        }

        [JsiiProperty(name: "urlFilenameCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameConditionList UrlFilenameCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameConditionList>()!;
        }

        [JsiiProperty(name: "urlPathCondition", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathConditionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathConditionList UrlPathCondition
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathConditionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientPortConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsClientPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientPortConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CookiesConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostNameConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHostNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostNameConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpVersionConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpVersionConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDeviceConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsIsDeviceCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IsDeviceConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postArgsConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsPostArgsCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PostArgsConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteAddressConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RemoteAddressConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestBodyConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestBodyConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestHeaderConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestMethodConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestMethodCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestMethodConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestSchemeConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestSchemeCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestSchemeConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestUriConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestUriConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverPortConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsServerPortCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServerPortConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "socketAddressConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSocketAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SocketAddressConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslProtocolConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsSslProtocolCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SslProtocolConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlFileExtensionConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UrlFileExtensionConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlFilenameConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlFilenameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UrlFilenameConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlPathConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UrlPathConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions?>();
            set => SetInstanceProperty(value);
        }
    }
}
