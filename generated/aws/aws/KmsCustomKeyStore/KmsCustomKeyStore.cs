using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KmsCustomKeyStore
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store aws_kms_custom_key_store}.</summary>
    [JsiiClass(nativeType: typeof(aws.KmsCustomKeyStore.KmsCustomKeyStore), fullyQualifiedName: "aws.kmsCustomKeyStore.KmsCustomKeyStore", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreConfig\"}}]")]
    public class KmsCustomKeyStore : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store aws_kms_custom_key_store} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KmsCustomKeyStore(Constructs.Construct scope, string id, aws.KmsCustomKeyStore.IKmsCustomKeyStoreConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.KmsCustomKeyStore.IKmsCustomKeyStoreConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsCustomKeyStore(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsCustomKeyStore(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KmsCustomKeyStore resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KmsCustomKeyStore to import.</param>
        /// <param name="importFromId">The id of the existing KmsCustomKeyStore that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KmsCustomKeyStore to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KmsCustomKeyStore to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_custom_key_store#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KmsCustomKeyStore that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KmsCustomKeyStore to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.KmsCustomKeyStore.KmsCustomKeyStore), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.KmsCustomKeyStore.IKmsCustomKeyStoreTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KmsCustomKeyStore.IKmsCustomKeyStoreTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXksProxyAuthenticationCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredential\"}}]")]
        public virtual void PutXksProxyAuthenticationCredential(aws.KmsCustomKeyStore.IKmsCustomKeyStoreXksProxyAuthenticationCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KmsCustomKeyStore.IKmsCustomKeyStoreXksProxyAuthenticationCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudHsmClusterId")]
        public virtual void ResetCloudHsmClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomKeyStoreType")]
        public virtual void ResetCustomKeyStoreType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyStorePassword")]
        public virtual void ResetKeyStorePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustAnchorCertificate")]
        public virtual void ResetTrustAnchorCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXksProxyAuthenticationCredential")]
        public virtual void ResetXksProxyAuthenticationCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXksProxyConnectivity")]
        public virtual void ResetXksProxyConnectivity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXksProxyUriEndpoint")]
        public virtual void ResetXksProxyUriEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXksProxyUriPath")]
        public virtual void ResetXksProxyUriPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXksProxyVpcEndpointServiceName")]
        public virtual void ResetXksProxyVpcEndpointServiceName()
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
        = GetStaticProperty<string>(typeof(aws.KmsCustomKeyStore.KmsCustomKeyStore))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreTimeoutsOutputReference\"}")]
        public virtual aws.KmsCustomKeyStore.KmsCustomKeyStoreTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.KmsCustomKeyStore.KmsCustomKeyStoreTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "xksProxyAuthenticationCredential", typeJson: "{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredentialOutputReference\"}")]
        public virtual aws.KmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredentialOutputReference XksProxyAuthenticationCredential
        {
            get => GetInstanceProperty<aws.KmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredentialOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudHsmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudHsmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customKeyStoreNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomKeyStoreNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customKeyStoreTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomKeyStoreTypeInput
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
        [JsiiProperty(name: "keyStorePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyStorePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustAnchorCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustAnchorCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xksProxyAuthenticationCredentialInput", typeJson: "{\"fqn\":\"aws.kmsCustomKeyStore.KmsCustomKeyStoreXksProxyAuthenticationCredential\"}", isOptional: true)]
        public virtual aws.KmsCustomKeyStore.IKmsCustomKeyStoreXksProxyAuthenticationCredential? XksProxyAuthenticationCredentialInput
        {
            get => GetInstanceProperty<aws.KmsCustomKeyStore.IKmsCustomKeyStoreXksProxyAuthenticationCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xksProxyConnectivityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? XksProxyConnectivityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xksProxyUriEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? XksProxyUriEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xksProxyUriPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? XksProxyUriPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xksProxyVpcEndpointServiceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? XksProxyVpcEndpointServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cloudHsmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudHsmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customKeyStoreName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomKeyStoreName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customKeyStoreType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomKeyStoreType
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

        [JsiiProperty(name: "keyStorePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStorePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustAnchorCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustAnchorCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xksProxyConnectivity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XksProxyConnectivity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xksProxyUriEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XksProxyUriEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xksProxyUriPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XksProxyUriPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "xksProxyVpcEndpointServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XksProxyVpcEndpointServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
