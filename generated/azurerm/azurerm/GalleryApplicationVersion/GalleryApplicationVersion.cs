using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.GalleryApplicationVersion
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version azurerm_gallery_application_version}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.GalleryApplicationVersion.GalleryApplicationVersion), fullyQualifiedName: "azurerm.galleryApplicationVersion.GalleryApplicationVersion", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionConfig\"}}]")]
    public class GalleryApplicationVersion : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version azurerm_gallery_application_version} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GalleryApplicationVersion(Constructs.Construct scope, string id, azurerm.GalleryApplicationVersion.IGalleryApplicationVersionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.GalleryApplicationVersion.IGalleryApplicationVersionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GalleryApplicationVersion(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GalleryApplicationVersion(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a GalleryApplicationVersion resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GalleryApplicationVersion to import.</param>
        /// <param name="importFromId">The id of the existing GalleryApplicationVersion that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GalleryApplicationVersion to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GalleryApplicationVersion to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GalleryApplicationVersion that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GalleryApplicationVersion to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.GalleryApplicationVersion.GalleryApplicationVersion), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putManageAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionManageAction\"}}]")]
        public virtual void PutManageAction(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionSource\"}}]")]
        public virtual void PutSource(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionTargetRegion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTargetRegion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTargetRegion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTargetRegion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTargetRegion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.GalleryApplicationVersion.IGalleryApplicationVersionTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfigFile")]
        public virtual void ResetConfigFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableHealthCheck")]
        public virtual void ResetEnableHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndOfLifeDate")]
        public virtual void ResetEndOfLifeDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludeFromLatest")]
        public virtual void ResetExcludeFromLatest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPackageFile")]
        public virtual void ResetPackageFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(azurerm.GalleryApplicationVersion.GalleryApplicationVersion))!;

        [JsiiProperty(name: "manageAction", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionManageActionOutputReference\"}")]
        public virtual azurerm.GalleryApplicationVersion.GalleryApplicationVersionManageActionOutputReference ManageAction
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.GalleryApplicationVersionManageActionOutputReference>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionSourceOutputReference\"}")]
        public virtual azurerm.GalleryApplicationVersion.GalleryApplicationVersionSourceOutputReference Source
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.GalleryApplicationVersionSourceOutputReference>()!;
        }

        [JsiiProperty(name: "targetRegion", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionTargetRegionList\"}")]
        public virtual azurerm.GalleryApplicationVersion.GalleryApplicationVersionTargetRegionList TargetRegion
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.GalleryApplicationVersionTargetRegionList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionTimeoutsOutputReference\"}")]
        public virtual azurerm.GalleryApplicationVersion.GalleryApplicationVersionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.GalleryApplicationVersionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableHealthCheckInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableHealthCheckInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endOfLifeDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndOfLifeDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeFromLatestInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ExcludeFromLatestInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "galleryApplicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GalleryApplicationIdInput
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
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "manageActionInput", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionManageAction\"}", isOptional: true)]
        public virtual azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction? ManageActionInput
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.IGalleryApplicationVersionManageAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PackageFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionSource\"}", isOptional: true)]
        public virtual azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource? SourceInput
        {
            get => GetInstanceProperty<azurerm.GalleryApplicationVersion.IGalleryApplicationVersionSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetRegionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionTargetRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetRegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.galleryApplicationVersion.GalleryApplicationVersionTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "configFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableHealthCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableHealthCheck
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "endOfLifeDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndOfLifeDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludeFromLatest", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ExcludeFromLatest
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "galleryApplicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GalleryApplicationId
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "packageFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
