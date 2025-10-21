using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesOutputReference), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesVolumesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BatchJobDefinitionEksPropertiesPodPropertiesVolumesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected BatchJobDefinitionEksPropertiesPodPropertiesVolumesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionEksPropertiesPodPropertiesVolumesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEmptyDir", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir\"}}]")]
        public virtual void PutEmptyDir(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath\"}}]")]
        public virtual void PutHostPath(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret\"}}]")]
        public virtual void PutSecret(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEmptyDir")]
        public virtual void ResetEmptyDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostPath")]
        public virtual void ResetHostPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "emptyDir", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference\"}")]
        public virtual aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference EmptyDir
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference>()!;
        }

        [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPathOutputReference\"}")]
        public virtual aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPathOutputReference HostPath
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPathOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecretOutputReference\"}")]
        public virtual aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecretOutputReference Secret
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecretOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "emptyDirInput", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDirInput
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostPathInput", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath? HostPathInput
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesHostPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret? SecretInput
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesSecret?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumes\"}]}}", isOptional: true)]
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
                        case aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumes).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
