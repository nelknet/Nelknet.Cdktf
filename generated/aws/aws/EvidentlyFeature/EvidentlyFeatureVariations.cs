using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyFeature
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.evidentlyFeature.EvidentlyFeatureVariations")]
    public class EvidentlyFeatureVariations : aws.EvidentlyFeature.IEvidentlyFeatureVariations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#name EvidentlyFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#value EvidentlyFeature#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"aws.evidentlyFeature.EvidentlyFeatureVariationsValue\"}")]
        public aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue Value
        {
            get;
            set;
        }
    }
}
