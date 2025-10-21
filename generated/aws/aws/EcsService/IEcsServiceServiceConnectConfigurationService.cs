using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationService), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationService")]
    public interface IEcsServiceServiceConnectConfigurationService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#port_name EcsService#port_name}.</summary>
        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        string PortName
        {
            get;
        }

        /// <summary>client_alias block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#client_alias EcsService#client_alias}
        /// </remarks>
        [JsiiProperty(name: "clientAlias", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias? ClientAlias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#discovery_name EcsService#discovery_name}.</summary>
        [JsiiProperty(name: "discoveryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiscoveryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#ingress_port_override EcsService#ingress_port_override}.</summary>
        [JsiiProperty(name: "ingressPortOverride", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IngressPortOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#timeout EcsService#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#tls EcsService#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationService), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationService")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#port_name EcsService#port_name}.</summary>
            [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
            public string PortName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>client_alias block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#client_alias EcsService#client_alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientAlias", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias? ClientAlias
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#discovery_name EcsService#discovery_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "discoveryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiscoveryName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#ingress_port_override EcsService#ingress_port_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ingressPortOverride", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IngressPortOverride
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#timeout EcsService#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout? Timeout
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#tls EcsService#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls\"}", isOptional: true)]
            public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls? Tls
            {
                get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls?>();
            }
        }
    }
}
