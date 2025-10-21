using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsPolicyDefinition), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinition")]
    public interface IVerifiedpermissionsPolicyDefinition
    {
        /// <summary>static block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#static VerifiedpermissionsPolicy#static}
        /// </remarks>
        [JsiiProperty(name: "static", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionStatic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Static
        {
            get
            {
                return null;
            }
        }

        /// <summary>template_linked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#template_linked VerifiedpermissionsPolicy#template_linked}
        /// </remarks>
        [JsiiProperty(name: "templateLinked", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinked\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TemplateLinked
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsPolicyDefinition), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>static block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#static VerifiedpermissionsPolicy#static}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "static", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionStatic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Static
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>template_linked block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#template_linked VerifiedpermissionsPolicy#template_linked}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "templateLinked", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinked\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TemplateLinked
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
