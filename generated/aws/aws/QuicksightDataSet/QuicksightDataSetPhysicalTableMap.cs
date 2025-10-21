using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetPhysicalTableMap")]
    public class QuicksightDataSetPhysicalTableMap : aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#physical_table_map_id QuicksightDataSet#physical_table_map_id}.</summary>
        [JsiiProperty(name: "physicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
        public string PhysicalTableMapId
        {
            get;
            set;
        }

        /// <summary>custom_sql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#custom_sql QuicksightDataSet#custom_sql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customSql", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapCustomSql\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapCustomSql? CustomSql
        {
            get;
            set;
        }

        /// <summary>relational_table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#relational_table QuicksightDataSet#relational_table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relationalTable", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapRelationalTable\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapRelationalTable? RelationalTable
        {
            get;
            set;
        }

        /// <summary>s3_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#s3_source QuicksightDataSet#s3_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetPhysicalTableMapS3Source\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetPhysicalTableMapS3Source? S3Source
        {
            get;
            set;
        }
    }
}
