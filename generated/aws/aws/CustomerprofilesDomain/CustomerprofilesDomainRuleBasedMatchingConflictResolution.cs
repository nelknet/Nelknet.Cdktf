using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolution")]
    public class CustomerprofilesDomainRuleBasedMatchingConflictResolution : aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#conflict_resolving_model CustomerprofilesDomain#conflict_resolving_model}.</summary>
        [JsiiProperty(name: "conflictResolvingModel", typeJson: "{\"primitive\":\"string\"}")]
        public string ConflictResolvingModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#source_name CustomerprofilesDomain#source_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceName
        {
            get;
            set;
        }
    }
}
