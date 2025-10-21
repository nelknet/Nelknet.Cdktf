using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafWebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFields")]
    public class WafWebAclLoggingConfigurationRedactedFields : aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFields
    {
        private object _fieldToMatch;

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#field_to_match WafWebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafWebAcl.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
        public object FieldToMatch
        {
            get => _fieldToMatch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WafWebAcl.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldToMatch = value;
            }
        }
    }
}
