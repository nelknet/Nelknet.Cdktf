using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation")]
    public class CustomerprofilesDomainMatchingAutoMergingConsolidation : aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation
    {
        private object _matchingAttributesList;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching_attributes_list CustomerprofilesDomain#matching_attributes_list}.</summary>
        [JsiiProperty(name: "matchingAttributesList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
        public object MatchingAttributesList
        {
            get => _matchingAttributesList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case string[][] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, string[][]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, string[][]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchingAttributesList = value;
            }
        }
    }
}
