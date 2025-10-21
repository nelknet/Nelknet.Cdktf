using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier aws_glue_classifier}.</summary>
    [JsiiClass(nativeType: typeof(aws.GlueClassifier.GlueClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifier", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glueClassifier.GlueClassifierConfig\"}}]")]
    public class GlueClassifier : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier aws_glue_classifier} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueClassifier(Constructs.Construct scope, string id, aws.GlueClassifier.IGlueClassifierConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.GlueClassifier.IGlueClassifierConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifier(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueClassifier(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a GlueClassifier resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GlueClassifier to import.</param>
        /// <param name="importFromId">The id of the existing GlueClassifier that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GlueClassifier to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GlueClassifier to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GlueClassifier that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GlueClassifier to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.GlueClassifier.GlueClassifier), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCsvClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifier\"}}]")]
        public virtual void PutCsvClassifier(aws.GlueClassifier.IGlueClassifierCsvClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueClassifier.IGlueClassifierCsvClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrokClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifier\"}}]")]
        public virtual void PutGrokClassifier(aws.GlueClassifier.IGlueClassifierGrokClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueClassifier.IGlueClassifierGrokClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJsonClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifier\"}}]")]
        public virtual void PutJsonClassifier(aws.GlueClassifier.IGlueClassifierJsonClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueClassifier.IGlueClassifierJsonClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXmlClassifier", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifier\"}}]")]
        public virtual void PutXmlClassifier(aws.GlueClassifier.IGlueClassifierXmlClassifier @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueClassifier.IGlueClassifierXmlClassifier)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCsvClassifier")]
        public virtual void ResetCsvClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrokClassifier")]
        public virtual void ResetGrokClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJsonClassifier")]
        public virtual void ResetJsonClassifier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXmlClassifier")]
        public virtual void ResetXmlClassifier()
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
        = GetStaticProperty<string>(typeof(aws.GlueClassifier.GlueClassifier))!;

        [JsiiProperty(name: "csvClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifierOutputReference\"}")]
        public virtual aws.GlueClassifier.GlueClassifierCsvClassifierOutputReference CsvClassifier
        {
            get => GetInstanceProperty<aws.GlueClassifier.GlueClassifierCsvClassifierOutputReference>()!;
        }

        [JsiiProperty(name: "grokClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifierOutputReference\"}")]
        public virtual aws.GlueClassifier.GlueClassifierGrokClassifierOutputReference GrokClassifier
        {
            get => GetInstanceProperty<aws.GlueClassifier.GlueClassifierGrokClassifierOutputReference>()!;
        }

        [JsiiProperty(name: "jsonClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifierOutputReference\"}")]
        public virtual aws.GlueClassifier.GlueClassifierJsonClassifierOutputReference JsonClassifier
        {
            get => GetInstanceProperty<aws.GlueClassifier.GlueClassifierJsonClassifierOutputReference>()!;
        }

        [JsiiProperty(name: "xmlClassifier", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifierOutputReference\"}")]
        public virtual aws.GlueClassifier.GlueClassifierXmlClassifierOutputReference XmlClassifier
        {
            get => GetInstanceProperty<aws.GlueClassifier.GlueClassifierXmlClassifierOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvClassifierInput", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierCsvClassifier\"}", isOptional: true)]
        public virtual aws.GlueClassifier.IGlueClassifierCsvClassifier? CsvClassifierInput
        {
            get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierCsvClassifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grokClassifierInput", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierGrokClassifier\"}", isOptional: true)]
        public virtual aws.GlueClassifier.IGlueClassifierGrokClassifier? GrokClassifierInput
        {
            get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierGrokClassifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonClassifierInput", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierJsonClassifier\"}", isOptional: true)]
        public virtual aws.GlueClassifier.IGlueClassifierJsonClassifier? JsonClassifierInput
        {
            get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierJsonClassifier?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xmlClassifierInput", typeJson: "{\"fqn\":\"aws.glueClassifier.GlueClassifierXmlClassifier\"}", isOptional: true)]
        public virtual aws.GlueClassifier.IGlueClassifierXmlClassifier? XmlClassifierInput
        {
            get => GetInstanceProperty<aws.GlueClassifier.IGlueClassifierXmlClassifier?>();
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
