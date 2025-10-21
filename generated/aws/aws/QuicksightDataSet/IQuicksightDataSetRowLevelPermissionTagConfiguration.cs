using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetRowLevelPermissionTagConfiguration), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfiguration")]
    public interface IQuicksightDataSetRowLevelPermissionTagConfiguration
    {
        /// <summary>tag_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_rules QuicksightDataSet#tag_rules}
        /// </remarks>
        [JsiiProperty(name: "tagRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationTagRules\"},\"kind\":\"array\"}}]}}")]
        object TagRules
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#status QuicksightDataSet#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetRowLevelPermissionTagConfiguration), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetRowLevelPermissionTagConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>tag_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_rules QuicksightDataSet#tag_rules}
            /// </remarks>
            [JsiiProperty(name: "tagRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetRowLevelPermissionTagConfigurationTagRules\"},\"kind\":\"array\"}}]}}")]
            public object TagRules
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#status QuicksightDataSet#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
