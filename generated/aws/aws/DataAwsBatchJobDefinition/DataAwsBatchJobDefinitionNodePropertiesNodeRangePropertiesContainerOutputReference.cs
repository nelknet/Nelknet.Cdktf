using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBatchJobDefinition
{
    [JsiiClass(nativeType: typeof(aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerOutputReference), fullyQualifiedName: "aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Command
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerEnvironmentList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerEnvironmentList Environment
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerEnvironmentList>()!;
        }

        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerEphemeralStorageList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerEphemeralStorageList EphemeralStorage
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerEphemeralStorageList>()!;
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fargatePlatformConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerFargatePlatformConfigurationList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerFargatePlatformConfigurationList FargatePlatformConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerFargatePlatformConfigurationList>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linuxParameters", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerLinuxParametersList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerLinuxParametersList LinuxParameters
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerLinuxParametersList>()!;
        }

        [JsiiProperty(name: "logConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerLogConfigurationList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerLogConfigurationList LogConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerLogConfigurationList>()!;
        }

        [JsiiProperty(name: "mountPoints", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerMountPointsList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerMountPointsList MountPoints
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerMountPointsList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerNetworkConfigurationList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerNetworkConfigurationList NetworkConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "privileged", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Privileged
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "readonlyRootFilesystem", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ReadonlyRootFilesystem
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "resourceRequirements", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerResourceRequirementsList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerResourceRequirementsList ResourceRequirements
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerResourceRequirementsList>()!;
        }

        [JsiiProperty(name: "runtimePlatform", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerRuntimePlatformList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerRuntimePlatformList RuntimePlatform
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerRuntimePlatformList>()!;
        }

        [JsiiProperty(name: "secrets", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerSecretsList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerSecretsList Secrets
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerSecretsList>()!;
        }

        [JsiiProperty(name: "ulimits", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerUlimitsList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerUlimitsList Ulimits
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerUlimitsList>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumes", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerVolumesList\"}")]
        public virtual aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerVolumesList Volumes
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainerVolumesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsBatchJobDefinition.DataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainer\"}", isOptional: true)]
        public virtual aws.DataAwsBatchJobDefinition.IDataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainer? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsBatchJobDefinition.IDataAwsBatchJobDefinitionNodePropertiesNodeRangePropertiesContainer?>();
            set => SetInstanceProperty(value);
        }
    }
}
