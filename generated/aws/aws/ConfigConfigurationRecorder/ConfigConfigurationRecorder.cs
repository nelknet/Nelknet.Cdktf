using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder aws_config_configuration_recorder}.</summary>
    [JsiiClass(nativeType: typeof(aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder), fullyQualifiedName: "aws.configConfigurationRecorder.ConfigConfigurationRecorder", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderConfig\"}}]")]
    public class ConfigConfigurationRecorder : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder aws_config_configuration_recorder} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConfigConfigurationRecorder(Constructs.Construct scope, string id, aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorder(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ConfigConfigurationRecorder resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ConfigConfigurationRecorder to import.</param>
        /// <param name="importFromId">The id of the existing ConfigConfigurationRecorder that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ConfigConfigurationRecorder to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ConfigConfigurationRecorder to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ConfigConfigurationRecorder that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ConfigConfigurationRecorder to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putRecordingGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroup\"}}]")]
        public virtual void PutRecordingGroup(aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecordingMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingMode\"}}]")]
        public virtual void PutRecordingMode(aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordingGroup")]
        public virtual void ResetRecordingGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordingMode")]
        public virtual void ResetRecordingMode()
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
        = GetStaticProperty<string>(typeof(aws.ConfigConfigurationRecorder.ConfigConfigurationRecorder))!;

        [JsiiProperty(name: "recordingGroup", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupOutputReference\"}")]
        public virtual aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupOutputReference RecordingGroup
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupOutputReference>()!;
        }

        [JsiiProperty(name: "recordingMode", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeOutputReference\"}")]
        public virtual aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingModeOutputReference RecordingMode
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingModeOutputReference>()!;
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
        [JsiiProperty(name: "recordingGroupInput", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroup\"}", isOptional: true)]
        public virtual aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroup? RecordingGroupInput
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordingModeInput", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingMode\"}", isOptional: true)]
        public virtual aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode? RecordingModeInput
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
