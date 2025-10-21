using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackSetInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance aws_cloudformation_stack_set_instance}.</summary>
    [JsiiClass(nativeType: typeof(aws.CloudformationStackSetInstance.CloudformationStackSetInstance), fullyQualifiedName: "aws.cloudformationStackSetInstance.CloudformationStackSetInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceConfig\"}}]")]
    public class CloudformationStackSetInstance : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance aws_cloudformation_stack_set_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudformationStackSetInstance(Constructs.Construct scope, string id, aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationStackSetInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudformationStackSetInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CloudformationStackSetInstance resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CloudformationStackSetInstance to import.</param>
        /// <param name="importFromId">The id of the existing CloudformationStackSetInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CloudformationStackSetInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CloudformationStackSetInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CloudformationStackSetInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CloudformationStackSetInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CloudformationStackSetInstance.CloudformationStackSetInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeploymentTargets", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargets\"}}]")]
        public virtual void PutDeploymentTargets(aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceDeploymentTargets @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceDeploymentTargets)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOperationPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceOperationPreferences\"}}]")]
        public virtual void PutOperationPreferences(aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceOperationPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceOperationPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
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

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetainStack")]
        public virtual void ResetRetainStack()
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
        = GetStaticProperty<string>(typeof(aws.CloudformationStackSetInstance.CloudformationStackSetInstance))!;

        [JsiiProperty(name: "deploymentTargets", typeJson: "{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargetsOutputReference\"}")]
        public virtual aws.CloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargetsOutputReference DeploymentTargets
        {
            get => GetInstanceProperty<aws.CloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargetsOutputReference>()!;
        }

        [JsiiProperty(name: "operationPreferences", typeJson: "{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceOperationPreferencesOutputReference\"}")]
        public virtual aws.CloudformationStackSetInstance.CloudformationStackSetInstanceOperationPreferencesOutputReference OperationPreferences
        {
            get => GetInstanceProperty<aws.CloudformationStackSetInstance.CloudformationStackSetInstanceOperationPreferencesOutputReference>()!;
        }

        [JsiiProperty(name: "organizationalUnitId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationalUnitId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StackId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stackInstanceSummaries", typeJson: "{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceStackInstanceSummariesList\"}")]
        public virtual aws.CloudformationStackSetInstance.CloudformationStackSetInstanceStackInstanceSummariesList StackInstanceSummaries
        {
            get => GetInstanceProperty<aws.CloudformationStackSetInstance.CloudformationStackSetInstanceStackInstanceSummariesList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceTimeoutsOutputReference\"}")]
        public virtual aws.CloudformationStackSetInstance.CloudformationStackSetInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.CloudformationStackSetInstance.CloudformationStackSetInstanceTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "callAsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CallAsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentTargetsInput", typeJson: "{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargets\"}", isOptional: true)]
        public virtual aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceDeploymentTargets? DeploymentTargetsInput
        {
            get => GetInstanceProperty<aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceDeploymentTargets?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationPreferencesInput", typeJson: "{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceOperationPreferences\"}", isOptional: true)]
        public virtual aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceOperationPreferences? OperationPreferencesInput
        {
            get => GetInstanceProperty<aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceOperationPreferences?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterOverridesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParameterOverridesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainStackInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RetainStackInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.cloudformationStackSetInstance.CloudformationStackSetInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retainStack", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RetainStack
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
