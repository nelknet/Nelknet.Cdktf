using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsVolume
{
    [JsiiClass(nativeType: typeof(aws.FsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsOutputReference), fullyQualifiedName: "aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxOpenzfsVolumeNfsExportsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FsxOpenzfsVolumeNfsExportsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FsxOpenzfsVolumeNfsExportsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsVolumeNfsExportsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientConfigurations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeNfsExportsClientConfigurations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeNfsExportsClientConfigurations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeNfsExportsClientConfigurations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"fqn\":\"aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurationsList\"}")]
        public virtual aws.FsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurationsList ClientConfigurations
        {
            get => GetInstanceProperty<aws.FsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientConfigurationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientConfigurationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxOpenzfsVolume.FsxOpenzfsVolumeNfsExports\"}", isOptional: true)]
        public virtual aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeNfsExports? InternalValue
        {
            get => GetInstanceProperty<aws.FsxOpenzfsVolume.IFsxOpenzfsVolumeNfsExports?>();
            set => SetInstanceProperty(value);
        }
    }
}
