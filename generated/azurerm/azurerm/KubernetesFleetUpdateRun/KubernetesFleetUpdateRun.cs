using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run azurerm_kubernetes_fleet_update_run}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun), fullyQualifiedName: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunConfig\"}}]")]
    public class KubernetesFleetUpdateRun : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run azurerm_kubernetes_fleet_update_run} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesFleetUpdateRun(Constructs.Construct scope, string id, azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesFleetUpdateRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesFleetUpdateRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KubernetesFleetUpdateRun resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KubernetesFleetUpdateRun to import.</param>
        /// <param name="importFromId">The id of the existing KubernetesFleetUpdateRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KubernetesFleetUpdateRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KubernetesFleetUpdateRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_update_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KubernetesFleetUpdateRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KubernetesFleetUpdateRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putManagedClusterUpdate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate\"}}]")]
        public virtual void PutManagedClusterUpdate(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStage", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunStage\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStage(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunStage[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunStage).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunStage).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFleetUpdateStrategyId")]
        public virtual void ResetFleetUpdateStrategyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStage")]
        public virtual void ResetStage()
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
        = GetStaticProperty<string>(typeof(azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRun))!;

        [JsiiProperty(name: "managedClusterUpdate", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateOutputReference\"}")]
        public virtual azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateOutputReference ManagedClusterUpdate
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdateOutputReference>()!;
        }

        [JsiiProperty(name: "stage", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunStageList\"}")]
        public virtual azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunStageList Stage
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunStageList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeoutsOutputReference\"}")]
        public virtual azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetUpdateStrategyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FleetUpdateStrategyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubernetesFleetManagerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KubernetesFleetManagerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedClusterUpdateInput", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate\"}", isOptional: true)]
        public virtual azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate? ManagedClusterUpdateInput
        {
            get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunStage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "fleetUpdateStrategyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FleetUpdateStrategyId
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

        [JsiiProperty(name: "kubernetesFleetManagerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubernetesFleetManagerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
