using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcsTaskDefinition
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_definition aws_ecs_task_definition}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition), fullyQualifiedName: "aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionConfig\"}}]")]
    public class DataAwsEcsTaskDefinition : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_definition aws_ecs_task_definition} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEcsTaskDefinition(Constructs.Construct scope, string id, aws.DataAwsEcsTaskDefinition.IDataAwsEcsTaskDefinitionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsEcsTaskDefinition.IDataAwsEcsTaskDefinitionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsTaskDefinition(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEcsTaskDefinition(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsEcsTaskDefinition resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsEcsTaskDefinition to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsEcsTaskDefinition that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsEcsTaskDefinition to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsEcsTaskDefinition to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_definition#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsEcsTaskDefinition that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsEcsTaskDefinition to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arnWithoutRevision", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArnWithoutRevision
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerDefinitions", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerDefinitions
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cpu
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableFaultInjection", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnableFaultInjection
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ephemeralStorage", typeJson: "{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionEphemeralStorageList\"}")]
        public virtual aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionEphemeralStorageList EphemeralStorage
        {
            get => GetInstanceProperty<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionEphemeralStorageList>()!;
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "family", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Family
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inferenceAccelerator", typeJson: "{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionInferenceAcceleratorList\"}")]
        public virtual aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionInferenceAcceleratorList InferenceAccelerator
        {
            get => GetInstanceProperty<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionInferenceAcceleratorList>()!;
        }

        [JsiiProperty(name: "ipcMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpcMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Memory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pidMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PidMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementConstraints", typeJson: "{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionPlacementConstraintsList\"}")]
        public virtual aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionPlacementConstraintsList PlacementConstraints
        {
            get => GetInstanceProperty<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionPlacementConstraintsList>()!;
        }

        [JsiiProperty(name: "proxyConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionProxyConfigurationList\"}")]
        public virtual aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionProxyConfigurationList ProxyConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionProxyConfigurationList>()!;
        }

        [JsiiProperty(name: "requiresCompatibilities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RequiresCompatibilities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Revision
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "runtimePlatform", typeJson: "{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionRuntimePlatformList\"}")]
        public virtual aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionRuntimePlatformList RuntimePlatform
        {
            get => GetInstanceProperty<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionRuntimePlatformList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volume", typeJson: "{\"fqn\":\"aws.dataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionVolumeList\"}")]
        public virtual aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionVolumeList Volume
        {
            get => GetInstanceProperty<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionVolumeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDefinition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
