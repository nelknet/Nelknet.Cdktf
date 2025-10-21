using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation")]
    public interface IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#condition_expression QuicksightDataSet#condition_expression}.</summary>
        [JsiiProperty(name: "conditionExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionExpression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#condition_expression QuicksightDataSet#condition_expression}.</summary>
            [JsiiProperty(name: "conditionExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionExpression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
