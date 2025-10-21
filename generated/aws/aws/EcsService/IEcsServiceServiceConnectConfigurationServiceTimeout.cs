using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceTimeout), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout")]
    public interface IEcsServiceServiceConnectConfigurationServiceTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#idle_timeout_seconds EcsService#idle_timeout_seconds}.</summary>
        [JsiiProperty(name: "idleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IdleTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#per_request_timeout_seconds EcsService#per_request_timeout_seconds}.</summary>
        [JsiiProperty(name: "perRequestTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PerRequestTimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationServiceTimeout), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#idle_timeout_seconds EcsService#idle_timeout_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IdleTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#per_request_timeout_seconds EcsService#per_request_timeout_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "perRequestTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PerRequestTimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
