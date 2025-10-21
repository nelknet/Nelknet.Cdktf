using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerServiceDeploymentVersion
{
    [JsiiInterface(nativeType: typeof(ILightsailContainerServiceDeploymentVersionPublicEndpoint), fullyQualifiedName: "aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpoint")]
    public interface ILightsailContainerServiceDeploymentVersionPublicEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#container_name LightsailContainerServiceDeploymentVersion#container_name}.</summary>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        string ContainerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#container_port LightsailContainerServiceDeploymentVersion#container_port}.</summary>
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ContainerPort
        {
            get;
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#health_check LightsailContainerServiceDeploymentVersion#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck\"}")]
        aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck HealthCheck
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailContainerServiceDeploymentVersionPublicEndpoint), fullyQualifiedName: "aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#container_name LightsailContainerServiceDeploymentVersion#container_name}.</summary>
            [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
            public string ContainerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#container_port LightsailContainerServiceDeploymentVersion#container_port}.</summary>
            [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ContainerPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service_deployment_version#health_check LightsailContainerServiceDeploymentVersion#health_check}
            /// </remarks>
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck\"}")]
            public aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck HealthCheck
            {
                get => GetInstanceProperty<aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck>()!;
            }
        }
    }
}
