using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudCustomizedAccelerator
{
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryOutputReference), fullyQualifiedName: "azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpringCloudCustomizedAcceleratorGitRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpringCloudCustomizedAcceleratorGitRepositoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpringCloudCustomizedAcceleratorGitRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudCustomizedAcceleratorGitRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBasicAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryBasicAuth\"}}]")]
        public virtual void PutBasicAuth(azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositoryBasicAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositoryBasicAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSshAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositorySshAuth\"}}]")]
        public virtual void PutSshAuth(azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositorySshAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositorySshAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBasicAuth")]
        public virtual void ResetBasicAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBranch")]
        public virtual void ResetBranch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaCertificateId")]
        public virtual void ResetCaCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommit")]
        public virtual void ResetCommit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitTag")]
        public virtual void ResetGitTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntervalInSeconds")]
        public virtual void ResetIntervalInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshAuth")]
        public virtual void ResetSshAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "basicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryBasicAuthOutputReference\"}")]
        public virtual azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryBasicAuthOutputReference BasicAuth
        {
            get => GetInstanceProperty<azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryBasicAuthOutputReference>()!;
        }

        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositorySshAuthOutputReference\"}")]
        public virtual azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositorySshAuthOutputReference SshAuth
        {
            get => GetInstanceProperty<azurerm.SpringCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositorySshAuthOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicAuthInput", typeJson: "{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryBasicAuth\"}", isOptional: true)]
        public virtual azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositoryBasicAuth? BasicAuthInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositoryBasicAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BranchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "caCertificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CaCertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitTagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GitTagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshAuthInput", typeJson: "{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositorySshAuth\"}", isOptional: true)]
        public virtual azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositorySshAuth? SshAuthInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositorySshAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Branch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "caCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CaCertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "commit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Commit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gitTag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GitTag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepository\"}", isOptional: true)]
        public virtual azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepository? InternalValue
        {
            get => GetInstanceProperty<azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepository?>();
            set => SetInstanceProperty(value);
        }
    }
}
