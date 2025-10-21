using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFilters), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFilters")]
    public interface ISecurityhubInsightFilters
    {
        /// <summary>aws_account_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#aws_account_id SecurityhubInsight#aws_account_id}
        /// </remarks>
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>company_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#company_name SecurityhubInsight#company_name}
        /// </remarks>
        [JsiiProperty(name: "companyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CompanyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>compliance_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#compliance_status SecurityhubInsight#compliance_status}
        /// </remarks>
        [JsiiProperty(name: "complianceStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComplianceStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#confidence SecurityhubInsight#confidence}
        /// </remarks>
        [JsiiProperty(name: "confidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Confidence
        {
            get
            {
                return null;
            }
        }

        /// <summary>created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#created_at SecurityhubInsight#created_at}
        /// </remarks>
        [JsiiProperty(name: "createdAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#criticality SecurityhubInsight#criticality}
        /// </remarks>
        [JsiiProperty(name: "criticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Criticality
        {
            get
            {
                return null;
            }
        }

        /// <summary>description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#description SecurityhubInsight#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_confidence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_confidence SecurityhubInsight#finding_provider_fields_confidence}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsConfidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsConfidence
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_criticality block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_criticality SecurityhubInsight#finding_provider_fields_criticality}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsCriticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsCriticality
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_related_findings_id SecurityhubInsight#finding_provider_fields_related_findings_id}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsRelatedFindingsId
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_related_findings_product_arn SecurityhubInsight#finding_provider_fields_related_findings_product_arn}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsRelatedFindingsProductArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_severity_label SecurityhubInsight#finding_provider_fields_severity_label}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsSeverityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsSeverityLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_severity_original block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_severity_original SecurityhubInsight#finding_provider_fields_severity_original}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsSeverityOriginal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsSeverityOriginal
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_provider_fields_types block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_types SecurityhubInsight#finding_provider_fields_types}
        /// </remarks>
        [JsiiProperty(name: "findingProviderFieldsTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingProviderFieldsTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>first_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#first_observed_at SecurityhubInsight#first_observed_at}
        /// </remarks>
        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirstObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>generator_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#generator_id SecurityhubInsight#generator_id}
        /// </remarks>
        [JsiiProperty(name: "generatorId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GeneratorId
        {
            get
            {
                return null;
            }
        }

        /// <summary>id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#id SecurityhubInsight#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#keyword SecurityhubInsight#keyword}
        /// </remarks>
        [JsiiProperty(name: "keyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Keyword
        {
            get
            {
                return null;
            }
        }

        /// <summary>last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#last_observed_at SecurityhubInsight#last_observed_at}
        /// </remarks>
        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>malware_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_name SecurityhubInsight#malware_name}
        /// </remarks>
        [JsiiProperty(name: "malwareName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MalwareName
        {
            get
            {
                return null;
            }
        }

        /// <summary>malware_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_path SecurityhubInsight#malware_path}
        /// </remarks>
        [JsiiProperty(name: "malwarePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwarePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MalwarePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>malware_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_state SecurityhubInsight#malware_state}
        /// </remarks>
        [JsiiProperty(name: "malwareState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MalwareState
        {
            get
            {
                return null;
            }
        }

        /// <summary>malware_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_type SecurityhubInsight#malware_type}
        /// </remarks>
        [JsiiProperty(name: "malwareType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MalwareType
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_destination_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_domain SecurityhubInsight#network_destination_domain}
        /// </remarks>
        [JsiiProperty(name: "networkDestinationDomain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkDestinationDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_destination_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_ipv4 SecurityhubInsight#network_destination_ipv4}
        /// </remarks>
        [JsiiProperty(name: "networkDestinationIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkDestinationIpv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_destination_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_ipv6 SecurityhubInsight#network_destination_ipv6}
        /// </remarks>
        [JsiiProperty(name: "networkDestinationIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkDestinationIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_destination_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_port SecurityhubInsight#network_destination_port}
        /// </remarks>
        [JsiiProperty(name: "networkDestinationPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkDestinationPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_direction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_direction SecurityhubInsight#network_direction}
        /// </remarks>
        [JsiiProperty(name: "networkDirection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDirection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkDirection
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_protocol block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_protocol SecurityhubInsight#network_protocol}
        /// </remarks>
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_source_domain block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_domain SecurityhubInsight#network_source_domain}
        /// </remarks>
        [JsiiProperty(name: "networkSourceDomain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkSourceDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_source_ipv4 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_ipv4 SecurityhubInsight#network_source_ipv4}
        /// </remarks>
        [JsiiProperty(name: "networkSourceIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkSourceIpv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_source_ipv6 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_ipv6 SecurityhubInsight#network_source_ipv6}
        /// </remarks>
        [JsiiProperty(name: "networkSourceIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkSourceIpv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_source_mac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_mac SecurityhubInsight#network_source_mac}
        /// </remarks>
        [JsiiProperty(name: "networkSourceMac", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceMac\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkSourceMac
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_source_port block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_port SecurityhubInsight#network_source_port}
        /// </remarks>
        [JsiiProperty(name: "networkSourcePort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourcePort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkSourcePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>note_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_text SecurityhubInsight#note_text}
        /// </remarks>
        [JsiiProperty(name: "noteText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoteText
        {
            get
            {
                return null;
            }
        }

        /// <summary>note_updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_updated_at SecurityhubInsight#note_updated_at}
        /// </remarks>
        [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoteUpdatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>note_updated_by block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_updated_by SecurityhubInsight#note_updated_by}
        /// </remarks>
        [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoteUpdatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>process_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_launched_at SecurityhubInsight#process_launched_at}
        /// </remarks>
        [JsiiProperty(name: "processLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProcessLaunchedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>process_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_name SecurityhubInsight#process_name}
        /// </remarks>
        [JsiiProperty(name: "processName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProcessName
        {
            get
            {
                return null;
            }
        }

        /// <summary>process_parent_pid block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_parent_pid SecurityhubInsight#process_parent_pid}
        /// </remarks>
        [JsiiProperty(name: "processParentPid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessParentPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProcessParentPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>process_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_path SecurityhubInsight#process_path}
        /// </remarks>
        [JsiiProperty(name: "processPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProcessPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>process_pid block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_pid SecurityhubInsight#process_pid}
        /// </remarks>
        [JsiiProperty(name: "processPid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProcessPid
        {
            get
            {
                return null;
            }
        }

        /// <summary>process_terminated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_terminated_at SecurityhubInsight#process_terminated_at}
        /// </remarks>
        [JsiiProperty(name: "processTerminatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProcessTerminatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_arn SecurityhubInsight#product_arn}
        /// </remarks>
        [JsiiProperty(name: "productArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProductArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>product_fields block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_fields SecurityhubInsight#product_fields}
        /// </remarks>
        [JsiiProperty(name: "productFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProductFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>product_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_name SecurityhubInsight#product_name}
        /// </remarks>
        [JsiiProperty(name: "productName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProductName
        {
            get
            {
                return null;
            }
        }

        /// <summary>recommendation_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#recommendation_text SecurityhubInsight#recommendation_text}
        /// </remarks>
        [JsiiProperty(name: "recommendationText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecommendationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecommendationText
        {
            get
            {
                return null;
            }
        }

        /// <summary>record_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#record_state SecurityhubInsight#record_state}
        /// </remarks>
        [JsiiProperty(name: "recordState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RecordState
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_findings_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#related_findings_id SecurityhubInsight#related_findings_id}
        /// </remarks>
        [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RelatedFindingsId
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_findings_product_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#related_findings_product_arn SecurityhubInsight#related_findings_product_arn}
        /// </remarks>
        [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RelatedFindingsProductArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_iam_instance_profile_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_iam_instance_profile_arn SecurityhubInsight#resource_aws_ec2_instance_iam_instance_profile_arn}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceIamInstanceProfileArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceIamInstanceProfileArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_image_id SecurityhubInsight#resource_aws_ec2_instance_image_id}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_ipv4_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_ipv4_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv4_addresses}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv4Addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceIpv4Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_ipv6_addresses block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_ipv6_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv6_addresses}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv6Addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceIpv6Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_key_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_key_name SecurityhubInsight#resource_aws_ec2_instance_key_name}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceKeyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceKeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_launched_at SecurityhubInsight#resource_aws_ec2_instance_launched_at}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceLaunchedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_subnet_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_subnet_id SecurityhubInsight#resource_aws_ec2_instance_subnet_id}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceSubnetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_type SecurityhubInsight#resource_aws_ec2_instance_type}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_ec2_instance_vpc_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_vpc_id SecurityhubInsight#resource_aws_ec2_instance_vpc_id}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsEc2InstanceVpcId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsEc2InstanceVpcId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_iam_access_key_created_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_created_at SecurityhubInsight#resource_aws_iam_access_key_created_at}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsIamAccessKeyCreatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsIamAccessKeyCreatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_iam_access_key_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_status SecurityhubInsight#resource_aws_iam_access_key_status}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsIamAccessKeyStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsIamAccessKeyStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_iam_access_key_user_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_user_name SecurityhubInsight#resource_aws_iam_access_key_user_name}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsIamAccessKeyUserName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsIamAccessKeyUserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_s3_bucket_owner_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_s3_bucket_owner_id SecurityhubInsight#resource_aws_s3_bucket_owner_id}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsS3BucketOwnerId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsS3BucketOwnerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_aws_s3_bucket_owner_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_s3_bucket_owner_name SecurityhubInsight#resource_aws_s3_bucket_owner_name}
        /// </remarks>
        [JsiiProperty(name: "resourceAwsS3BucketOwnerName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceAwsS3BucketOwnerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_container_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_image_id SecurityhubInsight#resource_container_image_id}
        /// </remarks>
        [JsiiProperty(name: "resourceContainerImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceContainerImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_container_image_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_image_name SecurityhubInsight#resource_container_image_name}
        /// </remarks>
        [JsiiProperty(name: "resourceContainerImageName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceContainerImageName
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_container_launched_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_launched_at SecurityhubInsight#resource_container_launched_at}
        /// </remarks>
        [JsiiProperty(name: "resourceContainerLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceContainerLaunchedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_container_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_name SecurityhubInsight#resource_container_name}
        /// </remarks>
        [JsiiProperty(name: "resourceContainerName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceContainerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_details_other block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_details_other SecurityhubInsight#resource_details_other}
        /// </remarks>
        [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceDetailsOther
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_id SecurityhubInsight#resource_id}
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_partition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_partition SecurityhubInsight#resource_partition}
        /// </remarks>
        [JsiiProperty(name: "resourcePartition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourcePartition
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_region SecurityhubInsight#resource_region}
        /// </remarks>
        [JsiiProperty(name: "resourceRegion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_tags SecurityhubInsight#resource_tags}
        /// </remarks>
        [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_type SecurityhubInsight#resource_type}
        /// </remarks>
        [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>severity_label block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#severity_label SecurityhubInsight#severity_label}
        /// </remarks>
        [JsiiProperty(name: "severityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SeverityLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#source_url SecurityhubInsight#source_url}
        /// </remarks>
        [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_intel_indicator_category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_category SecurityhubInsight#threat_intel_indicator_category}
        /// </remarks>
        [JsiiProperty(name: "threatIntelIndicatorCategory", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThreatIntelIndicatorCategory
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_intel_indicator_last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_last_observed_at SecurityhubInsight#threat_intel_indicator_last_observed_at}
        /// </remarks>
        [JsiiProperty(name: "threatIntelIndicatorLastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThreatIntelIndicatorLastObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_intel_indicator_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_source SecurityhubInsight#threat_intel_indicator_source}
        /// </remarks>
        [JsiiProperty(name: "threatIntelIndicatorSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThreatIntelIndicatorSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_intel_indicator_source_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_source_url SecurityhubInsight#threat_intel_indicator_source_url}
        /// </remarks>
        [JsiiProperty(name: "threatIntelIndicatorSourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThreatIntelIndicatorSourceUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_intel_indicator_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_type SecurityhubInsight#threat_intel_indicator_type}
        /// </remarks>
        [JsiiProperty(name: "threatIntelIndicatorType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThreatIntelIndicatorType
        {
            get
            {
                return null;
            }
        }

        /// <summary>threat_intel_indicator_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_value SecurityhubInsight#threat_intel_indicator_value}
        /// </remarks>
        [JsiiProperty(name: "threatIntelIndicatorValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThreatIntelIndicatorValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>title block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#title SecurityhubInsight#title}
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#type SecurityhubInsight#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#updated_at SecurityhubInsight#updated_at}
        /// </remarks>
        [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpdatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_defined_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#user_defined_values SecurityhubInsight#user_defined_values}
        /// </remarks>
        [JsiiProperty(name: "userDefinedValues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUserDefinedValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserDefinedValues
        {
            get
            {
                return null;
            }
        }

        /// <summary>verification_state block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#verification_state SecurityhubInsight#verification_state}
        /// </remarks>
        [JsiiProperty(name: "verificationState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VerificationState
        {
            get
            {
                return null;
            }
        }

        /// <summary>workflow_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#workflow_status SecurityhubInsight#workflow_status}
        /// </remarks>
        [JsiiProperty(name: "workflowStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WorkflowStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFilters), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFilters")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubInsight.ISecurityhubInsightFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_account_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#aws_account_id SecurityhubInsight#aws_account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsAccountId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>company_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#company_name SecurityhubInsight#company_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "companyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CompanyName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>compliance_status block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#compliance_status SecurityhubInsight#compliance_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "complianceStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ComplianceStatus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>confidence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#confidence SecurityhubInsight#confidence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Confidence
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>created_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#created_at SecurityhubInsight#created_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createdAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CreatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>criticality block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#criticality SecurityhubInsight#criticality}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "criticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Criticality
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>description block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#description SecurityhubInsight#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Description
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_confidence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_confidence SecurityhubInsight#finding_provider_fields_confidence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsConfidence", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsConfidence
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_criticality block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_criticality SecurityhubInsight#finding_provider_fields_criticality}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsCriticality", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsCriticality
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_related_findings_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_related_findings_id SecurityhubInsight#finding_provider_fields_related_findings_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsRelatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsRelatedFindingsId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_related_findings_product_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_related_findings_product_arn SecurityhubInsight#finding_provider_fields_related_findings_product_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsRelatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsRelatedFindingsProductArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_severity_label block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_severity_label SecurityhubInsight#finding_provider_fields_severity_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsSeverityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsSeverityLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_severity_original block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_severity_original SecurityhubInsight#finding_provider_fields_severity_original}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsSeverityOriginal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsSeverityOriginal
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_provider_fields_types block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#finding_provider_fields_types SecurityhubInsight#finding_provider_fields_types}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingProviderFieldsTypes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingProviderFieldsTypes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>first_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#first_observed_at SecurityhubInsight#first_observed_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirstObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>generator_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#generator_id SecurityhubInsight#generator_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generatorId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GeneratorId
            {
                get => GetInstanceProperty<object?>();
            }

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
                get => GetInstanceProperty<object?>();
            }

            /// <summary>keyword block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#keyword SecurityhubInsight#keyword}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Keyword
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>last_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#last_observed_at SecurityhubInsight#last_observed_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>malware_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_name SecurityhubInsight#malware_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "malwareName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MalwareName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>malware_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_path SecurityhubInsight#malware_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "malwarePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwarePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MalwarePath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>malware_state block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_state SecurityhubInsight#malware_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "malwareState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MalwareState
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>malware_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#malware_type SecurityhubInsight#malware_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "malwareType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? MalwareType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_destination_domain block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_domain SecurityhubInsight#network_destination_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDestinationDomain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkDestinationDomain
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_destination_ipv4 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_ipv4 SecurityhubInsight#network_destination_ipv4}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDestinationIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkDestinationIpv4
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_destination_ipv6 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_ipv6 SecurityhubInsight#network_destination_ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDestinationIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkDestinationIpv6
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_destination_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_destination_port SecurityhubInsight#network_destination_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDestinationPort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkDestinationPort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_direction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_direction SecurityhubInsight#network_direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDirection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDirection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkDirection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_protocol block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_protocol SecurityhubInsight#network_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkProtocol
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_source_domain block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_domain SecurityhubInsight#network_source_domain}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkSourceDomain", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkSourceDomain
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_source_ipv4 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_ipv4 SecurityhubInsight#network_source_ipv4}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkSourceIpv4", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkSourceIpv4
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_source_ipv6 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_ipv6 SecurityhubInsight#network_source_ipv6}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkSourceIpv6", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkSourceIpv6
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_source_mac block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_mac SecurityhubInsight#network_source_mac}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkSourceMac", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceMac\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkSourceMac
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_source_port block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#network_source_port SecurityhubInsight#network_source_port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkSourcePort", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourcePort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkSourcePort
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>note_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_text SecurityhubInsight#note_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noteText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoteText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>note_updated_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_updated_at SecurityhubInsight#note_updated_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoteUpdatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>note_updated_by block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#note_updated_by SecurityhubInsight#note_updated_by}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoteUpdatedBy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>process_launched_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_launched_at SecurityhubInsight#process_launched_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProcessLaunchedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>process_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_name SecurityhubInsight#process_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProcessName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>process_parent_pid block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_parent_pid SecurityhubInsight#process_parent_pid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processParentPid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessParentPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProcessParentPid
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>process_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_path SecurityhubInsight#process_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProcessPath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>process_pid block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_pid SecurityhubInsight#process_pid}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processPid", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProcessPid
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>process_terminated_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#process_terminated_at SecurityhubInsight#process_terminated_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processTerminatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProcessTerminatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>product_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_arn SecurityhubInsight#product_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProductArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>product_fields block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_fields SecurityhubInsight#product_fields}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productFields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProductFields
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>product_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#product_name SecurityhubInsight#product_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "productName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProductName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>recommendation_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#recommendation_text SecurityhubInsight#recommendation_text}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recommendationText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecommendationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecommendationText
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>record_state block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#record_state SecurityhubInsight#record_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RecordState
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>related_findings_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#related_findings_id SecurityhubInsight#related_findings_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RelatedFindingsId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>related_findings_product_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#related_findings_product_arn SecurityhubInsight#related_findings_product_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RelatedFindingsProductArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_iam_instance_profile_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_iam_instance_profile_arn SecurityhubInsight#resource_aws_ec2_instance_iam_instance_profile_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceIamInstanceProfileArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceIamInstanceProfileArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_image_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_image_id SecurityhubInsight#resource_aws_ec2_instance_image_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceImageId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_ipv4_addresses block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_ipv4_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv4_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceIpv4Addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceIpv4Addresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_ipv6_addresses block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_ipv6_addresses SecurityhubInsight#resource_aws_ec2_instance_ipv6_addresses}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceIpv6Addresses", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceIpv6Addresses
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_key_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_key_name SecurityhubInsight#resource_aws_ec2_instance_key_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceKeyName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceKeyName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_launched_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_launched_at SecurityhubInsight#resource_aws_ec2_instance_launched_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceLaunchedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_subnet_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_subnet_id SecurityhubInsight#resource_aws_ec2_instance_subnet_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceSubnetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceSubnetId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_type SecurityhubInsight#resource_aws_ec2_instance_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_ec2_instance_vpc_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_ec2_instance_vpc_id SecurityhubInsight#resource_aws_ec2_instance_vpc_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsEc2InstanceVpcId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsEc2InstanceVpcId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_iam_access_key_created_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_created_at SecurityhubInsight#resource_aws_iam_access_key_created_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsIamAccessKeyCreatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsIamAccessKeyCreatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_iam_access_key_status block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_status SecurityhubInsight#resource_aws_iam_access_key_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsIamAccessKeyStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsIamAccessKeyStatus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_iam_access_key_user_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_iam_access_key_user_name SecurityhubInsight#resource_aws_iam_access_key_user_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsIamAccessKeyUserName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsIamAccessKeyUserName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_s3_bucket_owner_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_s3_bucket_owner_id SecurityhubInsight#resource_aws_s3_bucket_owner_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsS3BucketOwnerId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsS3BucketOwnerId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_aws_s3_bucket_owner_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_aws_s3_bucket_owner_name SecurityhubInsight#resource_aws_s3_bucket_owner_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAwsS3BucketOwnerName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceAwsS3BucketOwnerName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_container_image_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_image_id SecurityhubInsight#resource_container_image_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceContainerImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceContainerImageId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_container_image_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_image_name SecurityhubInsight#resource_container_image_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceContainerImageName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceContainerImageName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_container_launched_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_launched_at SecurityhubInsight#resource_container_launched_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceContainerLaunchedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceContainerLaunchedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_container_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_container_name SecurityhubInsight#resource_container_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceContainerName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceContainerName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_details_other block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_details_other SecurityhubInsight#resource_details_other}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceDetailsOther
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_id SecurityhubInsight#resource_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_partition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_partition SecurityhubInsight#resource_partition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePartition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourcePartition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_region block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_region SecurityhubInsight#resource_region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRegion", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceRegion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_tags SecurityhubInsight#resource_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#resource_type SecurityhubInsight#resource_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>severity_label block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#severity_label SecurityhubInsight#severity_label}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "severityLabel", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SeverityLabel
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#source_url SecurityhubInsight#source_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>threat_intel_indicator_category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_category SecurityhubInsight#threat_intel_indicator_category}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatIntelIndicatorCategory", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThreatIntelIndicatorCategory
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>threat_intel_indicator_last_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_last_observed_at SecurityhubInsight#threat_intel_indicator_last_observed_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatIntelIndicatorLastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThreatIntelIndicatorLastObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>threat_intel_indicator_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_source SecurityhubInsight#threat_intel_indicator_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatIntelIndicatorSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThreatIntelIndicatorSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>threat_intel_indicator_source_url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_source_url SecurityhubInsight#threat_intel_indicator_source_url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatIntelIndicatorSourceUrl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThreatIntelIndicatorSourceUrl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>threat_intel_indicator_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_type SecurityhubInsight#threat_intel_indicator_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatIntelIndicatorType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThreatIntelIndicatorType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>threat_intel_indicator_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#threat_intel_indicator_value SecurityhubInsight#threat_intel_indicator_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threatIntelIndicatorValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThreatIntelIndicatorValue
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>title block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#title SecurityhubInsight#title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Title
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#type SecurityhubInsight#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Type
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>updated_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#updated_at SecurityhubInsight#updated_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UpdatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>user_defined_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#user_defined_values SecurityhubInsight#user_defined_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userDefinedValues", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUserDefinedValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UserDefinedValues
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>verification_state block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#verification_state SecurityhubInsight#verification_state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verificationState", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VerificationState
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>workflow_status block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_insight#workflow_status SecurityhubInsight#workflow_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "workflowStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WorkflowStatus
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
