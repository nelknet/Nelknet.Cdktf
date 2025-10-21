using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerObservabilityConfiguration
{
    [JsiiInterface(nativeType: typeof(IApprunnerObservabilityConfigurationTraceConfiguration), fullyQualifiedName: "aws.apprunnerObservabilityConfiguration.ApprunnerObservabilityConfigurationTraceConfiguration")]
    public interface IApprunnerObservabilityConfigurationTraceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#vendor ApprunnerObservabilityConfiguration#vendor}.</summary>
        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Vendor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerObservabilityConfigurationTraceConfiguration), fullyQualifiedName: "aws.apprunnerObservabilityConfiguration.ApprunnerObservabilityConfigurationTraceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerObservabilityConfiguration.IApprunnerObservabilityConfigurationTraceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_observability_configuration#vendor ApprunnerObservabilityConfiguration#vendor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Vendor
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
