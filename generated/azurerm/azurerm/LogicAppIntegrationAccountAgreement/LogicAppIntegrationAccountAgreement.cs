using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LogicAppIntegrationAccountAgreement
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement azurerm_logic_app_integration_account_agreement}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement), fullyQualifiedName: "azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementConfig\"}}]")]
    public class LogicAppIntegrationAccountAgreement : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement azurerm_logic_app_integration_account_agreement} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LogicAppIntegrationAccountAgreement(Constructs.Construct scope, string id, azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogicAppIntegrationAccountAgreement(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LogicAppIntegrationAccountAgreement(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LogicAppIntegrationAccountAgreement resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LogicAppIntegrationAccountAgreement to import.</param>
        /// <param name="importFromId">The id of the existing LogicAppIntegrationAccountAgreement that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LogicAppIntegrationAccountAgreement to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LogicAppIntegrationAccountAgreement to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_agreement#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LogicAppIntegrationAccountAgreement that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LogicAppIntegrationAccountAgreement to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putGuestIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementGuestIdentity\"}}]")]
        public virtual void PutGuestIdentity(azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementGuestIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementGuestIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHostIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementHostIdentity\"}}]")]
        public virtual void PutHostIdentity(azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementHostIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementHostIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
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
        = GetStaticProperty<string>(typeof(azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreement))!;

        [JsiiProperty(name: "guestIdentity", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementGuestIdentityOutputReference\"}")]
        public virtual azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementGuestIdentityOutputReference GuestIdentity
        {
            get => GetInstanceProperty<azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementGuestIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "hostIdentity", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementHostIdentityOutputReference\"}")]
        public virtual azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementHostIdentityOutputReference HostIdentity
        {
            get => GetInstanceProperty<azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementHostIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementTimeoutsOutputReference\"}")]
        public virtual azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.LogicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agreementTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AgreementTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guestIdentityInput", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementGuestIdentity\"}", isOptional: true)]
        public virtual azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementGuestIdentity? GuestIdentityInput
        {
            get => GetInstanceProperty<azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementGuestIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guestPartnerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GuestPartnerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostIdentityInput", typeJson: "{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementHostIdentity\"}", isOptional: true)]
        public virtual azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementHostIdentity? HostIdentityInput
        {
            get => GetInstanceProperty<azurerm.LogicAppIntegrationAccountAgreement.ILogicAppIntegrationAccountAgreementHostIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostPartnerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostPartnerNameInput
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
        [JsiiProperty(name: "integrationAccountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationAccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.logicAppIntegrationAccountAgreement.LogicAppIntegrationAccountAgreementTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "agreementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgreementType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "guestPartnerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GuestPartnerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostPartnerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostPartnerName
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

        [JsiiProperty(name: "integrationAccountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationAccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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
