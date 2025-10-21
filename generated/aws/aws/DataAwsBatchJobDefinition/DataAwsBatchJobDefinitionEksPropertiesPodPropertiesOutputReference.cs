using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBatchJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesOutputReference), fullyQualifiedName: "aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsBatchJobDefinitionEksPropertiesPodPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsBatchJobDefinitionEksPropertiesPodPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsBatchJobDefinitionEksPropertiesPodPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBatchJobDefinitionEksPropertiesPodPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "containers", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesContainersList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesContainersList Containers
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesContainersList>()!;
        }

        [JsiiProperty(name: "dnsPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DnsPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostNetwork", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable HostNetwork
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "imagePullSecrets", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecretsList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecretsList ImagePullSecrets
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesImagePullSecretsList>()!;
        }

        [JsiiProperty(name: "initContainers", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesInitContainersList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesInitContainersList InitContainers
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesInitContainersList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesMetadataList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesMetadataList Metadata
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesMetadataList>()!;
        }

        [JsiiProperty(name: "serviceAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shareProcessNamespace", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ShareProcessNamespace
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "volumes", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesVolumesList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesVolumesList Volumes
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodPropertiesVolumesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionEksPropertiesPodProperties\"}", isOptional: true)]
        public virtual aws.DataAwsBatchJobDefinition.IDataAwsBatchJobDefinitionEksPropertiesPodProperties? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.IDataAwsBatchJobDefinitionEksPropertiesPodProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
