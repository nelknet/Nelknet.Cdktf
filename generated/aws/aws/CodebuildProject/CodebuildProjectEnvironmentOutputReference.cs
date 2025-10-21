using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiClass(nativeType: typeof(aws.CodebuildProject.CodebuildProjectEnvironmentOutputReference), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectEnvironmentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodebuildProjectEnvironmentOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodebuildProjectEnvironmentOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectEnvironmentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectEnvironmentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnvironmentVariable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnvironmentVariable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CodebuildProject.ICodebuildProjectEnvironmentEnvironmentVariable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectEnvironmentEnvironmentVariable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CodebuildProject.ICodebuildProjectEnvironmentEnvironmentVariable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFleet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentFleet\"}}]")]
        public virtual void PutFleet(aws.CodebuildProject.ICodebuildProjectEnvironmentFleet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectEnvironmentFleet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegistryCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredential\"}}]")]
        public virtual void PutRegistryCredential(aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentVariable")]
        public virtual void ResetEnvironmentVariable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFleet")]
        public virtual void ResetFleet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImagePullCredentialsType")]
        public virtual void ResetImagePullCredentialsType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivilegedMode")]
        public virtual void ResetPrivilegedMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistryCredential")]
        public virtual void ResetRegistryCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "environmentVariable", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentEnvironmentVariableList\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectEnvironmentEnvironmentVariableList EnvironmentVariable
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectEnvironmentEnvironmentVariableList>()!;
        }

        [JsiiProperty(name: "fleet", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentFleetOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectEnvironmentFleetOutputReference Fleet
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectEnvironmentFleetOutputReference>()!;
        }

        [JsiiProperty(name: "registryCredential", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredentialOutputReference\"}")]
        public virtual aws.CodebuildProject.CodebuildProjectEnvironmentRegistryCredentialOutputReference RegistryCredential
        {
            get => GetInstanceProperty<aws.CodebuildProject.CodebuildProjectEnvironmentRegistryCredentialOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentVariableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentEnvironmentVariable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentVariableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fleetInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentFleet\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectEnvironmentFleet? FleetInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectEnvironmentFleet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imagePullCredentialsTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImagePullCredentialsTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privilegedModeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PrivilegedModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registryCredentialInput", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironmentRegistryCredential\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential? RegistryCredentialInput
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectEnvironmentRegistryCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imagePullCredentialsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImagePullCredentialsType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privilegedMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PrivilegedMode
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectEnvironment\"}", isOptional: true)]
        public virtual aws.CodebuildProject.ICodebuildProjectEnvironment? InternalValue
        {
            get => GetInstanceProperty<aws.CodebuildProject.ICodebuildProjectEnvironment?>();
            set => SetInstanceProperty(value);
        }
    }
}
