using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMonitorActionGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group azurerm_monitor_action_group}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup), fullyQualifiedName: "azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupConfig\"}}]")]
    public class DataAzurermMonitorActionGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group azurerm_monitor_action_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermMonitorActionGroup(Constructs.Construct scope, string id, azurerm.DataAzurermMonitorActionGroup.IDataAzurermMonitorActionGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermMonitorActionGroup.IDataAzurermMonitorActionGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorActionGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermMonitorActionGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermMonitorActionGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermMonitorActionGroup to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermMonitorActionGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermMonitorActionGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermMonitorActionGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermMonitorActionGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermMonitorActionGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermMonitorActionGroup.IDataAzurermMonitorActionGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermMonitorActionGroup.IDataAzurermMonitorActionGroupTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup))!;

        [JsiiProperty(name: "armRoleReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupArmRoleReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupArmRoleReceiverList ArmRoleReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupArmRoleReceiverList>()!;
        }

        [JsiiProperty(name: "automationRunbookReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAutomationRunbookReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAutomationRunbookReceiverList AutomationRunbookReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAutomationRunbookReceiverList>()!;
        }

        [JsiiProperty(name: "azureAppPushReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAzureAppPushReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAzureAppPushReceiverList AzureAppPushReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAzureAppPushReceiverList>()!;
        }

        [JsiiProperty(name: "azureFunctionReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAzureFunctionReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAzureFunctionReceiverList AzureFunctionReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupAzureFunctionReceiverList>()!;
        }

        [JsiiProperty(name: "emailReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupEmailReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupEmailReceiverList EmailReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupEmailReceiverList>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Enabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "eventHubReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupEventHubReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupEventHubReceiverList EventHubReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupEventHubReceiverList>()!;
        }

        [JsiiProperty(name: "itsmReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupItsmReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupItsmReceiverList ItsmReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupItsmReceiverList>()!;
        }

        [JsiiProperty(name: "logicAppReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupLogicAppReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupLogicAppReceiverList LogicAppReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupLogicAppReceiverList>()!;
        }

        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smsReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupSmsReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupSmsReceiverList SmsReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupSmsReceiverList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "voiceReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupVoiceReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupVoiceReceiverList VoiceReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupVoiceReceiverList>()!;
        }

        [JsiiProperty(name: "webhookReceiver", typeJson: "{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupWebhookReceiverList\"}")]
        public virtual azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupWebhookReceiverList WebhookReceiver
        {
            get => GetInstanceProperty<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupWebhookReceiverList>()!;
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
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
