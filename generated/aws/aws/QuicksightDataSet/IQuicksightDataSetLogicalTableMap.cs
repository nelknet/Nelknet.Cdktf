using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMap), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMap")]
    public interface IQuicksightDataSetLogicalTableMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#alias QuicksightDataSet#alias}.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        string Alias
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#logical_table_map_id QuicksightDataSet#logical_table_map_id}.</summary>
        [JsiiProperty(name: "logicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
        string LogicalTableMapId
        {
            get;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#source QuicksightDataSet#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource\"}")]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource Source
        {
            get;
        }

        /// <summary>data_transforms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_transforms QuicksightDataSet#data_transforms}
        /// </remarks>
        [JsiiProperty(name: "dataTransforms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataTransforms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMap), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMap")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMap
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#alias QuicksightDataSet#alias}.</summary>
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
            public string Alias
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#logical_table_map_id QuicksightDataSet#logical_table_map_id}.</summary>
            [JsiiProperty(name: "logicalTableMapId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogicalTableMapId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#source QuicksightDataSet#source}
            /// </remarks>
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapSource\"}")]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource Source
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapSource>()!;
            }

            /// <summary>data_transforms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#data_transforms QuicksightDataSet#data_transforms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataTransforms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataTransforms
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
