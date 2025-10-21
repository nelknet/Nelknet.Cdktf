using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsMedialiveInput
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/medialive_input aws_medialive_input}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsMedialiveInput.DataAwsMedialiveInput), fullyQualifiedName: "aws.dataAwsMedialiveInput.DataAwsMedialiveInput", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsMedialiveInput.DataAwsMedialiveInputConfig\"}}]")]
    public class DataAwsMedialiveInput : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/medialive_input aws_medialive_input} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMedialiveInput(Constructs.Construct scope, string id, aws.DataAwsMedialiveInput.IDataAwsMedialiveInputConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsMedialiveInput.IDataAwsMedialiveInputConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMedialiveInput(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMedialiveInput(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsMedialiveInput resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsMedialiveInput to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsMedialiveInput that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsMedialiveInput to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsMedialiveInput to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/medialive_input#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsMedialiveInput that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsMedialiveInput to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsMedialiveInput.DataAwsMedialiveInput), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsMedialiveInput.DataAwsMedialiveInput))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attachedChannels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttachedChannels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "destinations", typeJson: "{\"fqn\":\"aws.dataAwsMedialiveInput.DataAwsMedialiveInputDestinationsList\"}")]
        public virtual aws.DataAwsMedialiveInput.DataAwsMedialiveInputDestinationsList Destinations
        {
            get => GetInstanceProperty<aws.DataAwsMedialiveInput.DataAwsMedialiveInputDestinationsList>()!;
        }

        [JsiiProperty(name: "inputClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputClass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputDevices", typeJson: "{\"fqn\":\"aws.dataAwsMedialiveInput.DataAwsMedialiveInputInputDevicesList\"}")]
        public virtual aws.DataAwsMedialiveInput.DataAwsMedialiveInputInputDevicesList InputDevices
        {
            get => GetInstanceProperty<aws.DataAwsMedialiveInput.DataAwsMedialiveInputInputDevicesList>()!;
        }

        [JsiiProperty(name: "inputPartnerIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InputPartnerIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "inputSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputSourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mediaConnectFlows", typeJson: "{\"fqn\":\"aws.dataAwsMedialiveInput.DataAwsMedialiveInputMediaConnectFlowsList\"}")]
        public virtual aws.DataAwsMedialiveInput.DataAwsMedialiveInputMediaConnectFlowsList MediaConnectFlows
        {
            get => GetInstanceProperty<aws.DataAwsMedialiveInput.DataAwsMedialiveInputMediaConnectFlowsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sources", typeJson: "{\"fqn\":\"aws.dataAwsMedialiveInput.DataAwsMedialiveInputSourcesList\"}")]
        public virtual aws.DataAwsMedialiveInput.DataAwsMedialiveInputSourcesList Sources
        {
            get => GetInstanceProperty<aws.DataAwsMedialiveInput.DataAwsMedialiveInputSourcesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
