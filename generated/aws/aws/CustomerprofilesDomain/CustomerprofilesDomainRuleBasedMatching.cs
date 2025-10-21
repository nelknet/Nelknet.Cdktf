using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatching")]
    public class CustomerprofilesDomainRuleBasedMatching : aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatching
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#enabled CustomerprofilesDomain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>attribute_types_selector block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#attribute_types_selector CustomerprofilesDomain#attribute_types_selector}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributeTypesSelector", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector\"}", isOptional: true)]
        public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingAttributeTypesSelector? AttributeTypesSelector
        {
            get;
            set;
        }

        /// <summary>conflict_resolution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#conflict_resolution CustomerprofilesDomain#conflict_resolution}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conflictResolution", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingConflictResolution\"}", isOptional: true)]
        public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingConflictResolution? ConflictResolution
        {
            get;
            set;
        }

        /// <summary>exporting_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#exporting_config CustomerprofilesDomain#exporting_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exportingConfig", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingExportingConfig\"}", isOptional: true)]
        public aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingExportingConfig? ExportingConfig
        {
            get;
            set;
        }

        private object? _matchingRules;

        /// <summary>matching_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#matching_rules CustomerprofilesDomain#matching_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchingRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainRuleBasedMatchingMatchingRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MatchingRules
        {
            get => _matchingRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingMatchingRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CustomerprofilesDomain.ICustomerprofilesDomainRuleBasedMatchingMatchingRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _matchingRules = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#max_allowed_rule_level_for_matching CustomerprofilesDomain#max_allowed_rule_level_for_matching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedRuleLevelForMatching", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAllowedRuleLevelForMatching
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#max_allowed_rule_level_for_merging CustomerprofilesDomain#max_allowed_rule_level_for_merging}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedRuleLevelForMerging", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAllowedRuleLevelForMerging
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customerprofiles_domain#status CustomerprofilesDomain#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
