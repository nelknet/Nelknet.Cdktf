using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition")]
    public class KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition : aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#condition_document_attribute_key KendraDataSource#condition_document_attribute_key}.</summary>
        [JsiiProperty(name: "conditionDocumentAttributeKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionDocumentAttributeKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#operator KendraDataSource#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>condition_on_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#condition_on_value KendraDataSource#condition_on_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditionOnValue", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsConditionConditionOnValue? ConditionOnValue
        {
            get;
            set;
        }
    }
}
