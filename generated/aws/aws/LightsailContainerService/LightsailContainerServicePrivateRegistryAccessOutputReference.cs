using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    [JsiiClass(nativeType: typeof(aws.LightsailContainerService.LightsailContainerServicePrivateRegistryAccessOutputReference), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LightsailContainerServicePrivateRegistryAccessOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LightsailContainerServicePrivateRegistryAccessOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LightsailContainerServicePrivateRegistryAccessOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailContainerServicePrivateRegistryAccessOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEcrImagePullerRole", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole\"}}]")]
        public virtual void PutEcrImagePullerRole(aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEcrImagePullerRole")]
        public virtual void ResetEcrImagePullerRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ecrImagePullerRole", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRoleOutputReference\"}")]
        public virtual aws.LightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRoleOutputReference EcrImagePullerRole
        {
            get => GetInstanceProperty<aws.LightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRoleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImagePullerRoleInput", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessEcrImagePullerRole\"}", isOptional: true)]
        public virtual aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole? EcrImagePullerRoleInput
        {
            get => GetInstanceProperty<aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccessEcrImagePullerRole?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccess\"}", isOptional: true)]
        public virtual aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess? InternalValue
        {
            get => GetInstanceProperty<aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess?>();
            set => SetInstanceProperty(value);
        }
    }
}
