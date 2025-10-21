using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiClass(nativeType: typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfigCodeEditorAppImageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContainerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig\"}}]")]
        public virtual void PutContainerConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystemConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig\"}}]")]
        public virtual void PutFileSystemConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerConfig")]
        public virtual void ResetContainerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemConfig")]
        public virtual void ResetFileSystemConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfigOutputReference ContainerConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference FileSystemConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig? ContainerConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigContainerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig? FileSystemConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfigFileSystemConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigCodeEditorAppImageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
