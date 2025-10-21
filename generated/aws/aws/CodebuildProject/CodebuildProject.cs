using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project aws_codebuild_project}.</summary>
    [JsiiClass(nativeType: typeof(aws.CodebuildProject.CodebuildProject), fullyQualifiedName: "aws.codebuildProject.CodebuildProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectConfig\"}}]")]
    public class CodebuildProject : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project aws_codebuild_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodebuildProject(Constructs.Construct scope, string id, aws.CodebuildProject.ICodebuildProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CodebuildProject.ICodebuildProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CodebuildProject resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CodebuildProject to import.</param>
        /// <param name="importFromId">The id of the existing CodebuildProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CodebuildProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CodebuildProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CodebuildProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CodebuildProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CodebuildProject.CodebuildProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putArtifacts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectArtifacts\"}}]")]
        public virtual void PutArtifacts(aws.CodebuildProject.ICodebuildProjectArtifacts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectArtifacts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBuildBatchConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectBuildBatchConfig\"}}]")]
        public virtual void PutBuildBatchConfig(aws.CodebuildProject.ICodebuildProjectBuildBatchConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectBuildBatchConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCache", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectCache\"}}]")]
        public virtual void PutCache(aws.CodebuildProject.ICodebuildProjectCache @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectCache)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironment\"}}]")]
        public virtual void PutEnvironment(aws.CodebuildProject.ICodebuildProjectEnvironment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectEnvironment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFileSystemLocations", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectFileSystemLocations\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFileSystemLocations(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodebuildProject.ICodebuildProjectFileSystemLocations[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectFileSystemLocations).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectFileSystemLocations).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfig\"}}]")]
        public virtual void PutLogsConfig(aws.CodebuildProject.ICodebuildProjectLogsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectLogsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondaryArtifacts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondaryArtifacts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodebuildProject.ICodebuildProjectSecondaryArtifacts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondaryArtifacts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondaryArtifacts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondarySources", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondarySources(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodebuildProject.ICodebuildProjectSecondarySources[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySources).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySources).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondarySourceVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourceVersion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondarySourceVersion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodebuildProject.ICodebuildProjectSecondarySourceVersion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySourceVersion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySourceVersion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSource\"}}]")]
        public virtual void PutSource(aws.CodebuildProject.ICodebuildProjectSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectVpcConfig\"}}]")]
        public virtual void PutVpcConfig(aws.CodebuildProject.ICodebuildProjectVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBadgeEnabled")]
        public virtual void ResetBadgeEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildBatchConfig")]
        public virtual void ResetBuildBatchConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildTimeout")]
        public virtual void ResetBuildTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCache")]
        public virtual void ResetCache()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConcurrentBuildLimit")]
        public virtual void ResetConcurrentBuildLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionKey")]
        public virtual void ResetEncryptionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileSystemLocations")]
        public virtual void ResetFileSystemLocations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogsConfig")]
        public virtual void ResetLogsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProjectVisibility")]
        public virtual void ResetProjectVisibility()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueuedTimeout")]
        public virtual void ResetQueuedTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAccessRole")]
        public virtual void ResetResourceAccessRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryArtifacts")]
        public virtual void ResetSecondaryArtifacts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondarySources")]
        public virtual void ResetSecondarySources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondarySourceVersion")]
        public virtual void ResetSecondarySourceVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceVersion")]
        public virtual void ResetSourceVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcConfig")]
        public virtual void ResetVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.CodebuildProject.CodebuildProject))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "artifacts", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectArtifactsOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectArtifactsOutputReference Artifacts
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectArtifactsOutputReference>()!;
        }

        [JsiiProperty(name: "badgeUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BadgeUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "buildBatchConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectBuildBatchConfigOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectBuildBatchConfigOutputReference BuildBatchConfig
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectBuildBatchConfigOutputReference>()!;
        }

        [JsiiProperty(name: "cache", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectCacheOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectCacheOutputReference Cache
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectCacheOutputReference>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectEnvironmentOutputReference Environment
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectEnvironmentOutputReference>()!;
        }

        [JsiiProperty(name: "fileSystemLocations", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectFileSystemLocationsList\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectFileSystemLocationsList FileSystemLocations
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectFileSystemLocationsList>()!;
        }

        [JsiiProperty(name: "logsConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfigOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectLogsConfigOutputReference LogsConfig
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectLogsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "publicProjectAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicProjectAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryArtifacts", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondaryArtifactsList\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSecondaryArtifactsList SecondaryArtifacts
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSecondaryArtifactsList>()!;
        }

        [JsiiProperty(name: "secondarySources", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesList\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSecondarySourcesList SecondarySources
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSecondarySourcesList>()!;
        }

        [JsiiProperty(name: "secondarySourceVersion", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourceVersionList\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSecondarySourceVersionList SecondarySourceVersion
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSecondarySourceVersionList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSourceOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSourceOutputReference Source
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSourceOutputReference>()!;
        }

        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectVpcConfigOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectVpcConfigOutputReference VpcConfig
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "artifactsInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectArtifacts\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectArtifacts? ArtifactsInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectArtifacts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "badgeEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BadgeEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildBatchConfigInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectBuildBatchConfig\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectBuildBatchConfig? BuildBatchConfigInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectBuildBatchConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BuildTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectCache\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectCache? CacheInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectCache?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrentBuildLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConcurrentBuildLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironment\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectEnvironment? EnvironmentInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectEnvironment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemLocationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectFileSystemLocations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FileSystemLocationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsConfigInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectLogsConfig\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectLogsConfig? LogsConfigInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectLogsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectVisibilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectVisibilityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuedTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueuedTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAccessRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceAccessRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryArtifactsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondaryArtifacts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecondaryArtifactsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondarySourcesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecondarySourcesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondarySourceVersionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourceVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecondarySourceVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSource\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectSource? SourceInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcConfigInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectVpcConfig\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectVpcConfig? VpcConfigInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectVpcConfig?>();
        }

        [JsiiProperty(name: "badgeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BadgeEnabled
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

        [JsiiProperty(name: "buildTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BuildTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "concurrentBuildLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConcurrentBuildLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionKey
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

        [JsiiProperty(name: "projectVisibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectVisibility
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queuedTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueuedTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceAccessRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceAccessRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceVersion
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
