using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig")]
    public class CustomerprofilesDomainMatchingExportingConfig : aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig
    {
        /// <summary>s3_exporting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#s3_exporting CustomerprofilesDomain#s3_exporting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Exporting", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigS3Exporting\"}", isOptional: true)]
        public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfigS3Exporting? S3Exporting
        {
            get;
            set;
        }
    }
}
