using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAppImageConfig
{
    [JsiiClass(nativeType: typeof(aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigOutputReference), fullyQualifiedName: "aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerAppImageConfigJupyterLabImageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerAppImageConfigJupyterLabImageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerAppImageConfigJupyterLabImageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfigJupyterLabImageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContainerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigContainerConfig\"}}]")]
        public virtual void PutContainerConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigContainerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigContainerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystemConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig\"}}]")]
        public virtual void PutFileSystemConfig(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig)}, new object[]{@value});
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

        [JsiiProperty(name: "containerConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigContainerConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigContainerConfigOutputReference ContainerConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigContainerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigFileSystemConfigOutputReference\"}")]
        public virtual aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigFileSystemConfigOutputReference FileSystemConfig
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigFileSystemConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigContainerConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigContainerConfig? ContainerConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigContainerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig? FileSystemConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfigFileSystemConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerAppImageConfig.ISagemakerAppImageConfigJupyterLabImageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
