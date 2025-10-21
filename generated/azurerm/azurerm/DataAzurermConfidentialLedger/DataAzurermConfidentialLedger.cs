using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermConfidentialLedger
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger azurerm_confidential_ledger}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger), fullyQualifiedName: "azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedger", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerConfig\"}}]")]
    public class DataAzurermConfidentialLedger : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger azurerm_confidential_ledger} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermConfidentialLedger(Constructs.Construct scope, string id, azurerm.DataAzurermConfidentialLedger.IDataAzurermConfidentialLedgerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermConfidentialLedger.IDataAzurermConfidentialLedgerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermConfidentialLedger(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermConfidentialLedger(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermConfidentialLedger resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermConfidentialLedger to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermConfidentialLedger that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermConfidentialLedger to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermConfidentialLedger to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermConfidentialLedger that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermConfidentialLedger to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermConfidentialLedger.IDataAzurermConfidentialLedgerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermConfidentialLedger.IDataAzurermConfidentialLedgerTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger))!;

        [JsiiProperty(name: "azureadBasedServicePrincipal", typeJson: "{\"fqn\":\"azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerAzureadBasedServicePrincipalList\"}")]
        public virtual azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerAzureadBasedServicePrincipalList AzureadBasedServicePrincipal
        {
            get => GetInstanceProperty<azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerAzureadBasedServicePrincipalList>()!;
        }

        [JsiiProperty(name: "certificateBasedSecurityPrincipal", typeJson: "{\"fqn\":\"azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerCertificateBasedSecurityPrincipalList\"}")]
        public virtual azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerCertificateBasedSecurityPrincipalList CertificateBasedSecurityPrincipal
        {
            get => GetInstanceProperty<azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerCertificateBasedSecurityPrincipalList>()!;
        }

        [JsiiProperty(name: "identityServiceEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityServiceEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ledgerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LedgerEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ledgerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LedgerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeouts\"}]}}", isOptional: true)]
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
