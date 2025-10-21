using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfig")]
    public class Wafv2WebAclDataProtectionConfig : aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfig
    {
        private object? _dataProtection;

        /// <summary>data_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#data_protection Wafv2WebAcl#data_protection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataProtection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclDataProtectionConfigDataProtection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataProtection
        {
            get => _dataProtection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtection[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclDataProtectionConfigDataProtection).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataProtection = value;
            }
        }
    }
}
