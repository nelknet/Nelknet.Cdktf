using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceGlobalSettings
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings aws_chimesdkvoice_global_settings}.</summary>
    [JsiiClass(nativeType: typeof(aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings), fullyQualifiedName: "aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsConfig\"}}]")]
    public class ChimesdkvoiceGlobalSettings : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings aws_chimesdkvoice_global_settings} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ChimesdkvoiceGlobalSettings(Constructs.Construct scope, string id, aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimesdkvoiceGlobalSettings(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimesdkvoiceGlobalSettings(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ChimesdkvoiceGlobalSettings resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ChimesdkvoiceGlobalSettings to import.</param>
        /// <param name="importFromId">The id of the existing ChimesdkvoiceGlobalSettings that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ChimesdkvoiceGlobalSettings to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ChimesdkvoiceGlobalSettings to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_global_settings#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ChimesdkvoiceGlobalSettings that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ChimesdkvoiceGlobalSettings to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putVoiceConnector", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector\"}}]")]
        public virtual void PutVoiceConnector(aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettings))!;

        [JsiiProperty(name: "voiceConnector", typeJson: "{\"fqn\":\"aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference\"}")]
        public virtual aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference VoiceConnector
        {
            get => GetInstanceProperty<aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voiceConnectorInput", typeJson: "{\"fqn\":\"aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector\"}", isOptional: true)]
        public virtual aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector? VoiceConnectorInput
        {
            get => GetInstanceProperty<aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
