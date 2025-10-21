using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WafregionalWebAcl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFields")]
    public class WafregionalWebAclLoggingConfigurationRedactedFields : aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFields
    {
        private object _fieldToMatch;

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#field_to_match WafregionalWebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafregionalWebAcl.WafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}]}}")]
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
                        case aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.WafregionalWebAcl.IWafregionalWebAclLoggingConfigurationRedactedFieldsFieldToMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fieldToMatch = value;
            }
        }
    }
}
