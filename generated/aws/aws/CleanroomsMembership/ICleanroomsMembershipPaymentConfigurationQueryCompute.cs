using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiInterface(nativeType: typeof(ICleanroomsMembershipPaymentConfigurationQueryCompute), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipPaymentConfigurationQueryCompute")]
    public interface ICleanroomsMembershipPaymentConfigurationQueryCompute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#is_responsible CleanroomsMembership#is_responsible}.</summary>
        [JsiiProperty(name: "isResponsible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object IsResponsible
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICleanroomsMembershipPaymentConfigurationQueryCompute), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipPaymentConfigurationQueryCompute")]
        internal sealed class _Proxy : DeputyBase, aws.CleanroomsMembership.ICleanroomsMembershipPaymentConfigurationQueryCompute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#is_responsible CleanroomsMembership#is_responsible}.</summary>
            [JsiiProperty(name: "isResponsible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object IsResponsible
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
