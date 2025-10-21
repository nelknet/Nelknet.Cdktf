using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index aws_kendra_index}.</summary>
    [JsiiClass(nativeType: typeof(aws.KendraIndex.KendraIndex), fullyQualifiedName: "aws.kendraIndex.KendraIndex", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexConfig\"}}]")]
    public class KendraIndex : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index aws_kendra_index} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KendraIndex(Constructs.Construct scope, string id, aws.KendraIndex.IKendraIndexConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.KendraIndex.IKendraIndexConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndex(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndex(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KendraIndex resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KendraIndex to import.</param>
        /// <param name="importFromId">The id of the existing KendraIndex that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KendraIndex to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KendraIndex to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KendraIndex that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KendraIndex to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.KendraIndex.KendraIndex), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCapacityUnits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexCapacityUnits\"}}]")]
        public virtual void PutCapacityUnits(aws.KendraIndex.IKendraIndexCapacityUnits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexCapacityUnits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDocumentMetadataConfigurationUpdates", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdates\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDocumentMetadataConfigurationUpdates(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.KendraIndex.IKendraIndexDocumentMetadataConfigurationUpdates).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexServerSideEncryptionConfiguration\"}}]")]
        public virtual void PutServerSideEncryptionConfiguration(aws.KendraIndex.IKendraIndexServerSideEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexServerSideEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.KendraIndex.IKendraIndexTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserGroupResolutionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexUserGroupResolutionConfiguration\"}}]")]
        public virtual void PutUserGroupResolutionConfiguration(aws.KendraIndex.IKendraIndexUserGroupResolutionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexUserGroupResolutionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserTokenConfigurations", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurations\"}}]")]
        public virtual void PutUserTokenConfigurations(aws.KendraIndex.IKendraIndexUserTokenConfigurations @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KendraIndex.IKendraIndexUserTokenConfigurations)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityUnits")]
        public virtual void ResetCapacityUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentMetadataConfigurationUpdates")]
        public virtual void ResetDocumentMetadataConfigurationUpdates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdition")]
        public virtual void ResetEdition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryptionConfiguration")]
        public virtual void ResetServerSideEncryptionConfiguration()
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

        [JsiiMethod(name: "resetUserContextPolicy")]
        public virtual void ResetUserContextPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserGroupResolutionConfiguration")]
        public virtual void ResetUserGroupResolutionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserTokenConfigurations")]
        public virtual void ResetUserTokenConfigurations()
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
        = GetStaticProperty<string>(typeof(aws.KendraIndex.KendraIndex))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "capacityUnits", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexCapacityUnitsOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexCapacityUnitsOutputReference CapacityUnits
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexCapacityUnitsOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "documentMetadataConfigurationUpdates", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesList\"}")]
        public virtual aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesList DocumentMetadataConfigurationUpdates
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexDocumentMetadataConfigurationUpdatesList>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "indexStatistics", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexIndexStatisticsList\"}")]
        public virtual aws.KendraIndex.KendraIndexIndexStatisticsList IndexStatistics
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexIndexStatisticsList>()!;
        }

        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexServerSideEncryptionConfigurationOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexServerSideEncryptionConfigurationOutputReference ServerSideEncryptionConfiguration
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexServerSideEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexTimeoutsOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userGroupResolutionConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserGroupResolutionConfigurationOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexUserGroupResolutionConfigurationOutputReference UserGroupResolutionConfiguration
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexUserGroupResolutionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "userTokenConfigurations", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsOutputReference\"}")]
        public virtual aws.KendraIndex.KendraIndexUserTokenConfigurationsOutputReference UserTokenConfigurations
        {
            get => GetInstanceProperty<aws.KendraIndex.KendraIndexUserTokenConfigurationsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityUnitsInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexCapacityUnits\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexCapacityUnits? CapacityUnitsInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexCapacityUnits?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentMetadataConfigurationUpdatesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kendraIndex.KendraIndexDocumentMetadataConfigurationUpdates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DocumentMetadataConfigurationUpdatesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "editionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EditionInput
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
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexServerSideEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexServerSideEncryptionConfiguration? ServerSideEncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexServerSideEncryptionConfiguration?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.kendraIndex.KendraIndexTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userContextPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserContextPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userGroupResolutionConfigurationInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserGroupResolutionConfiguration\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexUserGroupResolutionConfiguration? UserGroupResolutionConfigurationInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserGroupResolutionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userTokenConfigurationsInput", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurations\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexUserTokenConfigurations? UserTokenConfigurationsInput
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurations?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Edition
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

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
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

        [JsiiProperty(name: "userContextPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserContextPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
