using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiClass(nativeType: typeof(aws.EcsTaskDefinition.EcsTaskDefinitionRuntimePlatformOutputReference), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionRuntimePlatformOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsTaskDefinitionRuntimePlatformOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsTaskDefinitionRuntimePlatformOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsTaskDefinitionRuntimePlatformOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionRuntimePlatformOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpuArchitecture")]
        public virtual void ResetCpuArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperatingSystemFamily")]
        public virtual void ResetOperatingSystemFamily()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuArchitectureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CpuArchitectureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemFamilyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatingSystemFamilyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cpuArchitecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpuArchitecture
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operatingSystemFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystemFamily
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionRuntimePlatform\"}", isOptional: true)]
        public virtual aws.EcsTaskDefinition.IEcsTaskDefinitionRuntimePlatform? InternalValue
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionRuntimePlatform?>();
            set => SetInstanceProperty(value);
        }
    }
}
