using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiInterface(nativeType: typeof(ICustomerprofilesDomainRuleBasedMatching), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatching")]
    public interface ICustomerprofilesDomainRuleBasedMatching
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#enabled CustomerprofilesDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>attribute_types_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#attribute_types_selector CustomerprofilesDomain#attribute_types_selector}
        /// </remarks>
        [JsiiProperty(name: "attributeTypesSelector", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector? AttributeTypesSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>conflict_resolution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#conflict_resolution CustomerprofilesDomain#conflict_resolution}
        /// </remarks>
        [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolution\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution? ConflictResolution
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
        [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig? ExportingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>matching_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching_rules CustomerprofilesDomain#matching_rules}
        /// </remarks>
        [JsiiProperty(name: "matchingRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MatchingRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#max_allowed_rule_level_for_matching CustomerprofilesDomain#max_allowed_rule_level_for_matching}.</summary>
        [JsiiProperty(name: "maxAllowedRuleLevelForMatching", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAllowedRuleLevelForMatching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#max_allowed_rule_level_for_merging CustomerprofilesDomain#max_allowed_rule_level_for_merging}.</summary>
        [JsiiProperty(name: "maxAllowedRuleLevelForMerging", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAllowedRuleLevelForMerging
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#status CustomerprofilesDomain#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerprofilesDomainRuleBasedMatching), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatching")]
        internal sealed class _Proxy : DeputyBase, aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatching
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

            /// <summary>attribute_types_selector block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#attribute_types_selector CustomerprofilesDomain#attribute_types_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attributeTypesSelector", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector? AttributeTypesSelector
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector?>();
            }

            /// <summary>conflict_resolution block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#conflict_resolution CustomerprofilesDomain#conflict_resolution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolution\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution? ConflictResolution
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution?>();
            }

            /// <summary>exporting_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#exporting_config CustomerprofilesDomain#exporting_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfig\"}", isOptional: true)]
            public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig? ExportingConfig
            {
                get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig?>();
            }

            /// <summary>matching_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching_rules CustomerprofilesDomain#matching_rules}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchingRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MatchingRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#max_allowed_rule_level_for_matching CustomerprofilesDomain#max_allowed_rule_level_for_matching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAllowedRuleLevelForMatching", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAllowedRuleLevelForMatching
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#max_allowed_rule_level_for_merging CustomerprofilesDomain#max_allowed_rule_level_for_merging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAllowedRuleLevelForMerging", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAllowedRuleLevelForMerging
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#status CustomerprofilesDomain#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
