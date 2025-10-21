using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAutomationVariables
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables azurerm_automation_variables}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables), fullyQualifiedName: "azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariables", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesConfig\"}}]")]
    public class DataAzurermAutomationVariables : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables azurerm_automation_variables} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermAutomationVariables(Constructs.Construct scope, string id, azurerm.DataAzurermAutomationVariables.IDataAzurermAutomationVariablesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermAutomationVariables.IDataAzurermAutomationVariablesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAutomationVariables(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermAutomationVariables(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermAutomationVariables resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermAutomationVariables to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermAutomationVariables that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermAutomationVariables to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermAutomationVariables to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_variables#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermAutomationVariables that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermAutomationVariables to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermAutomationVariables.IDataAzurermAutomationVariablesTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermAutomationVariables.IDataAzurermAutomationVariablesTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariables))!;

        [JsiiProperty(name: "bool", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesBoolList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesBoolList Bool
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesBoolList>()!;
        }

        [JsiiProperty(name: "datetime", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesDatetimeList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesDatetimeList Datetime
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesDatetimeList>()!;
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesEncryptedList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesEncryptedList Encrypted
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesEncryptedList>()!;
        }

        [JsiiProperty(name: "int", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesIntList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesIntList Int
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesIntList>()!;
        }

        [JsiiProperty(name: "null", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesNullList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesNullList Null
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesNullList>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesObjectList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesObjectList Object
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesObjectList>()!;
        }

        [JsiiProperty(name: "string", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesStringList\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesStringList String
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesStringList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomationAccountIdInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermAutomationVariables.DataAzurermAutomationVariablesTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "automationAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomationAccountId
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
    }
}
