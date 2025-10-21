using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationInsightsStandardWebTest
{
    [JsiiInterface(nativeType: typeof(IApplicationInsightsStandardWebTestValidationRulesContent), fullyQualifiedName: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContent")]
    public interface IApplicationInsightsStandardWebTestValidationRulesContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#content_match ApplicationInsightsStandardWebTest#content_match}.</summary>
        [JsiiProperty(name: "contentMatch", typeJson: "{\"primitive\":\"string\"}")]
        string ContentMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#ignore_case ApplicationInsightsStandardWebTest#ignore_case}.</summary>
        [JsiiProperty(name: "ignoreCase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IgnoreCase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#pass_if_text_found ApplicationInsightsStandardWebTest#pass_if_text_found}.</summary>
        [JsiiProperty(name: "passIfTextFound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PassIfTextFound
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationInsightsStandardWebTestValidationRulesContent), fullyQualifiedName: "azurerm.applicationInsightsStandardWebTest.ApplicationInsightsStandardWebTestValidationRulesContent")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationInsightsStandardWebTest.IApplicationInsightsStandardWebTestValidationRulesContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#content_match ApplicationInsightsStandardWebTest#content_match}.</summary>
            [JsiiProperty(name: "contentMatch", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentMatch
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#ignore_case ApplicationInsightsStandardWebTest#ignore_case}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreCase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IgnoreCase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_insights_standard_web_test#pass_if_text_found ApplicationInsightsStandardWebTest#pass_if_text_found}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passIfTextFound", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PassIfTextFound
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
