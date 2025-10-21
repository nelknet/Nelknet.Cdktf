using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationTagRules")]
    public class QuicksightDataSetRowLevelPermissionTagConfigurationTagRules : aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfigurationTagRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_key QuicksightDataSet#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        public string TagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#match_all_value QuicksightDataSet#match_all_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matchAllValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchAllValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_multi_value_delimiter QuicksightDataSet#tag_multi_value_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagMultiValueDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagMultiValueDelimiter
        {
            get;
            set;
        }
    }
}
