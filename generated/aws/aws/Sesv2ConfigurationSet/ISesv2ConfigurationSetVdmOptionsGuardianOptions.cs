using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetVdmOptionsGuardianOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions")]
    public interface ISesv2ConfigurationSetVdmOptionsGuardianOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#optimized_shared_delivery Sesv2ConfigurationSet#optimized_shared_delivery}.</summary>
        [JsiiProperty(name: "optimizedSharedDelivery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OptimizedSharedDelivery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetVdmOptionsGuardianOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#optimized_shared_delivery Sesv2ConfigurationSet#optimized_shared_delivery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optimizedSharedDelivery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OptimizedSharedDelivery
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
