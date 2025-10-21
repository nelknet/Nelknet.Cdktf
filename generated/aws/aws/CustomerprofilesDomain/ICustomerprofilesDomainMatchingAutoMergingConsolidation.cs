using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiInterface(nativeType: typeof(ICustomerprofilesDomainMatchingAutoMergingConsolidation), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation")]
    public interface ICustomerprofilesDomainMatchingAutoMergingConsolidation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching_attributes_list CustomerprofilesDomain#matching_attributes_list}.</summary>
        [JsiiProperty(name: "matchingAttributesList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
        object MatchingAttributesList
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerprofilesDomainMatchingAutoMergingConsolidation), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation")]
        internal sealed class _Proxy : DeputyBase, aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching_attributes_list CustomerprofilesDomain#matching_attributes_list}.</summary>
            [JsiiProperty(name: "matchingAttributesList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"array\"}}]}}")]
            public object MatchingAttributesList
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
