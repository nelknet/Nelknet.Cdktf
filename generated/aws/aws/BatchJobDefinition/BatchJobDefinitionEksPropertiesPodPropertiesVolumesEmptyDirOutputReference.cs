using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDirOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMedium")]
        public virtual void ResetMedium()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "mediumInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MediumInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeLimitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizeLimitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "medium", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Medium
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeLimit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir? InternalValue
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodPropertiesVolumesEmptyDir?>();
            set => SetInstanceProperty(value);
        }
    }
}
