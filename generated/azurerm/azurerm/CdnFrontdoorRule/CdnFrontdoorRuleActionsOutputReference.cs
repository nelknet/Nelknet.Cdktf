using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorRuleActionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorRuleActionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorRuleActionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorRuleActionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequestHeaderAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRequestHeaderAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRequestHeaderAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRequestHeaderAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRequestHeaderAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRequestHeaderAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResponseHeaderAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsResponseHeaderAction\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResponseHeaderAction(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsResponseHeaderAction[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsResponseHeaderAction).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsResponseHeaderAction).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRouteConfigurationOverrideAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideAction\"}}]")]
        public virtual void PutRouteConfigurationOverrideAction(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRedirectAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectAction\"}}]")]
        public virtual void PutUrlRedirectAction(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrlRewriteAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewriteAction\"}}]")]
        public virtual void PutUrlRewriteAction(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewriteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewriteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRequestHeaderAction")]
        public virtual void ResetRequestHeaderAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseHeaderAction")]
        public virtual void ResetResponseHeaderAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteConfigurationOverrideAction")]
        public virtual void ResetRouteConfigurationOverrideAction()
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

        [JsiiProperty(name: "requestHeaderAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRequestHeaderActionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsRequestHeaderActionList RequestHeaderAction
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsRequestHeaderActionList>()!;
        }

        [JsiiProperty(name: "responseHeaderAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsResponseHeaderActionList\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsResponseHeaderActionList ResponseHeaderAction
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsResponseHeaderActionList>()!;
        }

        [JsiiProperty(name: "routeConfigurationOverrideAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideActionOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideActionOutputReference RouteConfigurationOverrideAction
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideActionOutputReference>()!;
        }

        [JsiiProperty(name: "urlRedirectAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectActionOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectActionOutputReference UrlRedirectAction
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectActionOutputReference>()!;
        }

        [JsiiProperty(name: "urlRewriteAction", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewriteActionOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewriteActionOutputReference UrlRewriteAction
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewriteActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRequestHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RequestHeaderActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseHeaderActionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsResponseHeaderAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResponseHeaderActionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeConfigurationOverrideActionInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsRouteConfigurationOverrideAction\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideAction? RouteConfigurationOverrideActionInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsRouteConfigurationOverrideAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRedirectActionInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectAction\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction? UrlRedirectActionInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlRewriteActionInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRewriteAction\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewriteAction? UrlRewriteActionInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRewriteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions?>();
            set => SetInstanceProperty(value);
        }
    }
}
