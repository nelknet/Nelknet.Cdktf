using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesOutputReference), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionEksPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BatchJobDefinitionEksPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BatchJobDefinitionEksPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BatchJobDefinitionEksPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionEksPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPodProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties\"}}]")]
        public virtual void PutPodProperties(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties)}, new object[]{@value});
        }

        [JsiiProperty(name: "podProperties", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesOutputReference\"}")]
        public virtual aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesOutputReference PodProperties
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.BatchJobDefinitionEksPropertiesPodPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "podPropertiesInput", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksPropertiesPodProperties\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties? PodPropertiesInput
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksPropertiesPodProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batchJobDefinition.BatchJobDefinitionEksProperties\"}", isOptional: true)]
        public virtual aws.BatchJobDefinition.IBatchJobDefinitionEksProperties? InternalValue
        {
            get => GetInstanceProperty<aws.BatchJobDefinition.IBatchJobDefinitionEksProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
