using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiByValue(fqn: "aws.securityhubInsight.SecurityhubInsightFilters")]
    public class SecurityhubInsightFilters : aws.SecurityhubInsight.ISecurityhubInsightFilters
    {
        private object? _awsAccountId;

        /// <summary>aws_account_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#aws_account_id SecurityhubInsight#aws_account_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsAccountId
        {
            get => _awsAccountId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersAwsAccountId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersAwsAccountId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsAccountId = value;
            }
        }

        private object? _companyName;

        /// <summary>company_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#company_name SecurityhubInsight#company_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CompanyName
        {
            get => _companyName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersCompanyName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCompanyName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _companyName = value;
            }
        }

        private object? _complianceStatus;

        /// <summary>compliance_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#compliance_status SecurityhubInsight#compliance_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "complianceStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ComplianceStatus
        {
            get => _complianceStatus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersComplianceStatus[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersComplianceStatus).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _complianceStatus = value;
            }
        }

        private object? _confidence;

        /// <summary>confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#confidence SecurityhubInsight#confidence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Confidence
        {
            get => _confidence;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersConfidence[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersConfidence).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _confidence = value;
            }
        }

        private object? _createdAt;

        /// <summary>created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#created_at SecurityhubInsight#created_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createdAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CreatedAt
        {
            get => _createdAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _createdAt = value;
            }
        }

        private object? _criticality;

        /// <summary>criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#criticality SecurityhubInsight#criticality}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "criticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Criticality
        {
            get => _criticality;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersCriticality[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCriticality).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _criticality = value;
            }
        }

        private object? _description;

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#description SecurityhubInsight#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Description
        {
            get => _description;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersDescription[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersDescription).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _description = value;
            }
        }

        private object? _findingProviderFieldsConfidence;

        /// <summary>finding_provider_fields_confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_confidence SecurityhubInsight#finding_provider_fields_confidence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsConfidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsConfidence
        {
            get => _findingProviderFieldsConfidence;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsConfidence[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsConfidence).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsConfidence = value;
            }
        }

        private object? _findingProviderFieldsCriticality;

        /// <summary>finding_provider_fields_criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_criticality SecurityhubInsight#finding_provider_fields_criticality}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsCriticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsCriticality
        {
            get => _findingProviderFieldsCriticality;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsCriticality[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsCriticality).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsCriticality = value;
            }
        }

        private object? _findingProviderFieldsRelatedFindingsId;

        /// <summary>finding_provider_fields_related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_related_findings_id SecurityhubInsight#finding_provider_fields_related_findings_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsRelatedFindingsId
        {
            get => _findingProviderFieldsRelatedFindingsId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsRelatedFindingsId = value;
            }
        }

        private object? _findingProviderFieldsRelatedFindingsProductArn;

        /// <summary>finding_provider_fields_related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_related_findings_product_arn SecurityhubInsight#finding_provider_fields_related_findings_product_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsRelatedFindingsProductArn
        {
            get => _findingProviderFieldsRelatedFindingsProductArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsRelatedFindingsProductArn = value;
            }
        }

        private object? _findingProviderFieldsSeverityLabel;

        /// <summary>finding_provider_fields_severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_severity_label SecurityhubInsight#finding_provider_fields_severity_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsSeverityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsSeverityLabel
        {
            get => _findingProviderFieldsSeverityLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsSeverityLabel = value;
            }
        }

        private object? _findingProviderFieldsSeverityOriginal;

        /// <summary>finding_provider_fields_severity_original block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_severity_original SecurityhubInsight#finding_provider_fields_severity_original}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsSeverityOriginal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsSeverityOriginal
        {
            get => _findingProviderFieldsSeverityOriginal;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsSeverityOriginal = value;
            }
        }

        private object? _findingProviderFieldsTypes;

        /// <summary>finding_provider_fields_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_types SecurityhubInsight#finding_provider_fields_types}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingProviderFieldsTypes
        {
            get => _findingProviderFieldsTypes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsTypes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsTypes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingProviderFieldsTypes = value;
            }
        }

        private object? _firstObservedAt;

        /// <summary>first_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#first_observed_at SecurityhubInsight#first_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FirstObservedAt
        {
            get => _firstObservedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersFirstObservedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFirstObservedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _firstObservedAt = value;
            }
        }

        private object? _generatorId;

        /// <summary>generator_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#generator_id SecurityhubInsight#generator_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generatorId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeneratorId
        {
            get => _generatorId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersGeneratorId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersGeneratorId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _generatorId = value;
            }
        }

        private object? _id;

        /// <summary>id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#id SecurityhubInsight#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Id
        {
            get => _id;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _id = value;
            }
        }

        private object? _keyword;

        /// <summary>keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#keyword SecurityhubInsight#keyword}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Keyword
        {
            get => _keyword;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersKeyword[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersKeyword).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keyword = value;
            }
        }

        private object? _lastObservedAt;

        /// <summary>last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#last_observed_at SecurityhubInsight#last_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LastObservedAt
        {
            get => _lastObservedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersLastObservedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersLastObservedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lastObservedAt = value;
            }
        }

        private object? _malwareName;

        /// <summary>malware_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_name SecurityhubInsight#malware_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MalwareName
        {
            get => _malwareName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _malwareName = value;
            }
        }

        private object? _malwarePath;

        /// <summary>malware_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_path SecurityhubInsight#malware_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwarePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwarePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MalwarePath
        {
            get => _malwarePath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwarePath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwarePath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _malwarePath = value;
            }
        }

        private object? _malwareState;

        /// <summary>malware_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_state SecurityhubInsight#malware_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MalwareState
        {
            get => _malwareState;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareState[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareState).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _malwareState = value;
            }
        }

        private object? _malwareType;

        /// <summary>malware_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_type SecurityhubInsight#malware_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? MalwareType
        {
            get => _malwareType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _malwareType = value;
            }
        }

        private object? _networkDestinationDomain;

        /// <summary>network_destination_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_domain SecurityhubInsight#network_destination_domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationDomain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkDestinationDomain
        {
            get => _networkDestinationDomain;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationDomain[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationDomain).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkDestinationDomain = value;
            }
        }

        private object? _networkDestinationIpv4;

        /// <summary>network_destination_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_ipv4 SecurityhubInsight#network_destination_ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkDestinationIpv4
        {
            get => _networkDestinationIpv4;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv4[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv4).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkDestinationIpv4 = value;
            }
        }

        private object? _networkDestinationIpv6;

        /// <summary>network_destination_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_ipv6 SecurityhubInsight#network_destination_ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkDestinationIpv6
        {
            get => _networkDestinationIpv6;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv6[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv6).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkDestinationIpv6 = value;
            }
        }

        private object? _networkDestinationPort;

        /// <summary>network_destination_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_port SecurityhubInsight#network_destination_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkDestinationPort
        {
            get => _networkDestinationPort;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationPort[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationPort).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkDestinationPort = value;
            }
        }

        private object? _networkDirection;

        /// <summary>network_direction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_direction SecurityhubInsight#network_direction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkDirection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDirection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkDirection
        {
            get => _networkDirection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDirection[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDirection).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkDirection = value;
            }
        }

        private object? _networkProtocol;

        /// <summary>network_protocol block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_protocol SecurityhubInsight#network_protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkProtocol
        {
            get => _networkProtocol;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkProtocol[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkProtocol).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkProtocol = value;
            }
        }

        private object? _networkSourceDomain;

        /// <summary>network_source_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_domain SecurityhubInsight#network_source_domain}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceDomain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkSourceDomain
        {
            get => _networkSourceDomain;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceDomain[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceDomain).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkSourceDomain = value;
            }
        }

        private object? _networkSourceIpv4;

        /// <summary>network_source_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_ipv4 SecurityhubInsight#network_source_ipv4}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkSourceIpv4
        {
            get => _networkSourceIpv4;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv4[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv4).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkSourceIpv4 = value;
            }
        }

        private object? _networkSourceIpv6;

        /// <summary>network_source_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_ipv6 SecurityhubInsight#network_source_ipv6}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkSourceIpv6
        {
            get => _networkSourceIpv6;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv6[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv6).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkSourceIpv6 = value;
            }
        }

        private object? _networkSourceMac;

        /// <summary>network_source_mac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_mac SecurityhubInsight#network_source_mac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourceMac", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceMac\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkSourceMac
        {
            get => _networkSourceMac;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceMac[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceMac).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkSourceMac = value;
            }
        }

        private object? _networkSourcePort;

        /// <summary>network_source_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_port SecurityhubInsight#network_source_port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkSourcePort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourcePort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkSourcePort
        {
            get => _networkSourcePort;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourcePort[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourcePort).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkSourcePort = value;
            }
        }

        private object? _noteText;

        /// <summary>note_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_text SecurityhubInsight#note_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noteText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NoteText
        {
            get => _noteText;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteText[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteText).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _noteText = value;
            }
        }

        private object? _noteUpdatedAt;

        /// <summary>note_updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_updated_at SecurityhubInsight#note_updated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NoteUpdatedAt
        {
            get => _noteUpdatedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _noteUpdatedAt = value;
            }
        }

        private object? _noteUpdatedBy;

        /// <summary>note_updated_by block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_updated_by SecurityhubInsight#note_updated_by}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NoteUpdatedBy
        {
            get => _noteUpdatedBy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedBy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedBy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _noteUpdatedBy = value;
            }
        }

        private object? _processLaunchedAt;

        /// <summary>process_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_launched_at SecurityhubInsight#process_launched_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProcessLaunchedAt
        {
            get => _processLaunchedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessLaunchedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessLaunchedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processLaunchedAt = value;
            }
        }

        private object? _processName;

        /// <summary>process_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_name SecurityhubInsight#process_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProcessName
        {
            get => _processName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processName = value;
            }
        }

        private object? _processParentPid;

        /// <summary>process_parent_pid block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_parent_pid SecurityhubInsight#process_parent_pid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processParentPid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessParentPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProcessParentPid
        {
            get => _processParentPid;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessParentPid[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessParentPid).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processParentPid = value;
            }
        }

        private object? _processPath;

        /// <summary>process_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_path SecurityhubInsight#process_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProcessPath
        {
            get => _processPath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processPath = value;
            }
        }

        private object? _processPid;

        /// <summary>process_pid block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_pid SecurityhubInsight#process_pid}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processPid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProcessPid
        {
            get => _processPid;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPid[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPid).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processPid = value;
            }
        }

        private object? _processTerminatedAt;

        /// <summary>process_terminated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_terminated_at SecurityhubInsight#process_terminated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "processTerminatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProcessTerminatedAt
        {
            get => _processTerminatedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _processTerminatedAt = value;
            }
        }

        private object? _productArn;

        /// <summary>product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_arn SecurityhubInsight#product_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProductArn
        {
            get => _productArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProductArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _productArn = value;
            }
        }

        private object? _productFields;

        /// <summary>product_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_fields SecurityhubInsight#product_fields}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProductFields
        {
            get => _productFields;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProductFields[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductFields).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _productFields = value;
            }
        }

        private object? _productName;

        /// <summary>product_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_name SecurityhubInsight#product_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "productName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ProductName
        {
            get => _productName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersProductName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _productName = value;
            }
        }

        private object? _recommendationText;

        /// <summary>recommendation_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#recommendation_text SecurityhubInsight#recommendation_text}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecommendationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecommendationText
        {
            get => _recommendationText;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersRecommendationText[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRecommendationText).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recommendationText = value;
            }
        }

        private object? _recordState;

        /// <summary>record_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#record_state SecurityhubInsight#record_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RecordState
        {
            get => _recordState;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersRecordState[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRecordState).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _recordState = value;
            }
        }

        private object? _relatedFindingsId;

        /// <summary>related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#related_findings_id SecurityhubInsight#related_findings_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RelatedFindingsId
        {
            get => _relatedFindingsId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _relatedFindingsId = value;
            }
        }

        private object? _relatedFindingsProductArn;

        /// <summary>related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#related_findings_product_arn SecurityhubInsight#related_findings_product_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RelatedFindingsProductArn
        {
            get => _relatedFindingsProductArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsProductArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsProductArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _relatedFindingsProductArn = value;
            }
        }

        private object? _resourceAwsEc2InstanceIamInstanceProfileArn;

        /// <summary>resource_aws_ec2_instance_iam_instance_profile_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_iam_instance_profile_arn SecurityhubInsight#resource_aws_ec2_instance_iam_instance_profile_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIamInstanceProfileArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceIamInstanceProfileArn
        {
            get => _resourceAwsEc2InstanceIamInstanceProfileArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceIamInstanceProfileArn = value;
            }
        }

        private object? _resourceAwsEc2InstanceImageId;

        /// <summary>resource_aws_ec2_instance_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_image_id SecurityhubInsight#resource_aws_ec2_instance_image_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceImageId
        {
            get => _resourceAwsEc2InstanceImageId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceImageId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceImageId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceImageId = value;
            }
        }

        private object? _resourceAwsEc2InstanceIpv4Addresses;

        /// <summary>resource_aws_ec2_instance_ipv4_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_ipv4_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv4_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv4Addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceIpv4Addresses
        {
            get => _resourceAwsEc2InstanceIpv4Addresses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceIpv4Addresses = value;
            }
        }

        private object? _resourceAwsEc2InstanceIpv6Addresses;

        /// <summary>resource_aws_ec2_instance_ipv6_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_ipv6_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv6_addresses}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv6Addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceIpv6Addresses
        {
            get => _resourceAwsEc2InstanceIpv6Addresses;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceIpv6Addresses = value;
            }
        }

        private object? _resourceAwsEc2InstanceKeyName;

        /// <summary>resource_aws_ec2_instance_key_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_key_name SecurityhubInsight#resource_aws_ec2_instance_key_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceKeyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceKeyName
        {
            get => _resourceAwsEc2InstanceKeyName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceKeyName = value;
            }
        }

        private object? _resourceAwsEc2InstanceLaunchedAt;

        /// <summary>resource_aws_ec2_instance_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_launched_at SecurityhubInsight#resource_aws_ec2_instance_launched_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceLaunchedAt
        {
            get => _resourceAwsEc2InstanceLaunchedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceLaunchedAt = value;
            }
        }

        private object? _resourceAwsEc2InstanceSubnetId;

        /// <summary>resource_aws_ec2_instance_subnet_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_subnet_id SecurityhubInsight#resource_aws_ec2_instance_subnet_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceSubnetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceSubnetId
        {
            get => _resourceAwsEc2InstanceSubnetId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceSubnetId = value;
            }
        }

        private object? _resourceAwsEc2InstanceType;

        /// <summary>resource_aws_ec2_instance_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_type SecurityhubInsight#resource_aws_ec2_instance_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceType
        {
            get => _resourceAwsEc2InstanceType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceType = value;
            }
        }

        private object? _resourceAwsEc2InstanceVpcId;

        /// <summary>resource_aws_ec2_instance_vpc_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_vpc_id SecurityhubInsight#resource_aws_ec2_instance_vpc_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceVpcId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsEc2InstanceVpcId
        {
            get => _resourceAwsEc2InstanceVpcId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceVpcId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceVpcId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsEc2InstanceVpcId = value;
            }
        }

        private object? _resourceAwsIamAccessKeyCreatedAt;

        /// <summary>resource_aws_iam_access_key_created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_created_at SecurityhubInsight#resource_aws_iam_access_key_created_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyCreatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsIamAccessKeyCreatedAt
        {
            get => _resourceAwsIamAccessKeyCreatedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsIamAccessKeyCreatedAt = value;
            }
        }

        private object? _resourceAwsIamAccessKeyStatus;

        /// <summary>resource_aws_iam_access_key_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_status SecurityhubInsight#resource_aws_iam_access_key_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsIamAccessKeyStatus
        {
            get => _resourceAwsIamAccessKeyStatus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyStatus[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyStatus).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsIamAccessKeyStatus = value;
            }
        }

        private object? _resourceAwsIamAccessKeyUserName;

        /// <summary>resource_aws_iam_access_key_user_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_user_name SecurityhubInsight#resource_aws_iam_access_key_user_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyUserName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsIamAccessKeyUserName
        {
            get => _resourceAwsIamAccessKeyUserName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyUserName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyUserName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsIamAccessKeyUserName = value;
            }
        }

        private object? _resourceAwsS3BucketOwnerId;

        /// <summary>resource_aws_s3_bucket_owner_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_s3_bucket_owner_id SecurityhubInsight#resource_aws_s3_bucket_owner_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsS3BucketOwnerId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsS3BucketOwnerId
        {
            get => _resourceAwsS3BucketOwnerId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsS3BucketOwnerId = value;
            }
        }

        private object? _resourceAwsS3BucketOwnerName;

        /// <summary>resource_aws_s3_bucket_owner_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_s3_bucket_owner_name SecurityhubInsight#resource_aws_s3_bucket_owner_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsS3BucketOwnerName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceAwsS3BucketOwnerName
        {
            get => _resourceAwsS3BucketOwnerName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAwsS3BucketOwnerName = value;
            }
        }

        private object? _resourceContainerImageId;

        /// <summary>resource_container_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_image_id SecurityhubInsight#resource_container_image_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceContainerImageId
        {
            get => _resourceContainerImageId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceContainerImageId = value;
            }
        }

        private object? _resourceContainerImageName;

        /// <summary>resource_container_image_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_image_name SecurityhubInsight#resource_container_image_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerImageName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceContainerImageName
        {
            get => _resourceContainerImageName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceContainerImageName = value;
            }
        }

        private object? _resourceContainerLaunchedAt;

        /// <summary>resource_container_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_launched_at SecurityhubInsight#resource_container_launched_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceContainerLaunchedAt
        {
            get => _resourceContainerLaunchedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerLaunchedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerLaunchedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceContainerLaunchedAt = value;
            }
        }

        private object? _resourceContainerName;

        /// <summary>resource_container_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_name SecurityhubInsight#resource_container_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceContainerName
        {
            get => _resourceContainerName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceContainerName = value;
            }
        }

        private object? _resourceDetailsOther;

        /// <summary>resource_details_other block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_details_other SecurityhubInsight#resource_details_other}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceDetailsOther
        {
            get => _resourceDetailsOther;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceDetailsOther[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceDetailsOther).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceDetailsOther = value;
            }
        }

        private object? _resourceId;

        /// <summary>resource_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_id SecurityhubInsight#resource_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceId
        {
            get => _resourceId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceId = value;
            }
        }

        private object? _resourcePartition;

        /// <summary>resource_partition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_partition SecurityhubInsight#resource_partition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourcePartition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourcePartition
        {
            get => _resourcePartition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourcePartition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourcePartition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourcePartition = value;
            }
        }

        private object? _resourceRegion;

        /// <summary>resource_region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_region SecurityhubInsight#resource_region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRegion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceRegion
        {
            get => _resourceRegion;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceRegion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceRegion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceRegion = value;
            }
        }

        private object? _resourceTags;

        /// <summary>resource_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_tags SecurityhubInsight#resource_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceTags
        {
            get => _resourceTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceTags = value;
            }
        }

        private object? _resourceType;

        /// <summary>resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_type SecurityhubInsight#resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceType
        {
            get => _resourceType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceType = value;
            }
        }

        private object? _severityLabel;

        /// <summary>severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#severity_label SecurityhubInsight#severity_label}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "severityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SeverityLabel
        {
            get => _severityLabel;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersSeverityLabel[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersSeverityLabel).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _severityLabel = value;
            }
        }

        private object? _sourceUrl;

        /// <summary>source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#source_url SecurityhubInsight#source_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceUrl
        {
            get => _sourceUrl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersSourceUrl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersSourceUrl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceUrl = value;
            }
        }

        private object? _threatIntelIndicatorCategory;

        /// <summary>threat_intel_indicator_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_category SecurityhubInsight#threat_intel_indicator_category}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorCategory", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThreatIntelIndicatorCategory
        {
            get => _threatIntelIndicatorCategory;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorCategory[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorCategory).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _threatIntelIndicatorCategory = value;
            }
        }

        private object? _threatIntelIndicatorLastObservedAt;

        /// <summary>threat_intel_indicator_last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_last_observed_at SecurityhubInsight#threat_intel_indicator_last_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorLastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThreatIntelIndicatorLastObservedAt
        {
            get => _threatIntelIndicatorLastObservedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _threatIntelIndicatorLastObservedAt = value;
            }
        }

        private object? _threatIntelIndicatorSource;

        /// <summary>threat_intel_indicator_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_source SecurityhubInsight#threat_intel_indicator_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThreatIntelIndicatorSource
        {
            get => _threatIntelIndicatorSource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _threatIntelIndicatorSource = value;
            }
        }

        private object? _threatIntelIndicatorSourceUrl;

        /// <summary>threat_intel_indicator_source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_source_url SecurityhubInsight#threat_intel_indicator_source_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorSourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThreatIntelIndicatorSourceUrl
        {
            get => _threatIntelIndicatorSourceUrl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSourceUrl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSourceUrl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _threatIntelIndicatorSourceUrl = value;
            }
        }

        private object? _threatIntelIndicatorType;

        /// <summary>threat_intel_indicator_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_type SecurityhubInsight#threat_intel_indicator_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThreatIntelIndicatorType
        {
            get => _threatIntelIndicatorType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _threatIntelIndicatorType = value;
            }
        }

        private object? _threatIntelIndicatorValue;

        /// <summary>threat_intel_indicator_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_value SecurityhubInsight#threat_intel_indicator_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThreatIntelIndicatorValue
        {
            get => _threatIntelIndicatorValue;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorValue[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorValue).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _threatIntelIndicatorValue = value;
            }
        }

        private object? _title;

        /// <summary>title block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#title SecurityhubInsight#title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Title
        {
            get => _title;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersTitle[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersTitle).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _title = value;
            }
        }

        private object? _type;

        /// <summary>type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#type SecurityhubInsight#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Type
        {
            get => _type;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _type = value;
            }
        }

        private object? _updatedAt;

        /// <summary>updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#updated_at SecurityhubInsight#updated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UpdatedAt
        {
            get => _updatedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersUpdatedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersUpdatedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _updatedAt = value;
            }
        }

        private object? _userDefinedValues;

        /// <summary>user_defined_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#user_defined_values SecurityhubInsight#user_defined_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userDefinedValues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUserDefinedValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UserDefinedValues
        {
            get => _userDefinedValues;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersUserDefinedValues[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersUserDefinedValues).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _userDefinedValues = value;
            }
        }

        private object? _verificationState;

        /// <summary>verification_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#verification_state SecurityhubInsight#verification_state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VerificationState
        {
            get => _verificationState;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersVerificationState[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersVerificationState).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _verificationState = value;
            }
        }

        private object? _workflowStatus;

        /// <summary>workflow_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#workflow_status SecurityhubInsight#workflow_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workflowStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WorkflowStatus
        {
            get => _workflowStatus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersWorkflowStatus[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersWorkflowStatus).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _workflowStatus = value;
            }
        }
    }
}
