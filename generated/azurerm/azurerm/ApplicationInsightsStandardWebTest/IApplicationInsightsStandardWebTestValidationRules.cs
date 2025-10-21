using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationInsightsStandardWebTest
{
    [JsiiInterface(nativeType: typeof(IApplicationInsightsStandardWebTestValidationRules), fullyQualifiedName: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRules")]
    public interface IApplicationInsightsStandardWebTestValidationRules
    {
        /// <summary>content block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#content ApplicationInsightsStandardWebTest#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContent\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent? Content
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#expected_status_code ApplicationInsightsStandardWebTest#expected_status_code}.</summary>
        [JsiiProperty(name: "expectedStatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpectedStatusCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#ssl_cert_remaining_lifetime ApplicationInsightsStandardWebTest#ssl_cert_remaining_lifetime}.</summary>
        [JsiiProperty(name: "sslCertRemainingLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SslCertRemainingLifetime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#ssl_check_enabled ApplicationInsightsStandardWebTest#ssl_check_enabled}.</summary>
        [JsiiProperty(name: "sslCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslCheckEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationInsightsStandardWebTestValidationRules), fullyQualifiedName: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRules")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#content ApplicationInsightsStandardWebTest#content}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContent\"}", isOptional: true)]
            public azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent? Content
            {
                get => GetInstanceProperty<azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#expected_status_code ApplicationInsightsStandardWebTest#expected_status_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expectedStatusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpectedStatusCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#ssl_cert_remaining_lifetime ApplicationInsightsStandardWebTest#ssl_cert_remaining_lifetime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslCertRemainingLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SslCertRemainingLifetime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#ssl_check_enabled ApplicationInsightsStandardWebTest#ssl_check_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SslCheckEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
