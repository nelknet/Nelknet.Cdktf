using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfig")]
    public class Wafv2WebAclAssociationConfig : aws.Wafv2WebAcl.IWafv2WebAclAssociationConfig
    {
        private object? _requestBody;

        /// <summary>request_body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#request_body Wafv2WebAcl#request_body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestBody", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestBody
        {
            get => _requestBody;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBody[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBody).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestBody = value;
            }
        }
    }
}
