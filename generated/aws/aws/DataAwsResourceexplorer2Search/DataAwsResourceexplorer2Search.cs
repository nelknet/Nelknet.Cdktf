using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsResourceexplorer2Search
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourceexplorer2_search aws_resourceexplorer2_search}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search), fullyQualifiedName: "aws.dataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchConfig\"}}]")]
    public class DataAwsResourceexplorer2Search : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourceexplorer2_search aws_resourceexplorer2_search} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsResourceexplorer2Search(Constructs.Construct scope, string id, aws.DataAwsResourceexplorer2Search.IDataAwsResourceexplorer2SearchConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsResourceexplorer2Search.IDataAwsResourceexplorer2SearchConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourceexplorer2Search(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsResourceexplorer2Search(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsResourceexplorer2Search resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsResourceexplorer2Search to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsResourceexplorer2Search that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsResourceexplorer2Search to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsResourceexplorer2Search to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourceexplorer2_search#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsResourceexplorer2Search that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsResourceexplorer2Search to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetViewArn")]
        public virtual void ResetViewArn()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCount", typeJson: "{\"fqn\":\"aws.dataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchResourceCountList\"}")]
        public virtual aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchResourceCountList ResourceCount
        {
            get => GetInstanceProperty<aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchResourceCountList>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"aws.dataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchResourcesList\"}")]
        public virtual aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchResourcesList Resources
        {
            get => GetInstanceProperty<aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchResourcesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
