using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinked")]
    public class VerifiedpermissionsPolicyDefinitionTemplateLinked : aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinked
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#policy_template_id VerifiedpermissionsPolicy#policy_template_id}.</summary>
        [JsiiProperty(name: "policyTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        public string PolicyTemplateId
        {
            get;
            set;
        }

        private object? _principal;

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#principal VerifiedpermissionsPolicy#principal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Principal
        {
            get => _principal;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principal = value;
            }
        }

        private object? _resource;

        /// <summary>resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#resource VerifiedpermissionsPolicy#resource}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Resource
        {
            get => _resource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedResource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedResource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resource = value;
            }
        }
    }
}
