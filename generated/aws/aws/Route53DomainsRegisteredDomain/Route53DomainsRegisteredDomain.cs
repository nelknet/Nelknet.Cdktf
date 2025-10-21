using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsRegisteredDomain
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain aws_route53domains_registered_domain}.</summary>
    [JsiiClass(nativeType: typeof(aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain), fullyQualifiedName: "aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainConfig\"}}]")]
    public class Route53DomainsRegisteredDomain : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain aws_route53domains_registered_domain} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Route53DomainsRegisteredDomain(Constructs.Construct scope, string id, aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53DomainsRegisteredDomain(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53DomainsRegisteredDomain(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a Route53DomainsRegisteredDomain resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Route53DomainsRegisteredDomain to import.</param>
        /// <param name="importFromId">The id of the existing Route53DomainsRegisteredDomain that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Route53DomainsRegisteredDomain to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Route53DomainsRegisteredDomain to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_registered_domain#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Route53DomainsRegisteredDomain that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Route53DomainsRegisteredDomain to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdminContact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContact\"}}]")]
        public virtual void PutAdminContact(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainAdminContact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainAdminContact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBillingContact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainBillingContact\"}}]")]
        public virtual void PutBillingContact(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainBillingContact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainBillingContact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNameServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServer\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNameServer(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainNameServer[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainNameServer).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainNameServer).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegistrantContact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainRegistrantContact\"}}]")]
        public virtual void PutRegistrantContact(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainRegistrantContact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainRegistrantContact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTechContact", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTechContact\"}}]")]
        public virtual void PutTechContact(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainTechContact @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainTechContact)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdminContact")]
        public virtual void ResetAdminContact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminPrivacy")]
        public virtual void ResetAdminPrivacy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoRenew")]
        public virtual void ResetAutoRenew()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillingContact")]
        public virtual void ResetBillingContact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBillingPrivacy")]
        public virtual void ResetBillingPrivacy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNameServer")]
        public virtual void ResetNameServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistrantContact")]
        public virtual void ResetRegistrantContact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegistrantPrivacy")]
        public virtual void ResetRegistrantPrivacy()
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

        [JsiiMethod(name: "resetTechContact")]
        public virtual void ResetTechContact()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTechPrivacy")]
        public virtual void ResetTechPrivacy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransferLock")]
        public virtual void ResetTransferLock()
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
        = GetStaticProperty<string>(typeof(aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomain))!;

        [JsiiProperty(name: "abuseContactEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AbuseContactEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "abuseContactPhone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AbuseContactPhone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminContact", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContactOutputReference\"}")]
        public virtual aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContactOutputReference AdminContact
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContactOutputReference>()!;
        }

        [JsiiProperty(name: "billingContact", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainBillingContactOutputReference\"}")]
        public virtual aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainBillingContactOutputReference BillingContact
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainBillingContactOutputReference>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expirationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpirationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameServer", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServerList\"}")]
        public virtual aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServerList NameServer
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServerList>()!;
        }

        [JsiiProperty(name: "registrantContact", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainRegistrantContactOutputReference\"}")]
        public virtual aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainRegistrantContactOutputReference RegistrantContact
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainRegistrantContactOutputReference>()!;
        }

        [JsiiProperty(name: "registrarName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrarName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registrarUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrarUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reseller", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reseller
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StatusList
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "techContact", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTechContactOutputReference\"}")]
        public virtual aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTechContactOutputReference TechContact
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTechContactOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTimeoutsOutputReference\"}")]
        public virtual aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updatedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "whoisServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WhoisServer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminContactInput", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainAdminContact\"}", isOptional: true)]
        public virtual aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainAdminContact? AdminContactInput
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainAdminContact?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPrivacyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AdminPrivacyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRenewInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoRenewInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingContactInput", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainBillingContact\"}", isOptional: true)]
        public virtual aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainBillingContact? BillingContactInput
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainBillingContact?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingPrivacyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BillingPrivacyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
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
        [JsiiProperty(name: "nameServerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainNameServer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NameServerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registrantContactInput", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainRegistrantContact\"}", isOptional: true)]
        public virtual aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainRegistrantContact? RegistrantContactInput
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainRegistrantContact?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "registrantPrivacyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RegistrantPrivacyInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "techContactInput", typeJson: "{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTechContact\"}", isOptional: true)]
        public virtual aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainTechContact? TechContactInput
        {
            get => GetInstanceProperty<aws.Route53DomainsRegisteredDomain.IRoute53DomainsRegisteredDomainTechContact?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "techPrivacyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TechPrivacyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.route53DomainsRegisteredDomain.Route53DomainsRegisteredDomainTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transferLockInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TransferLockInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "adminPrivacy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AdminPrivacy
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

        [JsiiProperty(name: "autoRenew", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoRenew
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

        [JsiiProperty(name: "billingPrivacy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BillingPrivacy
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

        [JsiiProperty(name: "registrantPrivacy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RegistrantPrivacy
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

        [JsiiProperty(name: "techPrivacy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TechPrivacy
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

        [JsiiProperty(name: "transferLock", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TransferLock
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
    }
}
