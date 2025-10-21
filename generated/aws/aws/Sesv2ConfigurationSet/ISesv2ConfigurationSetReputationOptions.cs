using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetReputationOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions")]
    public interface ISesv2ConfigurationSetReputationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#reputation_metrics_enabled Sesv2ConfigurationSet#reputation_metrics_enabled}.</summary>
        [JsiiProperty(name: "reputationMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReputationMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetReputationOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#reputation_metrics_enabled Sesv2ConfigurationSet#reputation_metrics_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reputationMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReputationMetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
