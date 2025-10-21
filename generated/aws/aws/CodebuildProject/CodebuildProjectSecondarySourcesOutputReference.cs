using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiClass(nativeType: typeof(aws.CodebuildProject.CodebuildProjectSecondarySourcesOutputReference), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSecondarySourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodebuildProjectSecondarySourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CodebuildProjectSecondarySourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CodebuildProjectSecondarySourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSecondarySourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesAuth\"}}]")]
        public virtual void PutAuth(aws.CodebuildProject.ICodebuildProjectSecondarySourcesAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectSecondarySourcesAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBuildStatusConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesBuildStatusConfig\"}}]")]
        public virtual void PutBuildStatusConfig(aws.CodebuildProject.ICodebuildProjectSecondarySourcesBuildStatusConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectSecondarySourcesBuildStatusConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitSubmodulesConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"}}]")]
        public virtual void PutGitSubmodulesConfig(aws.CodebuildProject.ICodebuildProjectSecondarySourcesGitSubmodulesConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectSecondarySourcesGitSubmodulesConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuth")]
        public virtual void ResetAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildspec")]
        public virtual void ResetBuildspec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildStatusConfig")]
        public virtual void ResetBuildStatusConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitCloneDepth")]
        public virtual void ResetGitCloneDepth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitSubmodulesConfig")]
        public virtual void ResetGitSubmodulesConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInsecureSsl")]
        public virtual void ResetInsecureSsl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocation")]
        public virtual void ResetLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReportBuildStatus")]
        public virtual void ResetReportBuildStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auth", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesAuthOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSecondarySourcesAuthOutputReference Auth
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSecondarySourcesAuthOutputReference>()!;
        }

        [JsiiProperty(name: "buildStatusConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesBuildStatusConfigOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSecondarySourcesBuildStatusConfigOutputReference BuildStatusConfig
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSecondarySourcesBuildStatusConfigOutputReference>()!;
        }

        [JsiiProperty(name: "gitSubmodulesConfig", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference GitSubmodulesConfig
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesAuth\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectSecondarySourcesAuth? AuthInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSecondarySourcesAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildspecInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildspecInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildStatusConfigInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesBuildStatusConfig\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectSecondarySourcesBuildStatusConfig? BuildStatusConfigInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSecondarySourcesBuildStatusConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitCloneDepthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GitCloneDepthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitSubmodulesConfigInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfig\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectSecondarySourcesGitSubmodulesConfig? GitSubmodulesConfigInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectSecondarySourcesGitSubmodulesConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "insecureSslInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InsecureSslInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reportBuildStatusInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ReportBuildStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "buildspec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Buildspec
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gitCloneDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GitCloneDepth
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "insecureSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InsecureSsl
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reportBuildStatus", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ReportBuildStatus
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

        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.codebuildProject.CodebuildProjectSecondarySources\"}]}}", isOptional: true)]
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
                        case aws.CodebuildProject.ICodebuildProjectSecondarySources cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectSecondarySources).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
