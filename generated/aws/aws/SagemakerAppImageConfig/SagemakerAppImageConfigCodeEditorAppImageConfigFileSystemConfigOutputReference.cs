using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiClass(nativeType: typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultGid")]
        public virtual void ResetDefaultGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultUid")]
        public virtual void ResetDefaultUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountPath")]
        public virtual void ResetMountPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultGidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultGidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultUidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultUidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MountPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultGid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultGid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultUid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultUid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MountPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
