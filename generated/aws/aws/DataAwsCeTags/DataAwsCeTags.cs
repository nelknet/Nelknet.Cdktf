using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCeTags
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags aws_ce_tags}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsCeTags.DataAwsCeTags), fullyQualifiedName: "aws.dataAwsCeTags.DataAwsCeTags", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsConfig\"}}]")]
    public class DataAwsCeTags : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags aws_ce_tags} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCeTags(Constructs.Construct scope, string id, aws.DataAwsCeTags.IDataAwsCeTagsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsCeTags.IDataAwsCeTagsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeTags(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCeTags(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsCeTags resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsCeTags to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsCeTags that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsCeTags to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsCeTags to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsCeTags that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsCeTags to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsCeTags.DataAwsCeTags), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilter\"}}]")]
        public virtual void PutFilter(aws.DataAwsCeTags.IDataAwsCeTagsFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSortBy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsSortBy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSortBy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsCeTags.IDataAwsCeTagsSortBy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsSortBy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsCeTags.IDataAwsCeTagsSortBy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimePeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsTimePeriod\"}}]")]
        public virtual void PutTimePeriod(aws.DataAwsCeTags.IDataAwsCeTagsTimePeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsCeTags.IDataAwsCeTagsTimePeriod)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchString")]
        public virtual void ResetSearchString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSortBy")]
        public virtual void ResetSortBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagKey")]
        public virtual void ResetTagKey()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsCeTags.DataAwsCeTags))!;

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilterOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsFilterOutputReference>()!;
        }

        [JsiiProperty(name: "sortBy", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsSortByList\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsSortByList SortBy
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsSortByList>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "timePeriod", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsTimePeriodOutputReference\"}")]
        public virtual aws.DataAwsCeTags.DataAwsCeTagsTimePeriodOutputReference TimePeriod
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.DataAwsCeTagsTimePeriodOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsFilter\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsFilter? FilterInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortByInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsSortBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SortByInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TagKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timePeriodInput", typeJson: "{\"fqn\":\"aws.dataAwsCeTags.DataAwsCeTagsTimePeriod\"}", isOptional: true)]
        public virtual aws.DataAwsCeTags.IDataAwsCeTagsTimePeriod? TimePeriodInput
        {
            get => GetInstanceProperty<aws.DataAwsCeTags.IDataAwsCeTagsTimePeriod?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TagKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
