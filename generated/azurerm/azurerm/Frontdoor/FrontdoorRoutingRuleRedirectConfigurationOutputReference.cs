using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiClass(nativeType: typeof(azurerm.Frontdoor.FrontdoorRoutingRuleRedirectConfigurationOutputReference), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FrontdoorRoutingRuleRedirectConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FrontdoorRoutingRuleRedirectConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FrontdoorRoutingRuleRedirectConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FrontdoorRoutingRuleRedirectConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomFragment")]
        public virtual void ResetCustomFragment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomHost")]
        public virtual void ResetCustomHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomPath")]
        public virtual void ResetCustomPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomQueryString")]
        public virtual void ResetCustomQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFragmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomFragmentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customHostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomHostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customQueryStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomQueryStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedirectProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedirectTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customFragment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomFragment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customHost", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomHost
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customQueryString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomQueryString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfiguration\"}", isOptional: true)]
        public virtual azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
