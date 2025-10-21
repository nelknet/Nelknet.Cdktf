using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiInterface(nativeType: typeof(ICustomerprofilesDomainMatchingAutoMerging), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging")]
    public interface ICustomerprofilesDomainMatchingAutoMerging
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#enabled CustomerprofilesDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>conflict_resolution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#conflict_resolution CustomerprofilesDomain#conflict_resolution}
        /// </remarks>
        [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolution\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution? ConflictResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>consolidation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#consolidation CustomerprofilesDomain#consolidation}
        /// </remarks>
        [JsiiProperty(name: "consolidation", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation? Consolidation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#min_allowed_confidence_score_for_merging CustomerprofilesDomain#min_allowed_confidence_score_for_merging}.</summary>
        [JsiiProperty(name: "minAllowedConfidenceScoreForMerging", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinAllowedConfidenceScoreForMerging
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerprofilesDomainMatchingAutoMerging), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMerging")]
        internal sealed class _Proxy : DeputyBase, aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMerging
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

            /// <summary>conflict_resolution block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#conflict_resolution CustomerprofilesDomain#conflict_resolution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConflictResolution\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution? ConflictResolution
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConflictResolution?>();
            }

            /// <summary>consolidation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#consolidation CustomerprofilesDomain#consolidation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "consolidation", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingAutoMergingConsolidation\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation? Consolidation
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingAutoMergingConsolidation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#min_allowed_confidence_score_for_merging CustomerprofilesDomain#min_allowed_confidence_score_for_merging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minAllowedConfidenceScoreForMerging", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinAllowedConfidenceScoreForMerging
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
