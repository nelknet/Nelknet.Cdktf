using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceObservabilityConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceObservabilityConfiguration")]
    public interface IApprunnerServiceObservabilityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_enabled ApprunnerService#observability_enabled}.</summary>
        [JsiiProperty(name: "observabilityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ObservabilityEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_configuration_arn ApprunnerService#observability_configuration_arn}.</summary>
        [JsiiProperty(name: "observabilityConfigurationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObservabilityConfigurationArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceObservabilityConfiguration), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceObservabilityConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ApprunnerService.IApprunnerServiceObservabilityConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_enabled ApprunnerService#observability_enabled}.</summary>
            [JsiiProperty(name: "observabilityEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ObservabilityEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#observability_configuration_arn ApprunnerService#observability_configuration_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "observabilityConfigurationArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObservabilityConfigurationArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
