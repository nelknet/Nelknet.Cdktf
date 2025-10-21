using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    [JsiiInterface(nativeType: typeof(ICloudtrailInsightSelector), fullyQualifiedName: "aws.cloudtrail.CloudtrailInsightSelector")]
    public interface ICloudtrailInsightSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#insight_type Cloudtrail#insight_type}.</summary>
        [JsiiProperty(name: "insightType", typeJson: "{\"primitive\":\"string\"}")]
        string InsightType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudtrailInsightSelector), fullyQualifiedName: "aws.cloudtrail.CloudtrailInsightSelector")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudtrail.ICloudtrailInsightSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail#insight_type Cloudtrail#insight_type}.</summary>
            [JsiiProperty(name: "insightType", typeJson: "{\"primitive\":\"string\"}")]
            public string InsightType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
