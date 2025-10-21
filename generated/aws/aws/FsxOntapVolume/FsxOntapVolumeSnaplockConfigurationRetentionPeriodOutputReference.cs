using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOntapVolume
{
    [JsiiClass(nativeType: typeof(aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference), fullyQualifiedName: "aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapVolumeSnaplockConfigurationRetentionPeriodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultRetention", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention\"}}]")]
        public virtual void PutDefaultRetention(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaximumRetention", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention\"}}]")]
        public virtual void PutMaximumRetention(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMinimumRetention", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention\"}}]")]
        public virtual void PutMinimumRetention(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultRetention")]
        public virtual void ResetDefaultRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetention")]
        public virtual void ResetMaximumRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumRetention")]
        public virtual void ResetMinimumRetention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetentionOutputReference\"}")]
        public virtual aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetentionOutputReference DefaultRetention
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetentionOutputReference>()!;
        }

        [JsiiProperty(name: "maximumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetentionOutputReference\"}")]
        public virtual aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetentionOutputReference MaximumRetention
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetentionOutputReference>()!;
        }

        [JsiiProperty(name: "minimumRetention", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetentionOutputReference\"}")]
        public virtual aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetentionOutputReference MinimumRetention
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetentionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRetentionInput", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention? DefaultRetentionInput
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodDefaultRetention?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetentionInput", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention? MaximumRetentionInput
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMaximumRetention?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumRetentionInput", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention? MinimumRetentionInput
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriodMinimumRetention?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxOntapVolume.FsxOntapVolumeSnaplockConfigurationRetentionPeriod\"}", isOptional: true)]
        public virtual aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod? InternalValue
        {
            get => GetInstanceProperty<aws.FsxOntapVolume.IFsxOntapVolumeSnaplockConfigurationRetentionPeriod?>();
            set => SetInstanceProperty(value);
        }
    }
}
