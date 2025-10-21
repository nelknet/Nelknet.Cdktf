using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiClass(nativeType: typeof(aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesOutputReference), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Inspector2FilterFilterCriteriaVulnerablePackagesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Inspector2FilterFilterCriteriaVulnerablePackagesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Inspector2FilterFilterCriteriaVulnerablePackagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Inspector2FilterFilterCriteriaVulnerablePackagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArchitecture", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitecture\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutArchitecture(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesArchitecture[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesArchitecture).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesArchitecture).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEpoch", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpoch\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEpoch(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesEpoch[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesEpoch).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesEpoch).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilePath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilePath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesFilePath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesFilePath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesFilePath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelease", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesRelease\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRelease(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesRelease[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesRelease).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesRelease).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceLambdaLayerArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceLambdaLayerArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceLayerHash", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceLayerHash(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVersion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesVersion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesVersion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesVersion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArchitecture")]
        public virtual void ResetArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEpoch")]
        public virtual void ResetEpoch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilePath")]
        public virtual void ResetFilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelease")]
        public virtual void ResetRelease()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceLambdaLayerArn")]
        public virtual void ResetSourceLambdaLayerArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceLayerHash")]
        public virtual void ResetSourceLayerHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitectureList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitectureList Architecture
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitectureList>()!;
        }

        [JsiiProperty(name: "epoch", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpochList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpochList Epoch
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpochList>()!;
        }

        [JsiiProperty(name: "filePath", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePathList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePathList FilePath
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePathList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesNameList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesNameList Name
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesNameList>()!;
        }

        [JsiiProperty(name: "release", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesReleaseList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesReleaseList Release
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesReleaseList>()!;
        }

        [JsiiProperty(name: "sourceLambdaLayerArn", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArnList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArnList SourceLambdaLayerArn
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArnList>()!;
        }

        [JsiiProperty(name: "sourceLayerHash", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHashList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHashList SourceLayerHash
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHashList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersionList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersionList Version
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "architectureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ArchitectureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "epochInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpoch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EpochInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filePathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilePathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesRelease\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ReleaseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceLambdaLayerArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceLambdaLayerArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceLayerHashInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceLayerHashInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
