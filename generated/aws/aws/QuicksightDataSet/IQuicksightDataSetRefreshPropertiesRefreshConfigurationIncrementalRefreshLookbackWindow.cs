using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow")]
    public interface IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        string ColumnName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#size QuicksightDataSet#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#size_unit QuicksightDataSet#size_unit}.</summary>
        [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string SizeUnit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetRefreshPropertiesRefreshConfigurationIncrementalRefreshLookbackWindow
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#size QuicksightDataSet#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#size_unit QuicksightDataSet#size_unit}.</summary>
            [JsiiProperty(name: "sizeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string SizeUnit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
