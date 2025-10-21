using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2AccountVdmAttributes
{
    [JsiiInterface(nativeType: typeof(ISesv2AccountVdmAttributesDashboardAttributes), fullyQualifiedName: "aws.sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesDashboardAttributes")]
    public interface ISesv2AccountVdmAttributesDashboardAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#engagement_metrics Sesv2AccountVdmAttributes#engagement_metrics}.</summary>
        [JsiiProperty(name: "engagementMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EngagementMetrics
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2AccountVdmAttributesDashboardAttributes), fullyQualifiedName: "aws.sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesDashboardAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2AccountVdmAttributes.ISesv2AccountVdmAttributesDashboardAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#engagement_metrics Sesv2AccountVdmAttributes#engagement_metrics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "engagementMetrics", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EngagementMetrics
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
