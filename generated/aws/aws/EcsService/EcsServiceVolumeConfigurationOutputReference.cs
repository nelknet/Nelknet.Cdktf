using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceVolumeConfigurationOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceVolumeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsServiceVolumeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsServiceVolumeConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsServiceVolumeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceVolumeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putManagedEbsVolume", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationManagedEbsVolume\"}}]")]
        public virtual void PutManagedEbsVolume(aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume)}, new object[]{@value});
        }

        [JsiiProperty(name: "managedEbsVolume", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationManagedEbsVolumeOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceVolumeConfigurationManagedEbsVolumeOutputReference ManagedEbsVolume
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceVolumeConfigurationManagedEbsVolumeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedEbsVolumeInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfigurationManagedEbsVolume\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume? ManagedEbsVolumeInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceVolumeConfigurationManagedEbsVolume?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceVolumeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceVolumeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
