using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiInterface(nativeType: typeof(ICustomerprofilesDomainMatching), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatching")]
    public interface ICustomerprofilesDomainMatching
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#enabled CustomerprofilesDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>auto_merging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#auto_merging CustomerprofilesDomain#auto_merging}
        /// </remarks>
        [JsiiProperty(name: "autoMerging", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging? AutoMerging
        {
            get
            {
                return null;
            }
        }

        /// <summary>exporting_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#exporting_config CustomerprofilesDomain#exporting_config}
        /// </remarks>
        [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig? ExportingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#job_schedule CustomerprofilesDomain#job_schedule}
        /// </remarks>
        [JsiiProperty(name: "jobSchedule", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule? JobSchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerprofilesDomainMatching), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatching")]
        internal sealed class _Proxy : DeputyBase, aws.CustomerprofilesDomain.ICustomerprofilesDomainMatching
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#enabled CustomerprofilesDomain#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>auto_merging block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#auto_merging CustomerprofilesDomain#auto_merging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoMerging", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging? AutoMerging
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging?>();
            }

            /// <summary>exporting_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#exporting_config CustomerprofilesDomain#exporting_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingExportingConfig\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig? ExportingConfig
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingExportingConfig?>();
            }

            /// <summary>job_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#job_schedule CustomerprofilesDomain#job_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobSchedule", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobSchedule\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule? JobSchedule
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule?>();
            }
        }
    }
}
