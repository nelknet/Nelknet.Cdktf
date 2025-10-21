using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    [JsiiByValue(fqn: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinition")]
    public class VerifiedpermissionsPolicyDefinition : aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinition
    {
        private object? _static;

        /// <summary>static block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#static VerifiedpermissionsPolicy#static}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "static", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionStatic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Static
        {
            get => _static;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionStatic[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionStatic).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _static = value;
            }
        }

        private object? _templateLinked;

        /// <summary>template_linked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#template_linked VerifiedpermissionsPolicy#template_linked}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "templateLinked", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinked\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TemplateLinked
        {
            get => _templateLinked;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinked[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinked).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _templateLinked = value;
            }
        }
    }
}
