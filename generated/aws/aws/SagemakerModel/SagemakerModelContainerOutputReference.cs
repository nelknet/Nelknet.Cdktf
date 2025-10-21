using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerModel
{
    [JsiiClass(nativeType: typeof(aws.SagemakerModel.SagemakerModelContainerOutputReference), fullyQualifiedName: "aws.sagemakerModel.SagemakerModelContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerModelContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SagemakerModelContainerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SagemakerModelContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfig\"}}]")]
        public virtual void PutImageConfig(aws.SagemakerModel.ISagemakerModelContainerImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelContainerImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putModelDataSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerModelDataSource\"}}]")]
        public virtual void PutModelDataSource(aws.SagemakerModel.ISagemakerModelContainerModelDataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelContainerModelDataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMultiModelConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerMultiModelConfig\"}}]")]
        public virtual void PutMultiModelConfig(aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig)}, new object[]{@value});
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

        [JsiiProperty(name: "imageConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfigOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelContainerImageConfigOutputReference ImageConfig
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelContainerImageConfigOutputReference>()!;
        }

        [JsiiProperty(name: "modelDataSource", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerModelDataSourceOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelContainerModelDataSourceOutputReference ModelDataSource
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelContainerModelDataSourceOutputReference>()!;
        }

        [JsiiProperty(name: "multiModelConfig", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerMultiModelConfigOutputReference\"}")]
        public virtual aws.SagemakerModel.SagemakerModelContainerMultiModelConfigOutputReference MultiModelConfig
        {
            get => GetInstanceProperty<aws.SagemakerModel.SagemakerModelContainerMultiModelConfigOutputReference>()!;
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
        [JsiiProperty(name: "imageConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerImageConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelContainerImageConfig? ImageConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerImageConfig?>();
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
        [JsiiProperty(name: "modelDataSourceInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerModelDataSource\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelContainerModelDataSource? ModelDataSourceInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerModelDataSource?>();
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
        [JsiiProperty(name: "multiModelConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainerMultiModelConfig\"}", isOptional: true)]
        public virtual aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig? MultiModelConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerModel.ISagemakerModelContainerMultiModelConfig?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.sagemakerModel.SagemakerModelContainer\"}]}}", isOptional: true)]
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
                        case aws.SagemakerModel.ISagemakerModelContainer cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerModel.ISagemakerModelContainer).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
