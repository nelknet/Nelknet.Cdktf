using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMap")]
    public class QuicksightDataSetLogicalTableMap : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#alias QuicksightDataSet#alias}.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public string Alias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#logical_table_map_id QuicksightDataSet#logical_table_map_id}.</summary>
        [JsiiProperty(name: "logicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogicalTableMapId
        {
            get;
            set;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#source QuicksightDataSet#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource\"}")]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource Source
        {
            get;
            set;
        }

        private object? _dataTransforms;

        /// <summary>data_transforms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_transforms QuicksightDataSet#data_transforms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataTransforms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataTransforms
        {
            get => _dataTransforms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransforms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransforms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataTransforms = value;
            }
        }
    }
}
