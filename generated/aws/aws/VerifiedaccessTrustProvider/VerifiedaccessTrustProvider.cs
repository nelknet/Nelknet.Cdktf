using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessTrustProvider
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider aws_verifiedaccess_trust_provider}.</summary>
    [JsiiClass(nativeType: typeof(aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider), fullyQualifiedName: "aws.verifiedaccessTrustProvider.VerifiedaccessTrustProvider", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderConfig\"}}]")]
    public class VerifiedaccessTrustProvider : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider aws_verifiedaccess_trust_provider} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VerifiedaccessTrustProvider(Constructs.Construct scope, string id, aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VerifiedaccessTrustProvider(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VerifiedaccessTrustProvider(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VerifiedaccessTrustProvider resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VerifiedaccessTrustProvider to import.</param>
        /// <param name="importFromId">The id of the existing VerifiedaccessTrustProvider that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VerifiedaccessTrustProvider to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VerifiedaccessTrustProvider to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_trust_provider#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VerifiedaccessTrustProvider that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VerifiedaccessTrustProvider to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeviceOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptions\"}}]")]
        public virtual void PutDeviceOptions(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderDeviceOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderDeviceOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNativeApplicationOidcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderNativeApplicationOidcOptions\"}}]")]
        public virtual void PutNativeApplicationOidcOptions(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderNativeApplicationOidcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderNativeApplicationOidcOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidcOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderOidcOptions\"}}]")]
        public virtual void PutOidcOptions(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderOidcOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderOidcOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSseSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderSseSpecification\"}}]")]
        public virtual void PutSseSpecification(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderSseSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderSseSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceOptions")]
        public virtual void ResetDeviceOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceTrustProviderType")]
        public virtual void ResetDeviceTrustProviderType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNativeApplicationOidcOptions")]
        public virtual void ResetNativeApplicationOidcOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcOptions")]
        public virtual void ResetOidcOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSseSpecification")]
        public virtual void ResetSseSpecification()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserTrustProviderType")]
        public virtual void ResetUserTrustProviderType()
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
        = GetStaticProperty<string>(typeof(aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProvider))!;

        [JsiiProperty(name: "deviceOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptionsOutputReference DeviceOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "nativeApplicationOidcOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderNativeApplicationOidcOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderNativeApplicationOidcOptionsOutputReference NativeApplicationOidcOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderNativeApplicationOidcOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "oidcOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderOidcOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderOidcOptionsOutputReference OidcOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderOidcOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sseSpecification", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderSseSpecificationOutputReference\"}")]
        public virtual aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderSseSpecificationOutputReference SseSpecification
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderSseSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderTimeoutsOutputReference\"}")]
        public virtual aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.VerifiedaccessTrustProviderTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderDeviceOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderDeviceOptions? DeviceOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderDeviceOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceTrustProviderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceTrustProviderTypeInput
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
        [JsiiProperty(name: "nativeApplicationOidcOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderNativeApplicationOidcOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderNativeApplicationOidcOptions? NativeApplicationOidcOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderNativeApplicationOidcOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderOidcOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderOidcOptions? OidcOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderOidcOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyReferenceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyReferenceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseSpecificationInput", typeJson: "{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderSseSpecification\"}", isOptional: true)]
        public virtual aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderSseSpecification? SseSpecificationInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessTrustProvider.IVerifiedaccessTrustProviderSseSpecification?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.verifiedaccessTrustProvider.VerifiedaccessTrustProviderTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustProviderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustProviderTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userTrustProviderTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserTrustProviderTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceTrustProviderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceTrustProviderType
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

        [JsiiProperty(name: "policyReferenceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyReferenceName
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

        [JsiiProperty(name: "trustProviderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustProviderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userTrustProviderType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserTrustProviderType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
