using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiClass(nativeType: typeof(aws.EcsTaskDefinition.EcsTaskDefinitionVolumeOutputReference), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsTaskDefinitionVolumeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EcsTaskDefinitionVolumeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDockerVolumeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}}]")]
        public virtual void PutDockerVolumeConfiguration(aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEfsVolumeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}}]")]
        public virtual void PutEfsVolumeConfiguration(aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFsxWindowsFileServerVolumeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration\"}}]")]
        public virtual void PutFsxWindowsFileServerVolumeConfiguration(aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigureAtLaunch")]
        public virtual void ResetConfigureAtLaunch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerVolumeConfiguration")]
        public virtual void ResetDockerVolumeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEfsVolumeConfiguration")]
        public virtual void ResetEfsVolumeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsxWindowsFileServerVolumeConfiguration")]
        public virtual void ResetFsxWindowsFileServerVolumeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostPath")]
        public virtual void ResetHostPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dockerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfigurationOutputReference\"}")]
        public virtual aws.EcsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfigurationOutputReference DockerVolumeConfiguration
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "efsVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference\"}")]
        public virtual aws.EcsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference EfsVolumeConfiguration
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "fsxWindowsFileServerVolumeConfiguration", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference\"}")]
        public virtual aws.EcsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference FsxWindowsFileServerVolumeConfiguration
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configureAtLaunchInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ConfigureAtLaunchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerVolumeConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeDockerVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration? DockerVolumeConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeDockerVolumeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "efsVolumeConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeEfsVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration? EfsVolumeConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeEfsVolumeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsxWindowsFileServerVolumeConfigurationInput", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration? FsxWindowsFileServerVolumeConfigurationInput
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "configureAtLaunch", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ConfigureAtLaunch
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "hostPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolume\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EcsTaskDefinition.IEcsTaskDefinitionVolume cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsTaskDefinition.IEcsTaskDefinitionVolume).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
