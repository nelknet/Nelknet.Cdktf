using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiInterface(nativeType: typeof(ICustomerprofilesDomainMatchingExportingConfig), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig")]
    public interface ICustomerprofilesDomainMatchingExportingConfig
    {
        /// <summary>s3_exporting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#s3_exporting CustomerprofilesDomain#s3_exporting}
        /// </remarks>
        [JsiiProperty(name: "s3Exporting", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigS3Exporting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfigS3Exporting? S3Exporting
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerprofilesDomainMatchingExportingConfig), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_exporting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#s3_exporting CustomerprofilesDomain#s3_exporting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Exporting", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfigS3Exporting\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfigS3Exporting? S3Exporting
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfigS3Exporting?>();
            }
        }
    }
}
