using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpointCustomDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain azurerm_cdn_endpoint_custom_domain}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain), fullyQualifiedName: "azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainConfig\"}}]")]
    public class CdnEndpointCustomDomain : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain azurerm_cdn_endpoint_custom_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CdnEndpointCustomDomain(Constructs.Construct scope, string id, azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnEndpointCustomDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnEndpointCustomDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CdnEndpointCustomDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CdnEndpointCustomDomain to import.</param>
        /// <param name="importFromId">The id of the existing CdnEndpointCustomDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CdnEndpointCustomDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CdnEndpointCustomDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint_custom_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CdnEndpointCustomDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CdnEndpointCustomDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCdnManagedHttps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps\"}}]")]
        public virtual void PutCdnManagedHttps(azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserManagedHttps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps\"}}]")]
        public virtual void PutUserManagedHttps(azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCdnManagedHttps")]
        public virtual void ResetCdnManagedHttps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserManagedHttps")]
        public virtual void ResetUserManagedHttps()
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
        = GetStaticProperty<string>(typeof(azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomain))!;

        [JsiiProperty(name: "cdnManagedHttps", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttpsOutputReference\"}")]
        public virtual azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttpsOutputReference CdnManagedHttps
        {
            get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttpsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainTimeoutsOutputReference\"}")]
        public virtual azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userManagedHttps", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttpsOutputReference\"}")]
        public virtual azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttpsOutputReference UserManagedHttps
        {
            get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttpsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdnEndpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdnEndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdnManagedHttpsInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainCdnManagedHttps\"}", isOptional: true)]
        public virtual azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps? CdnManagedHttpsInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainCdnManagedHttps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostNameInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userManagedHttpsInput", typeJson: "{\"fqn\":\"azurerm.cdnEndpointCustomDomain.CdnEndpointCustomDomainUserManagedHttps\"}", isOptional: true)]
        public virtual azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps? UserManagedHttpsInput
        {
            get => GetInstanceProperty<azurerm.CdnEndpointCustomDomain.ICdnEndpointCustomDomainUserManagedHttps?>();
        }

        [JsiiProperty(name: "cdnEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdnEndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
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
    }
}
