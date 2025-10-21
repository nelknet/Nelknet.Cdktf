using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint aws_verifiedaccess_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint), fullyQualifiedName: "aws.verifiedaccessEndpoint.VerifiedaccessEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointConfig\"}}]")]
    public class VerifiedaccessEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint aws_verifiedaccess_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VerifiedaccessEndpoint(Constructs.Construct scope, string id, aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VerifiedaccessEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VerifiedaccessEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VerifiedaccessEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VerifiedaccessEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing VerifiedaccessEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VerifiedaccessEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VerifiedaccessEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VerifiedaccessEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VerifiedaccessEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCidrOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointCidrOptions\"}}]")]
        public virtual void PutCidrOptions(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointCidrOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointCidrOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancerOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptions\"}}]")]
        public virtual void PutLoadBalancerOptions(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointLoadBalancerOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointLoadBalancerOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterfaceOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointNetworkInterfaceOptions\"}}]")]
        public virtual void PutNetworkInterfaceOptions(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointNetworkInterfaceOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointNetworkInterfaceOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRdsOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointRdsOptions\"}}]")]
        public virtual void PutRdsOptions(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointRdsOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointRdsOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSseSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointSseSpecification\"}}]")]
        public virtual void PutSseSpecification(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointSseSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointSseSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationDomain")]
        public virtual void ResetApplicationDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCidrOptions")]
        public virtual void ResetCidrOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomainCertificateArn")]
        public virtual void ResetDomainCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointDomainPrefix")]
        public virtual void ResetEndpointDomainPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancerOptions")]
        public virtual void ResetLoadBalancerOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaceOptions")]
        public virtual void ResetNetworkInterfaceOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyDocument")]
        public virtual void ResetPolicyDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRdsOptions")]
        public virtual void ResetRdsOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
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
        = GetStaticProperty<string>(typeof(aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint))!;

        [JsiiProperty(name: "cidrOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointCidrOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessEndpoint.VerifiedaccessEndpointCidrOptionsOutputReference CidrOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointCidrOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "deviceValidationDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceValidationDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loadBalancerOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptionsOutputReference LoadBalancerOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterfaceOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointNetworkInterfaceOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessEndpoint.VerifiedaccessEndpointNetworkInterfaceOptionsOutputReference NetworkInterfaceOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointNetworkInterfaceOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "rdsOptions", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointRdsOptionsOutputReference\"}")]
        public virtual aws.VerifiedaccessEndpoint.VerifiedaccessEndpointRdsOptionsOutputReference RdsOptions
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointRdsOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "sseSpecification", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointSseSpecificationOutputReference\"}")]
        public virtual aws.VerifiedaccessEndpoint.VerifiedaccessEndpointSseSpecificationOutputReference SseSpecification
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointSseSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointTimeoutsOutputReference\"}")]
        public virtual aws.VerifiedaccessEndpoint.VerifiedaccessEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "verifiedAccessInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifiedAccessInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attachmentTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttachmentTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointCidrOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointCidrOptions? CidrOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointCidrOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainCertificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainCertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointDomainPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointDomainPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointTypeInput
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
        [JsiiProperty(name: "loadBalancerOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointLoadBalancerOptions? LoadBalancerOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointLoadBalancerOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointNetworkInterfaceOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointNetworkInterfaceOptions? NetworkInterfaceOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointNetworkInterfaceOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdsOptionsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointRdsOptions\"}", isOptional: true)]
        public virtual aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointRdsOptions? RdsOptionsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointRdsOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sseSpecificationInput", typeJson: "{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointSseSpecification\"}", isOptional: true)]
        public virtual aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointSseSpecification? SseSpecificationInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointSseSpecification?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.verifiedaccessEndpoint.VerifiedaccessEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifiedAccessGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerifiedAccessGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachmentType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointDomainPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointDomainPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
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

        [JsiiProperty(name: "policyDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "verifiedAccessGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifiedAccessGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
