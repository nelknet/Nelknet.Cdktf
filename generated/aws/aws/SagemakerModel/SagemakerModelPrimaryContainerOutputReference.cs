using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel.SagemakerModelPrimaryContainerOutputReference), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelPrimaryContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerModelPrimaryContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerModelPrimaryContainerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerModelPrimaryContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelPrimaryContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfig\"}}]")]
        public virtual void PutImageConfig(aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModelDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSource\"}}]")]
        public virtual void PutModelDataSource(aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMultiModelConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerMultiModelConfig\"}}]")]
        public virtual void PutMultiModelConfig(aws.SagemakerModel.ISagemakerModelPrimaryContainerMultiModelConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelPrimaryContainerMultiModelConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerHostname")]
        public virtual void ResetContainerHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageConfig")]
        public virtual void ResetImageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceSpecificationName")]
        public virtual void ResetInferenceSpecificationName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelDataSource")]
        public virtual void ResetModelDataSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelDataUrl")]
        public virtual void ResetModelDataUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelPackageName")]
        public virtual void ResetModelPackageName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMultiModelConfig")]
        public virtual void ResetMultiModelConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "imageConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfigOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelPrimaryContainerImageConfigOutputReference ImageConfig
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelPrimaryContainerImageConfigOutputReference>()!;
        }

        [JsiiProperty(name: "modelDataSource", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSourceOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelPrimaryContainerModelDataSourceOutputReference ModelDataSource
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelPrimaryContainerModelDataSourceOutputReference>()!;
        }

        [JsiiProperty(name: "multiModelConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerMultiModelConfigOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelPrimaryContainerMultiModelConfigOutputReference MultiModelConfig
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelPrimaryContainerMultiModelConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? EnvironmentInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig? ImageConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerImageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceSpecificationNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InferenceSpecificationNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelDataSourceInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerModelDataSource\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSource? ModelDataSourceInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerModelDataSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelDataUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelDataUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelPackageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelPackageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "multiModelConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainerMultiModelConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainerMultiModelConfig? MultiModelConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainerMultiModelConfig?>();
        }

        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Environment
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inferenceSpecificationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InferenceSpecificationName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelDataUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelPackageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelPackageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelPrimaryContainer\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelPrimaryContainer? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelPrimaryContainer?>();
            set => SetInstanceProperty(value);
        }
    }
}
