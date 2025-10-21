using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiClass(nativeType: typeof(azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleOutputReference), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnEndpointGlobalDeliveryRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnEndpointGlobalDeliveryRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnEndpointGlobalDeliveryRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnEndpointGlobalDeliveryRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCacheExpirationAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction\"}}]")]
        public virtual void PutCacheExpirationAction(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCacheKeyQueryStringAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction\"}}]")]
        public virtual void PutCacheKeyQueryStringAction(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModifyRequestHeaderAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModifyRequestHeaderAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModifyResponseHeaderAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutModifyResponseHeaderAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRedirectAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectAction\"}}]")]
        public virtual void PutUrlRedirectAction(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRewriteAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction\"}}]")]
        public virtual void PutUrlRewriteAction(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction)}, new object[]{@value});
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

        [JsiiProperty(name: "cacheExpirationAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationActionOutputReference CacheExpirationAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationActionOutputReference>()!;
        }

        [JsiiProperty(name: "cacheKeyQueryStringAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringActionOutputReference CacheKeyQueryStringAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringActionOutputReference>()!;
        }

        [JsiiProperty(name: "modifyRequestHeaderAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderActionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderActionList ModifyRequestHeaderAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderActionList>()!;
        }

        [JsiiProperty(name: "modifyResponseHeaderAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderActionList\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderActionList ModifyResponseHeaderAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderActionList>()!;
        }

        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectActionOutputReference UrlRedirectAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectActionOutputReference>()!;
        }

        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteActionOutputReference\"}")]
        public virtual azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteActionOutputReference UrlRewriteAction
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheExpirationActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheExpirationAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction? CacheExpirationActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheExpirationAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyQueryStringActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction? CacheKeyQueryStringActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleCacheKeyQueryStringAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifyRequestHeaderActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModifyRequestHeaderActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modifyResponseHeaderActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleModifyResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ModifyResponseHeaderActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRedirectAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction? UrlRedirectActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRedirectAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteActionInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRuleUrlRewriteAction\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction? UrlRewriteActionInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRuleUrlRewriteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnEndpoint.CdnEndpointGlobalDeliveryRule\"}", isOptional: true)]
        public virtual azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRule? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnEndpoint.ICdnEndpointGlobalDeliveryRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
