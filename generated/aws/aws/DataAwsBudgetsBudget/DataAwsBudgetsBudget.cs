using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsBudgetsBudget
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget aws_budgets_budget}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget), fullyQualifiedName: "aws.dataAwsBudgetsBudget.DataAwsBudgetsBudget", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetConfig\"}}]")]
    public class DataAwsBudgetsBudget : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget aws_budgets_budget} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsBudgetsBudget(Constructs.Construct scope, string id, aws.DataAwsBudgetsBudget.IDataAwsBudgetsBudgetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsBudgetsBudget.IDataAwsBudgetsBudgetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBudgetsBudget(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBudgetsBudget(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsBudgetsBudget resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsBudgetsBudget to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsBudgetsBudget that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsBudgetsBudget to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsBudgetsBudget to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/budgets_budget#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsBudgetsBudget that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsBudgetsBudget to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsBudgetsBudget.DataAwsBudgetsBudget))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoAdjustData", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetAutoAdjustDataList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetAutoAdjustDataList AutoAdjustData
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetAutoAdjustDataList>()!;
        }

        [JsiiProperty(name: "budgetExceeded", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable BudgetExceeded
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "budgetLimit", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetBudgetLimitList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetBudgetLimitList BudgetLimit
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetBudgetLimitList>()!;
        }

        [JsiiProperty(name: "budgetType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BudgetType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "calculatedSpend", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetCalculatedSpendList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetCalculatedSpendList CalculatedSpend
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetCalculatedSpendList>()!;
        }

        [JsiiProperty(name: "costFilter", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetCostFilterList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetCostFilterList CostFilter
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetCostFilterList>()!;
        }

        [JsiiProperty(name: "costTypes", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetCostTypesList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetCostTypesList CostTypes
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetCostTypesList>()!;
        }

        [JsiiProperty(name: "notification", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetNotificationList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetNotificationList Notification
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetNotificationList>()!;
        }

        [JsiiProperty(name: "plannedLimit", typeJson: "{\"fqn\":\"aws.dataAwsBudgetsBudget.DataAwsBudgetsBudgetPlannedLimitList\"}")]
        public virtual aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetPlannedLimitList PlannedLimit
        {
            get => GetInstanceProperty<aws.DataAwsBudgetsBudget.DataAwsBudgetsBudgetPlannedLimitList>()!;
        }

        [JsiiProperty(name: "timePeriodEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePeriodStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePeriodStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUnit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
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
    }
}
