using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule azurerm_cdn_frontdoor_rule}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorRule.CdnFrontdoorRule), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConfig\"}}]")]
    public class CdnFrontdoorRule : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule azurerm_cdn_frontdoor_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CdnFrontdoorRule(Constructs.Construct scope, string id, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorRule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CdnFrontdoorRule resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CdnFrontdoorRule to import.</param>
        /// <param name="importFromId">The id of the existing CdnFrontdoorRule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CdnFrontdoorRule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CdnFrontdoorRule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CdnFrontdoorRule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CdnFrontdoorRule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.CdnFrontdoorRule.CdnFrontdoorRule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActions\"}}]")]
        public virtual void PutActions(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConditions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions\"}}]")]
        public virtual void PutConditions(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBehaviorOnMatch")]
        public virtual void ResetBehaviorOnMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConditions")]
        public virtual void ResetConditions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(azurerm.CdnFrontdoorRule.CdnFrontdoorRule))!;

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsOutputReference Actions
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleActionsOutputReference>()!;
        }

        [JsiiProperty(name: "cdnFrontdoorRuleSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdnFrontdoorRuleSetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditionsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsOutputReference Conditions
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleConditionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleTimeoutsOutputReference\"}")]
        public virtual azurerm.CdnFrontdoorRule.CdnFrontdoorRuleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.CdnFrontdoorRuleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionsInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions? ActionsInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "behaviorOnMatchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BehaviorOnMatchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdnFrontdoorRuleSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdnFrontdoorRuleSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionsInput", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleConditions\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions? ConditionsInput
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleConditions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OrderInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cdnFrontdoorRule.CdnFrontdoorRuleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "behaviorOnMatch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BehaviorOnMatch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cdnFrontdoorRuleSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdnFrontdoorRuleSetId
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
