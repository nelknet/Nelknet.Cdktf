using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackInstances
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances aws_cloudformation_stack_instances}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudformationStackInstances.CloudformationStackInstances), fullyQualifiedName: "aws.cloudformationStackInstances.CloudformationStackInstances", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesConfig\"}}]")]
    public class CloudformationStackInstances : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances aws_cloudformation_stack_instances} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudformationStackInstances(Constructs.Construct scope, string id, aws.CloudformationStackInstances.ICloudformationStackInstancesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudformationStackInstances.ICloudformationStackInstancesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationStackInstances(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationStackInstances(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudformationStackInstances resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudformationStackInstances to import.</param>
        /// <param name="importFromId">The id of the existing CloudformationStackInstances that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudformationStackInstances to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudformationStackInstances to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudformationStackInstances that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudformationStackInstances to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudformationStackInstances.CloudformationStackInstances), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeploymentTargets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesDeploymentTargets\"}}]")]
        public virtual void PutDeploymentTargets(aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOperationPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferences\"}}]")]
        public virtual void PutOperationPreferences(aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.CloudformationStackInstances.ICloudformationStackInstancesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudformationStackInstances.ICloudformationStackInstancesTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccounts")]
        public virtual void ResetAccounts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCallAs")]
        public virtual void ResetCallAs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentTargets")]
        public virtual void ResetDeploymentTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOperationPreferences")]
        public virtual void ResetOperationPreferences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameterOverrides")]
        public virtual void ResetParameterOverrides()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegions")]
        public virtual void ResetRegions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetainStacks")]
        public virtual void ResetRetainStacks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.CloudformationStackInstances.CloudformationStackInstances))!;

        [JsiiProperty(name: "deploymentTargets", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesDeploymentTargetsOutputReference\"}")]
        public virtual aws.CloudformationStackInstances.CloudformationStackInstancesDeploymentTargetsOutputReference DeploymentTargets
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.CloudformationStackInstancesDeploymentTargetsOutputReference>()!;
        }

        [JsiiProperty(name: "operationPreferences", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferencesOutputReference\"}")]
        public virtual aws.CloudformationStackInstances.CloudformationStackInstancesOperationPreferencesOutputReference OperationPreferences
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.CloudformationStackInstancesOperationPreferencesOutputReference>()!;
        }

        [JsiiProperty(name: "stackInstanceSummaries", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesStackInstanceSummariesList\"}")]
        public virtual aws.CloudformationStackInstances.CloudformationStackInstancesStackInstanceSummariesList StackInstanceSummaries
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.CloudformationStackInstancesStackInstanceSummariesList>()!;
        }

        [JsiiProperty(name: "stackSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackSetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesTimeoutsOutputReference\"}")]
        public virtual aws.CloudformationStackInstances.CloudformationStackInstancesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.CloudformationStackInstancesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AccountsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "callAsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CallAsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentTargetsInput", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesDeploymentTargets\"}", isOptional: true)]
        public virtual aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets? DeploymentTargetsInput
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationPreferencesInput", typeJson: "{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferences\"}", isOptional: true)]
        public virtual aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences? OperationPreferencesInput
        {
            get => GetInstanceProperty<aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterOverridesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParameterOverridesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RegionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainStacksInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RetainStacksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stackSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StackSetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.cloudformationStackInstances.CloudformationStackInstancesTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Accounts
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "callAs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallAs
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

        [JsiiProperty(name: "parameterOverrides", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ParameterOverrides
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Regions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retainStacks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RetainStacks
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "stackSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackSetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
