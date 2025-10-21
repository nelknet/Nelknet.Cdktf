using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    [JsiiClass(nativeType: typeof(aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference), fullyQualifiedName: "aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerServiceSourceConfigurationCodeRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}}]")]
        public virtual void PutCodeConfiguration(aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceCodeVersion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}}]")]
        public virtual void PutSourceCodeVersion(aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeConfiguration")]
        public virtual void ResetCodeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDirectory")]
        public virtual void ResetSourceDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference CodeConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersionOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersionOutputReference SourceCodeVersion
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceCodeVersionInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion? SourceCodeVersionInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository? InternalValue
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfigurationCodeRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
