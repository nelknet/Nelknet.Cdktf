using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetPhysicalTableMap), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap")]
    public interface IQuicksightDataSetPhysicalTableMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_map_id QuicksightDataSet#physical_table_map_id}.</summary>
        [JsiiProperty(name: "physicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
        string PhysicalTableMapId
        {
            get;
        }

        /// <summary>custom_sql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#custom_sql QuicksightDataSet#custom_sql}
        /// </remarks>
        [JsiiProperty(name: "customSql", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql? CustomSql
        {
            get
            {
                return null;
            }
        }

        /// <summary>relational_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#relational_table QuicksightDataSet#relational_table}
        /// </remarks>
        [JsiiProperty(name: "relationalTable", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable? RelationalTable
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#s3_source QuicksightDataSet#s3_source}
        /// </remarks>
        [JsiiProperty(name: "s3Source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source? S3Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetPhysicalTableMap), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_map_id QuicksightDataSet#physical_table_map_id}.</summary>
            [JsiiProperty(name: "physicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
            public string PhysicalTableMapId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_sql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#custom_sql QuicksightDataSet#custom_sql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customSql", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql? CustomSql
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql?>();
            }

            /// <summary>relational_table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#relational_table QuicksightDataSet#relational_table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relationalTable", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTable\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable? RelationalTable
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable?>();
            }

            /// <summary>s3_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#s3_source QuicksightDataSet#s3_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source? S3Source
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source?>();
            }
        }
    }
}
