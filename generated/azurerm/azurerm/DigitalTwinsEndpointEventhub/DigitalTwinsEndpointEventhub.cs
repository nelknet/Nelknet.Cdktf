using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DigitalTwinsEndpointEventhub
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub azurerm_digital_twins_endpoint_eventhub}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub), fullyQualifiedName: "azurerm.digitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.digitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubConfig\"}}]")]
    public class DigitalTwinsEndpointEventhub : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub azurerm_digital_twins_endpoint_eventhub} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DigitalTwinsEndpointEventhub(Constructs.Construct scope, string id, azurerm.DigitalTwinsEndpointEventhub.IDigitalTwinsEndpointEventhubConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DigitalTwinsEndpointEventhub.IDigitalTwinsEndpointEventhubConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DigitalTwinsEndpointEventhub(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DigitalTwinsEndpointEventhub(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DigitalTwinsEndpointEventhub resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DigitalTwinsEndpointEventhub to import.</param>
        /// <param name="importFromId">The id of the existing DigitalTwinsEndpointEventhub that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DigitalTwinsEndpointEventhub to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DigitalTwinsEndpointEventhub to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DigitalTwinsEndpointEventhub that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DigitalTwinsEndpointEventhub to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.digitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DigitalTwinsEndpointEventhub.IDigitalTwinsEndpointEventhubTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DigitalTwinsEndpointEventhub.IDigitalTwinsEndpointEventhubTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeadLetterStorageSecret")]
        public virtual void ResetDeadLetterStorageSecret()
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
        = GetStaticProperty<string>(typeof(azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.digitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubTimeoutsOutputReference\"}")]
        public virtual azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterStorageSecretInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeadLetterStorageSecretInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "digitalTwinsIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DigitalTwinsIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventhubPrimaryConnectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventhubPrimaryConnectionStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventhubSecondaryConnectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventhubSecondaryConnectionStringInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.digitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "deadLetterStorageSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeadLetterStorageSecret
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "digitalTwinsId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DigitalTwinsId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventhubPrimaryConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventhubPrimaryConnectionString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventhubSecondaryConnectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventhubSecondaryConnectionString
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
    }
}
