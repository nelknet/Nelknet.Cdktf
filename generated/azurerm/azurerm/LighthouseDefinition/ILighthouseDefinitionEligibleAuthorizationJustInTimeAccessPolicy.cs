using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LighthouseDefinition
{
    [JsiiInterface(nativeType: typeof(ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy), fullyQualifiedName: "azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy")]
    public interface ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy
    {
        /// <summary>approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#approver LighthouseDefinition#approver}
        /// </remarks>
        [JsiiProperty(name: "approver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Approver
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#maximum_activation_duration LighthouseDefinition#maximum_activation_duration}.</summary>
        [JsiiProperty(name: "maximumActivationDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumActivationDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#multi_factor_auth_provider LighthouseDefinition#multi_factor_auth_provider}.</summary>
        [JsiiProperty(name: "multiFactorAuthProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MultiFactorAuthProvider
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy), fullyQualifiedName: "azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.LighthouseDefinition.ILighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>approver block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#approver LighthouseDefinition#approver}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approver", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.lighthouseDefinition.LighthouseDefinitionEligibleAuthorizationJustInTimeAccessPolicyApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Approver
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#maximum_activation_duration LighthouseDefinition#maximum_activation_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumActivationDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumActivationDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lighthouse_definition#multi_factor_auth_provider LighthouseDefinition#multi_factor_auth_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multiFactorAuthProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MultiFactorAuthProvider
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
