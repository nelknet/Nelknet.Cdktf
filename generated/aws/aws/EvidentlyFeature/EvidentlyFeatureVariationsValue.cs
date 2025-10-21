using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyFeature
{
    [JsiiByValue(fqn: "aws.evidentlyFeature.EvidentlyFeatureVariationsValue")]
    public class EvidentlyFeatureVariationsValue : aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#bool_value EvidentlyFeature#bool_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "boolValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BoolValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#double_value EvidentlyFeature#double_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "doubleValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DoubleValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#long_value EvidentlyFeature#long_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "longValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LongValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#string_value EvidentlyFeature#string_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stringValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StringValue
        {
            get;
            set;
        }
    }
}
