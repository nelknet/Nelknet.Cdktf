using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyFeature
{
    [JsiiInterface(nativeType: typeof(IEvidentlyFeatureVariationsValue), fullyQualifiedName: "aws.evidentlyFeature.EvidentlyFeatureVariationsValue")]
    public interface IEvidentlyFeatureVariationsValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#bool_value EvidentlyFeature#bool_value}.</summary>
        [JsiiProperty(name: "boolValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BoolValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#double_value EvidentlyFeature#double_value}.</summary>
        [JsiiProperty(name: "doubleValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DoubleValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#long_value EvidentlyFeature#long_value}.</summary>
        [JsiiProperty(name: "longValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LongValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#string_value EvidentlyFeature#string_value}.</summary>
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StringValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyFeatureVariationsValue), fullyQualifiedName: "aws.evidentlyFeature.EvidentlyFeatureVariationsValue")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#bool_value EvidentlyFeature#bool_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "boolValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BoolValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#double_value EvidentlyFeature#double_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "doubleValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DoubleValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#long_value EvidentlyFeature#long_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "longValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LongValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#string_value EvidentlyFeature#string_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StringValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
