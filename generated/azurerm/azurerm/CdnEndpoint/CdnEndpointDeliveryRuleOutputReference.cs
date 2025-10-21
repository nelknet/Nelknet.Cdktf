using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiClass(nativeType: typeof(azurerm.CdnEndpoint.CdnEndpointDeliveryRuleOutputReference), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointDeliveryRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CdnEndpointDeliveryRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CdnEndpointDeliveryRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CdnEndpointDeliveryRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnEndpointDeliveryRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCacheExpirationAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationAction\"}}]")]
        public virtual void PutCacheExpirationAction(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCacheKeyQueryStringAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringAction\"}}]")]
        public virtual void PutCacheKeyQueryStringAction(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookiesCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCookiesCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCookiesCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCookiesCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCookiesCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCookiesCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeviceCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleDeviceCondition\"}}]")]
        public virtual void PutDeviceCondition(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpVersionCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleHttpVersionCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpVersionCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleHttpVersionCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleHttpVersionCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleHttpVersionCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModifyRequestHeaderAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModifyRequestHeaderAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyRequestHeaderAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyRequestHeaderAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyRequestHeaderAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModifyResponseHeaderAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModifyResponseHeaderAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyResponseHeaderAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyResponseHeaderAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleModifyResponseHeaderAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostArgCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRulePostArgCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPostArgCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRulePostArgCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRulePostArgCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRulePostArgCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryStringCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleQueryStringCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutQueryStringCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleQueryStringCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleQueryStringCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleQueryStringCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRemoteAddressCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRemoteAddressCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRemoteAddressCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRemoteAddressCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRemoteAddressCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestBodyCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestBodyCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestBodyCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestBodyCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestBodyCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestBodyCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestHeaderCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestHeaderCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestHeaderCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestHeaderCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestHeaderCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestMethodCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestMethodCondition\"}}]")]
        public virtual void PutRequestMethodCondition(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestSchemeCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeCondition\"}}]")]
        public virtual void PutRequestSchemeCondition(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequestUriCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestUriCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestUriCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestUriCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestUriCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestUriCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlFileExtensionCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUrlFileExtensionCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileExtensionCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileExtensionCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileExtensionCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlFileNameCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUrlFileNameCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileNameCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileNameCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlFileNameCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlPathCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlPathCondition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUrlPathCondition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlPathCondition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlPathCondition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlPathCondition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRedirectAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectAction\"}}]")]
        public virtual void PutUrlRedirectAction(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRewriteAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteAction\"}}]")]
        public virtual void PutUrlRewriteAction(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCacheExpirationAction")]
        public virtual void ResetCacheExpirationAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCacheKeyQueryStringAction")]
        public virtual void ResetCacheKeyQueryStringAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCookiesCondition")]
        public virtual void ResetCookiesCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceCondition")]
        public virtual void ResetDeviceCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpVersionCondition")]
        public virtual void ResetHttpVersionCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModifyRequestHeaderAction")]
        public virtual void ResetModifyRequestHeaderAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModifyResponseHeaderAction")]
        public virtual void ResetModifyResponseHeaderAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostArgCondition")]
        public virtual void ResetPostArgCondition()
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

        [JsiiMethod(name: "resetUrlFileExtensionCondition")]
        public virtual void ResetUrlFileExtensionCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlFileNameCondition")]
        public virtual void ResetUrlFileNameCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlPathCondition")]
        public virtual void ResetUrlPathCondition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlRedirectAction")]
        public virtual void ResetUrlRedirectAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrlRewriteAction")]
        public virtual void ResetUrlRewriteAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationActionOutputReference CacheExpirationAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationActionOutputReference>()!;
        }

        [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringActionOutputReference CacheKeyQueryStringAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringActionOutputReference>()!;
        }

        [JsiiProperty(name: "cookiesCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCookiesConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleCookiesConditionList CookiesCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleCookiesConditionList>()!;
        }

        [JsiiProperty(name: "deviceCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleDeviceConditionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleDeviceConditionOutputReference DeviceCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleDeviceConditionOutputReference>()!;
        }

        [JsiiProperty(name: "httpVersionCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleHttpVersionConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleHttpVersionConditionList HttpVersionCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleHttpVersionConditionList>()!;
        }

        [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderActionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderActionList ModifyRequestHeaderAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderActionList>()!;
        }

        [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderActionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderActionList ModifyResponseHeaderAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderActionList>()!;
        }

        [JsiiProperty(name: "postArgCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRulePostArgConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRulePostArgConditionList PostArgCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRulePostArgConditionList>()!;
        }

        [JsiiProperty(name: "queryStringCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleQueryStringConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleQueryStringConditionList QueryStringCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleQueryStringConditionList>()!;
        }

        [JsiiProperty(name: "remoteAddressCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressConditionList RemoteAddressCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressConditionList>()!;
        }

        [JsiiProperty(name: "requestBodyCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestBodyConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestBodyConditionList RequestBodyCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestBodyConditionList>()!;
        }

        [JsiiProperty(name: "requestHeaderCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderConditionList RequestHeaderCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderConditionList>()!;
        }

        [JsiiProperty(name: "requestMethodCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestMethodConditionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestMethodConditionOutputReference RequestMethodCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestMethodConditionOutputReference>()!;
        }

        [JsiiProperty(name: "requestSchemeCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeConditionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeConditionOutputReference RequestSchemeCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeConditionOutputReference>()!;
        }

        [JsiiProperty(name: "requestUriCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestUriConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestUriConditionList RequestUriCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleRequestUriConditionList>()!;
        }

        [JsiiProperty(name: "urlFileExtensionCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionConditionList UrlFileExtensionCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionConditionList>()!;
        }

        [JsiiProperty(name: "urlFileNameCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameConditionList UrlFileNameCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameConditionList>()!;
        }

        [JsiiProperty(name: "urlPathCondition", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlPathConditionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlPathConditionList UrlPathCondition
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlPathConditionList>()!;
        }

        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectActionOutputReference UrlRedirectAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectActionOutputReference>()!;
        }

        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteActionOutputReference UrlRewriteAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheExpirationActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction? CacheExpirationActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheExpirationAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyQueryStringActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleCacheKeyQueryStringAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleCookiesCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CookiesConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceConditionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleDeviceCondition\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition? DeviceConditionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleDeviceCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpVersionConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleHttpVersionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpVersionConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifyRequestHeaderActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModifyRequestHeaderActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifyResponseHeaderActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModifyResponseHeaderActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postArgConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRulePostArgCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PostArgConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleQueryStringCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? QueryStringConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteAddressConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRemoteAddressCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RemoteAddressConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestBodyConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestBodyCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestBodyConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestHeaderCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestHeaderConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestMethodConditionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestMethodCondition\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition? RequestMethodConditionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestMethodCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestSchemeConditionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestSchemeCondition\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition? RequestSchemeConditionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleRequestSchemeCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestUriConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleRequestUriCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestUriConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlFileExtensionConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileExtensionCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UrlFileExtensionConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlFileNameConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlFileNameCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UrlFileNameConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlPathConditionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlPathCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UrlPathConditionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction? UrlRedirectActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRedirectAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction? UrlRewriteActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointDeliveryRuleUrlRewriteAction?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointDeliveryRule\"}]}}", isOptional: true)]
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
                        case azurerm.CdnEndpoint.ICdnEndpointDeliveryRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointDeliveryRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
