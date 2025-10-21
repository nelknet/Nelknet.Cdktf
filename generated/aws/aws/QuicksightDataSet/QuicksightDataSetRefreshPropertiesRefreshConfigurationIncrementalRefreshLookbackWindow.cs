using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow")]
    public class QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow : aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        public string ColumnName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#size QuicksightDataSet#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#size_unit QuicksightDataSet#size_unit}.</summary>
        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string SizeUnit
        {
            get;
            set;
        }
    }
}
