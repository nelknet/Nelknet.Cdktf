using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfig")]
    public class CustomerprofilesDomainRuleBasedMatchingExportingConfig : aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig
    {
        /// <summary>s3_exporting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#s3_exporting CustomerprofilesDomain#s3_exporting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Exporting", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfigS3Exporting\"}", isOptional: true)]
        public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfigS3Exporting? S3Exporting
        {
            get;
            set;
        }
    }
}
