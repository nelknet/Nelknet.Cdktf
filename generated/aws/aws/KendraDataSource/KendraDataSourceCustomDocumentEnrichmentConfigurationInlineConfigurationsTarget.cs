using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget")]
    public class KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget : aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#target_document_attribute_key KendraDataSource#target_document_attribute_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDocumentAttributeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetDocumentAttributeKey
        {
            get;
            set;
        }

        /// <summary>target_document_attribute_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#target_document_attribute_value KendraDataSource#target_document_attribute_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetDocumentAttributeValue", typeJson: "{\"fqn\":\"aws.kendraDataSource.KendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue\"}", isOptional: true)]
        public aws.KendraDataSource.IKendraDataSourceCustomDocumentEnrichmentConfigurationInlineConfigurationsTargetTargetDocumentAttributeValue? TargetDocumentAttributeValue
        {
            get;
            set;
        }

        private object? _targetDocumentAttributeValueDeletion;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#target_document_attribute_value_deletion KendraDataSource#target_document_attribute_value_deletion}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDocumentAttributeValueDeletion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TargetDocumentAttributeValueDeletion
        {
            get => _targetDocumentAttributeValueDeletion;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targetDocumentAttributeValueDeletion = value;
            }
        }
    }
}
