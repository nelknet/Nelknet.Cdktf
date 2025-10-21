using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2AccountVdmAttributes
{
    [JsiiInterface(nativeType: typeof(ISesv2AccountVdmAttributesGuardianAttributes), fullyQualifiedName: "aws.sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesGuardianAttributes")]
    public interface ISesv2AccountVdmAttributesGuardianAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#optimized_shared_delivery Sesv2AccountVdmAttributes#optimized_shared_delivery}.</summary>
        [JsiiProperty(name: "optimizedSharedDelivery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OptimizedSharedDelivery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2AccountVdmAttributesGuardianAttributes), fullyQualifiedName: "aws.sesv2AccountVdmAttributes.Sesv2AccountVdmAttributesGuardianAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2AccountVdmAttributes.ISesv2AccountVdmAttributesGuardianAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_account_vdm_attributes#optimized_shared_delivery Sesv2AccountVdmAttributes#optimized_shared_delivery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optimizedSharedDelivery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OptimizedSharedDelivery
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
