using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetPhysicalTableMapCustomSql), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql")]
    public interface IQuicksightDataSetPhysicalTableMapCustomSql
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_source_arn QuicksightDataSet#data_source_arn}.</summary>
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataSourceArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#name QuicksightDataSet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#sql_query QuicksightDataSet#sql_query}.</summary>
        [JsiiProperty(name: "sqlQuery", typeJson: "{\"primitive\":\"string\"}")]
        string SqlQuery
        {
            get;
        }

        /// <summary>columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#columns QuicksightDataSet#columns}
        /// </remarks>
        [JsiiProperty(name: "columns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSqlColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Columns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetPhysicalTableMapCustomSql), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_source_arn QuicksightDataSet#data_source_arn}.</summary>
            [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#name QuicksightDataSet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#sql_query QuicksightDataSet#sql_query}.</summary>
            [JsiiProperty(name: "sqlQuery", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlQuery
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#columns QuicksightDataSet#columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "columns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSqlColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Columns
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
