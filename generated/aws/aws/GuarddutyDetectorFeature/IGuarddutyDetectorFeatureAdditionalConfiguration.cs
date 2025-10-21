using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyDetectorFeature
{
    [JsiiInterface(nativeType: typeof(IGuarddutyDetectorFeatureAdditionalConfiguration), fullyQualifiedName: "aws.guarddutyDetectorFeature.GuarddutyDetectorFeatureAdditionalConfiguration")]
    public interface IGuarddutyDetectorFeatureAdditionalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#name GuarddutyDetectorFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#status GuarddutyDetectorFeature#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyDetectorFeatureAdditionalConfiguration), fullyQualifiedName: "aws.guarddutyDetectorFeature.GuarddutyDetectorFeatureAdditionalConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyDetectorFeature.IGuarddutyDetectorFeatureAdditionalConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#name GuarddutyDetectorFeature#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector_feature#status GuarddutyDetectorFeature#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
