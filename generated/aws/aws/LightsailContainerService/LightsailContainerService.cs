using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailContainerService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service aws_lightsail_container_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.LightsailContainerService.LightsailContainerService), fullyQualifiedName: "aws.lightsailContainerService.LightsailContainerService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServiceConfig\"}}]")]
    public class LightsailContainerService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service aws_lightsail_container_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LightsailContainerService(Constructs.Construct scope, string id, aws.LightsailContainerService.ILightsailContainerServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LightsailContainerService.ILightsailContainerServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailContainerService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailContainerService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LightsailContainerService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LightsailContainerService to import.</param>
        /// <param name="importFromId">The id of the existing LightsailContainerService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LightsailContainerService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LightsailContainerService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LightsailContainerService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LightsailContainerService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LightsailContainerService.LightsailContainerService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPrivateRegistryAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccess\"}}]")]
        public virtual void PutPrivateRegistryAccess(aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPublicDomainNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePublicDomainNames\"}}]")]
        public virtual void PutPublicDomainNames(aws.LightsailContainerService.ILightsailContainerServicePublicDomainNames @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailContainerService.ILightsailContainerServicePublicDomainNames)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServiceTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LightsailContainerService.ILightsailContainerServiceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LightsailContainerService.ILightsailContainerServiceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDisabled")]
        public virtual void ResetIsDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateRegistryAccess")]
        public virtual void ResetPrivateRegistryAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicDomainNames")]
        public virtual void ResetPublicDomainNames()
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
        = GetStaticProperty<string>(typeof(aws.LightsailContainerService.LightsailContainerService))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "powerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PowerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principalArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateRegistryAccess", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccessOutputReference\"}")]
        public virtual aws.LightsailContainerService.LightsailContainerServicePrivateRegistryAccessOutputReference PrivateRegistryAccess
        {
            get => GetInstanceProperty<aws.LightsailContainerService.LightsailContainerServicePrivateRegistryAccessOutputReference>()!;
        }

        [JsiiProperty(name: "publicDomainNames", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePublicDomainNamesOutputReference\"}")]
        public virtual aws.LightsailContainerService.LightsailContainerServicePublicDomainNamesOutputReference PublicDomainNames
        {
            get => GetInstanceProperty<aws.LightsailContainerService.LightsailContainerServicePublicDomainNamesOutputReference>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServiceTimeoutsOutputReference\"}")]
        public virtual aws.LightsailContainerService.LightsailContainerServiceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LightsailContainerService.LightsailContainerServiceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isDisabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDisabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "powerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PowerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateRegistryAccessInput", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePrivateRegistryAccess\"}", isOptional: true)]
        public virtual aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess? PrivateRegistryAccessInput
        {
            get => GetInstanceProperty<aws.LightsailContainerService.ILightsailContainerServicePrivateRegistryAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicDomainNamesInput", typeJson: "{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServicePublicDomainNames\"}", isOptional: true)]
        public virtual aws.LightsailContainerService.ILightsailContainerServicePublicDomainNames? PublicDomainNamesInput
        {
            get => GetInstanceProperty<aws.LightsailContainerService.ILightsailContainerServicePublicDomainNames?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ScaleInput
        {
            get => GetInstanceProperty<double?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lightsailContainerService.LightsailContainerServiceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IsDisabled
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "power", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Power
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scale", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Scale
        {
            get => GetInstanceProperty<double>()!;
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
