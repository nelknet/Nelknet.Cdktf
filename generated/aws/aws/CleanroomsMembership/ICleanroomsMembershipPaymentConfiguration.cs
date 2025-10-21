using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiInterface(nativeType: typeof(ICleanroomsMembershipPaymentConfiguration), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipPaymentConfiguration")]
    public interface ICleanroomsMembershipPaymentConfiguration
    {
        /// <summary>query_compute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#query_compute CleanroomsMembership#query_compute}
        /// </remarks>
        [JsiiProperty(name: "queryCompute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipPaymentConfigurationQueryCompute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryCompute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICleanroomsMembershipPaymentConfiguration), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipPaymentConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CleanroomsMembership.ICleanroomsMembershipPaymentConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>query_compute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#query_compute CleanroomsMembership#query_compute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryCompute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipPaymentConfigurationQueryCompute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? QueryCompute
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
