using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelMetadata
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata azurerm_sentinel_metadata}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SentinelMetadata.SentinelMetadata), fullyQualifiedName: "azurerm.sentinelMetadata.SentinelMetadata", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataConfig\"}}]")]
    public class SentinelMetadata : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata azurerm_sentinel_metadata} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SentinelMetadata(Constructs.Construct scope, string id, azurerm.SentinelMetadata.ISentinelMetadataConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SentinelMetadata.ISentinelMetadataConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SentinelMetadata(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SentinelMetadata(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SentinelMetadata resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SentinelMetadata to import.</param>
        /// <param name="importFromId">The id of the existing SentinelMetadata that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SentinelMetadata to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SentinelMetadata to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_metadata#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SentinelMetadata that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SentinelMetadata to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.SentinelMetadata.SentinelMetadata), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthor", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataAuthor\"}}]")]
        public virtual void PutAuthor(azurerm.SentinelMetadata.ISentinelMetadataAuthor @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelMetadata.ISentinelMetadataAuthor)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataCategory\"}}]")]
        public virtual void PutCategory(azurerm.SentinelMetadata.ISentinelMetadataCategory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelMetadata.ISentinelMetadataCategory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataSource\"}}]")]
        public virtual void PutSource(azurerm.SentinelMetadata.ISentinelMetadataSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelMetadata.ISentinelMetadataSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSupport", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataSupport\"}}]")]
        public virtual void PutSupport(azurerm.SentinelMetadata.ISentinelMetadataSupport @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelMetadata.ISentinelMetadataSupport)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SentinelMetadata.ISentinelMetadataTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelMetadata.ISentinelMetadataTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthor")]
        public virtual void ResetAuthor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCategory")]
        public virtual void ResetCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentSchemaVersion")]
        public virtual void ResetContentSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomVersion")]
        public virtual void ResetCustomVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDependency")]
        public virtual void ResetDependency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstPublishDate")]
        public virtual void ResetFirstPublishDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIconId")]
        public virtual void ResetIconId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastPublishDate")]
        public virtual void ResetLastPublishDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreviewImages")]
        public virtual void ResetPreviewImages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreviewImagesDark")]
        public virtual void ResetPreviewImagesDark()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProviders")]
        public virtual void ResetProviders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSupport")]
        public virtual void ResetSupport()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatAnalysisTactics")]
        public virtual void ResetThreatAnalysisTactics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatAnalysisTechniques")]
        public virtual void ResetThreatAnalysisTechniques()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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
        = GetStaticProperty<string>(typeof(azurerm.SentinelMetadata.SentinelMetadata))!;

        [JsiiProperty(name: "author", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataAuthorOutputReference\"}")]
        public virtual azurerm.SentinelMetadata.SentinelMetadataAuthorOutputReference Author
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.SentinelMetadataAuthorOutputReference>()!;
        }

        [JsiiProperty(name: "category", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataCategoryOutputReference\"}")]
        public virtual azurerm.SentinelMetadata.SentinelMetadataCategoryOutputReference Category
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.SentinelMetadataCategoryOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataSourceOutputReference\"}")]
        public virtual azurerm.SentinelMetadata.SentinelMetadataSourceOutputReference Source
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.SentinelMetadataSourceOutputReference>()!;
        }

        [JsiiProperty(name: "support", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataSupportOutputReference\"}")]
        public virtual azurerm.SentinelMetadata.SentinelMetadataSupportOutputReference Support
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.SentinelMetadataSupportOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataTimeoutsOutputReference\"}")]
        public virtual azurerm.SentinelMetadata.SentinelMetadataTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.SentinelMetadataTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorInput", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataAuthor\"}", isOptional: true)]
        public virtual azurerm.SentinelMetadata.ISentinelMetadataAuthor? AuthorInput
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.ISentinelMetadataAuthor?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataCategory\"}", isOptional: true)]
        public virtual azurerm.SentinelMetadata.ISentinelMetadataCategory? CategoryInput
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.ISentinelMetadataCategory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dependencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DependencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstPublishDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstPublishDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iconIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IconIdInput
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
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastPublishDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastPublishDateInput
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
        [JsiiProperty(name: "parentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "previewImagesDarkInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreviewImagesDarkInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "previewImagesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreviewImagesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "providersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ProvidersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataSource\"}", isOptional: true)]
        public virtual azurerm.SentinelMetadata.ISentinelMetadataSource? SourceInput
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.ISentinelMetadataSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportInput", typeJson: "{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataSupport\"}", isOptional: true)]
        public virtual azurerm.SentinelMetadata.ISentinelMetadataSupport? SupportInput
        {
            get => GetInstanceProperty<azurerm.SentinelMetadata.ISentinelMetadataSupport?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatAnalysisTacticsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ThreatAnalysisTacticsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatAnalysisTechniquesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ThreatAnalysisTechniquesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.sentinelMetadata.SentinelMetadataTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workspaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkspaceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "contentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dependency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dependency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstPublishDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstPublishDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iconId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IconId
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

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastPublishDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastPublishDate
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

        [JsiiProperty(name: "parentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "previewImages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreviewImages
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "previewImagesDark", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreviewImagesDark
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "providers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Providers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threatAnalysisTactics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ThreatAnalysisTactics
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "threatAnalysisTechniques", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ThreatAnalysisTechniques
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
