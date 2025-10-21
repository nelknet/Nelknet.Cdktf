using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchComputeEnvironment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment aws_batch_compute_environment}.</summary>
    [JsiiClass(nativeType: typeof(aws.BatchComputeEnvironment.BatchComputeEnvironment), fullyQualifiedName: "aws.batchComputeEnvironment.BatchComputeEnvironment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentConfig\"}}]")]
    public class BatchComputeEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment aws_batch_compute_environment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BatchComputeEnvironment(Constructs.Construct scope, string id, aws.BatchComputeEnvironment.IBatchComputeEnvironmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.BatchComputeEnvironment.IBatchComputeEnvironmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchComputeEnvironment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a BatchComputeEnvironment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BatchComputeEnvironment to import.</param>
        /// <param name="importFromId">The id of the existing BatchComputeEnvironment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BatchComputeEnvironment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BatchComputeEnvironment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BatchComputeEnvironment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BatchComputeEnvironment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.BatchComputeEnvironment.BatchComputeEnvironment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putComputeResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentComputeResources\"}}]")]
        public virtual void PutComputeResources(aws.BatchComputeEnvironment.IBatchComputeEnvironmentComputeResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchComputeEnvironment.IBatchComputeEnvironmentComputeResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEksConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentEksConfiguration\"}}]")]
        public virtual void PutEksConfiguration(aws.BatchComputeEnvironment.IBatchComputeEnvironmentEksConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchComputeEnvironment.IBatchComputeEnvironmentEksConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdatePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy\"}}]")]
        public virtual void PutUpdatePolicy(aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComputeEnvironmentName")]
        public virtual void ResetComputeEnvironmentName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeEnvironmentNamePrefix")]
        public virtual void ResetComputeEnvironmentNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputeResources")]
        public virtual void ResetComputeResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEksConfiguration")]
        public virtual void ResetEksConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRole")]
        public virtual void ResetServiceRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdatePolicy")]
        public virtual void ResetUpdatePolicy()
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
        = GetStaticProperty<string>(typeof(aws.BatchComputeEnvironment.BatchComputeEnvironment))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeResources", typeJson: "{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentComputeResourcesOutputReference\"}")]
        public virtual aws.BatchComputeEnvironment.BatchComputeEnvironmentComputeResourcesOutputReference ComputeResources
        {
            get => GetInstanceProperty<aws.BatchComputeEnvironment.BatchComputeEnvironmentComputeResourcesOutputReference>()!;
        }

        [JsiiProperty(name: "ecsClusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EcsClusterArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eksConfiguration", typeJson: "{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentEksConfigurationOutputReference\"}")]
        public virtual aws.BatchComputeEnvironment.BatchComputeEnvironmentEksConfigurationOutputReference EksConfiguration
        {
            get => GetInstanceProperty<aws.BatchComputeEnvironment.BatchComputeEnvironmentEksConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatePolicy", typeJson: "{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicyOutputReference\"}")]
        public virtual aws.BatchComputeEnvironment.BatchComputeEnvironmentUpdatePolicyOutputReference UpdatePolicy
        {
            get => GetInstanceProperty<aws.BatchComputeEnvironment.BatchComputeEnvironmentUpdatePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeEnvironmentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeEnvironmentNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeEnvironmentNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeResourcesInput", typeJson: "{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentComputeResources\"}", isOptional: true)]
        public virtual aws.BatchComputeEnvironment.IBatchComputeEnvironmentComputeResources? ComputeResourcesInput
        {
            get => GetInstanceProperty<aws.BatchComputeEnvironment.IBatchComputeEnvironmentComputeResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eksConfigurationInput", typeJson: "{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentEksConfiguration\"}", isOptional: true)]
        public virtual aws.BatchComputeEnvironment.IBatchComputeEnvironmentEksConfiguration? EksConfigurationInput
        {
            get => GetInstanceProperty<aws.BatchComputeEnvironment.IBatchComputeEnvironmentEksConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updatePolicyInput", typeJson: "{\"fqn\":\"aws.batchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy\"}", isOptional: true)]
        public virtual aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy? UpdatePolicyInput
        {
            get => GetInstanceProperty<aws.BatchComputeEnvironment.IBatchComputeEnvironmentUpdatePolicy?>();
        }

        [JsiiProperty(name: "computeEnvironmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeEnvironmentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeEnvironmentNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeEnvironmentNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
