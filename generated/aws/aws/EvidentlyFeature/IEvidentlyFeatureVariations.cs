using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyFeature
{
    [JsiiInterface(nativeType: typeof(IEvidentlyFeatureVariations), fullyQualifiedName: "aws.evidentlyFeature.EvidentlyFeatureVariations")]
    public interface IEvidentlyFeatureVariations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#name EvidentlyFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#value EvidentlyFeature#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"aws.evidentlyFeature.EvidentlyFeatureVariationsValue\"}")]
        aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyFeatureVariations), fullyQualifiedName: "aws.evidentlyFeature.EvidentlyFeatureVariations")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyFeature.IEvidentlyFeatureVariations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#name EvidentlyFeature#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_feature#value EvidentlyFeature#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"aws.evidentlyFeature.EvidentlyFeatureVariationsValue\"}")]
            public aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue Value
            {
                get => GetInstanceProperty<aws.EvidentlyFeature.IEvidentlyFeatureVariationsValue>()!;
            }
        }
    }
}
