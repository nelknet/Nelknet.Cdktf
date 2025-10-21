using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerServiceDeploymentVersion
{
    [JsiiClass(nativeType: typeof(aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointOutputReference), fullyQualifiedName: "aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LightsailContainerServiceDeploymentVersionPublicEndpointOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LightsailContainerServiceDeploymentVersionPublicEndpointOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailContainerServiceDeploymentVersionPublicEndpointOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailContainerServiceDeploymentVersionPublicEndpointOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck\"}}]")]
        public virtual void PutHealthCheck(aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck)}, new object[]{@value});
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheckOutputReference\"}")]
        public virtual aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<aws.LightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheckOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ContainerPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck\"}", isOptional: true)]
        public virtual aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpointHealthCheck?>();
        }

        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lightsailContainerServiceDeploymentVersion.LightsailContainerServiceDeploymentVersionPublicEndpoint\"}", isOptional: true)]
        public virtual aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpoint? InternalValue
        {
            get => GetInstanceProperty<aws.LightsailContainerServiceDeploymentVersion.ILightsailContainerServiceDeploymentVersionPublicEndpoint?>();
            set => SetInstanceProperty(value);
        }
    }
}
