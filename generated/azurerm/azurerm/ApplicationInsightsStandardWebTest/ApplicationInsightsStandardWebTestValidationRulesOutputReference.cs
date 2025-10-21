using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationInsightsStandardWebTest
{
    [JsiiClass(nativeType: typeof(azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesOutputReference), fullyQualifiedName: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApplicationInsightsStandardWebTestValidationRulesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApplicationInsightsStandardWebTestValidationRulesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApplicationInsightsStandardWebTestValidationRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApplicationInsightsStandardWebTestValidationRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContent\"}}]")]
        public virtual void PutContent(azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContent")]
        public virtual void ResetContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpectedStatusCode")]
        public virtual void ResetExpectedStatusCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslCertRemainingLifetime")]
        public virtual void ResetSslCertRemainingLifetime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslCheckEnabled")]
        public virtual void ResetSslCheckEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContentOutputReference\"}")]
        public virtual azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContentOutputReference Content
        {
            get => GetInstanceProperty<azurerm.ApplicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContentOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentInput", typeJson: "{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContent\"}", isOptional: true)]
        public virtual azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent? ContentInput
        {
            get => GetInstanceProperty<azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expectedStatusCodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpectedStatusCodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslCertRemainingLifetimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SslCertRemainingLifetimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslCheckEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SslCheckEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "expectedStatusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpectedStatusCode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslCertRemainingLifetime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SslCertRemainingLifetime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SslCheckEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRules\"}", isOptional: true)]
        public virtual azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRules? InternalValue
        {
            get => GetInstanceProperty<azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
