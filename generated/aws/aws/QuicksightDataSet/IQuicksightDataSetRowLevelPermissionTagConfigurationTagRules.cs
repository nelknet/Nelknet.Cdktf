using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetRowLevelPermissionTagConfigurationTagRules), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationTagRules")]
    public interface IQuicksightDataSetRowLevelPermissionTagConfigurationTagRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        string ColumnName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_key QuicksightDataSet#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        string TagKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#match_all_value QuicksightDataSet#match_all_value}.</summary>
        [JsiiProperty(name: "matchAllValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchAllValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_multi_value_delimiter QuicksightDataSet#tag_multi_value_delimiter}.</summary>
        [JsiiProperty(name: "tagMultiValueDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagMultiValueDelimiter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetRowLevelPermissionTagConfigurationTagRules), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationTagRules")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfigurationTagRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
            [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
            public string ColumnName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_key QuicksightDataSet#tag_key}.</summary>
            [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
            public string TagKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#match_all_value QuicksightDataSet#match_all_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchAllValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchAllValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_multi_value_delimiter QuicksightDataSet#tag_multi_value_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagMultiValueDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagMultiValueDelimiter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
