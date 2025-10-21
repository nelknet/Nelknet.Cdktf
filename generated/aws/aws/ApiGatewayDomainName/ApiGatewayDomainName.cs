using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayDomainName
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name aws_api_gateway_domain_name}.</summary>
    [JsiiClass(nativeType: typeof(aws.ApiGatewayDomainName.ApiGatewayDomainName), fullyQualifiedName: "aws.apiGatewayDomainName.ApiGatewayDomainName", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameConfig\"}}]")]
    public class ApiGatewayDomainName : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name aws_api_gateway_domain_name} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApiGatewayDomainName(Constructs.Construct scope, string id, aws.ApiGatewayDomainName.IApiGatewayDomainNameConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ApiGatewayDomainName.IApiGatewayDomainNameConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDomainName(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayDomainName(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ApiGatewayDomainName resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApiGatewayDomainName to import.</param>
        /// <param name="importFromId">The id of the existing ApiGatewayDomainName that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApiGatewayDomainName to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApiGatewayDomainName to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApiGatewayDomainName that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApiGatewayDomainName to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ApiGatewayDomainName.ApiGatewayDomainName), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEndpointConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameEndpointConfiguration\"}}]")]
        public virtual void PutEndpointConfiguration(aws.ApiGatewayDomainName.IApiGatewayDomainNameEndpointConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApiGatewayDomainName.IApiGatewayDomainNameEndpointConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMutualTlsAuthentication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthentication\"}}]")]
        public virtual void PutMutualTlsAuthentication(aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateBody")]
        public virtual void ResetCertificateBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateChain")]
        public virtual void ResetCertificateChain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateName")]
        public virtual void ResetCertificateName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificatePrivateKey")]
        public virtual void ResetCertificatePrivateKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointConfiguration")]
        public virtual void ResetEndpointConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMutualTlsAuthentication")]
        public virtual void ResetMutualTlsAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOwnershipVerificationCertificateArn")]
        public virtual void ResetOwnershipVerificationCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionalCertificateArn")]
        public virtual void ResetRegionalCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionalCertificateName")]
        public virtual void ResetRegionalCertificateName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityPolicy")]
        public virtual void ResetSecurityPolicy()
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
        = GetStaticProperty<string>(typeof(aws.ApiGatewayDomainName.ApiGatewayDomainName))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateUploadDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateUploadDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudfrontDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudfrontDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudfrontZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudfrontZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainNameId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainNameId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameEndpointConfigurationOutputReference\"}")]
        public virtual aws.ApiGatewayDomainName.ApiGatewayDomainNameEndpointConfigurationOutputReference EndpointConfiguration
        {
            get => GetInstanceProperty<aws.ApiGatewayDomainName.ApiGatewayDomainNameEndpointConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "mutualTlsAuthentication", typeJson: "{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthenticationOutputReference\"}")]
        public virtual aws.ApiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthenticationOutputReference MutualTlsAuthentication
        {
            get => GetInstanceProperty<aws.ApiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "regionalDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regionalZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateBodyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateBodyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateChainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateChainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatePrivateKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificatePrivateKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointConfigurationInput", typeJson: "{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameEndpointConfiguration\"}", isOptional: true)]
        public virtual aws.ApiGatewayDomainName.IApiGatewayDomainNameEndpointConfiguration? EndpointConfigurationInput
        {
            get => GetInstanceProperty<aws.ApiGatewayDomainName.IApiGatewayDomainNameEndpointConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mutualTlsAuthenticationInput", typeJson: "{\"fqn\":\"aws.apiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthentication\"}", isOptional: true)]
        public virtual aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication? MutualTlsAuthenticationInput
        {
            get => GetInstanceProperty<aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownershipVerificationCertificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnershipVerificationCertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionalCertificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionalCertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionalCertificateNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionalCertificateNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityPolicyInput
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

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateBody
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateChain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateChain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificatePrivateKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePrivateKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
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

        [JsiiProperty(name: "ownershipVerificationCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnershipVerificationCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionalCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionalCertificateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegionalCertificateName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityPolicy
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
