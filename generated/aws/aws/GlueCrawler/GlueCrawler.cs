using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCrawler
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler aws_glue_crawler}.</summary>
    [JsiiClass(nativeType: typeof(aws.GlueCrawler.GlueCrawler), fullyQualifiedName: "aws.glueCrawler.GlueCrawler", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerConfig\"}}]")]
    public class GlueCrawler : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler aws_glue_crawler} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueCrawler(Constructs.Construct scope, string id, aws.GlueCrawler.IGlueCrawlerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.GlueCrawler.IGlueCrawlerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCrawler(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCrawler(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a GlueCrawler resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the GlueCrawler to import.</param>
        /// <param name="importFromId">The id of the existing GlueCrawler that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the GlueCrawler to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the GlueCrawler to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_crawler#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing GlueCrawler that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the GlueCrawler to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.GlueCrawler.GlueCrawler), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCatalogTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCatalogTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerCatalogTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerCatalogTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerCatalogTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeltaTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerDeltaTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDeltaTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerDeltaTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerDeltaTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerDeltaTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDynamodbTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDynamodbTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerDynamodbTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerDynamodbTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerDynamodbTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHudiTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerHudiTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHudiTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerHudiTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerHudiTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerHudiTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIcebergTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerIcebergTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIcebergTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerIcebergTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerIcebergTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerIcebergTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJdbcTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJdbcTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerJdbcTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerJdbcTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerJdbcTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLakeFormationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerLakeFormationConfiguration\"}}]")]
        public virtual void PutLakeFormationConfiguration(aws.GlueCrawler.IGlueCrawlerLakeFormationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCrawler.IGlueCrawlerLakeFormationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLineageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerLineageConfiguration\"}}]")]
        public virtual void PutLineageConfiguration(aws.GlueCrawler.IGlueCrawlerLineageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCrawler.IGlueCrawlerLineageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMongodbTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerMongodbTarget\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMongodbTarget(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerMongodbTarget[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerMongodbTarget).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerMongodbTarget).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecrawlPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerRecrawlPolicy\"}}]")]
        public virtual void PutRecrawlPolicy(aws.GlueCrawler.IGlueCrawlerRecrawlPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCrawler.IGlueCrawlerRecrawlPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Target", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerS3Target\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutS3Target(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueCrawler.IGlueCrawlerS3Target[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerS3Target).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueCrawler.IGlueCrawlerS3Target).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaChangePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerSchemaChangePolicy\"}}]")]
        public virtual void PutSchemaChangePolicy(aws.GlueCrawler.IGlueCrawlerSchemaChangePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueCrawler.IGlueCrawlerSchemaChangePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogTarget")]
        public virtual void ResetCatalogTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClassifiers")]
        public virtual void ResetClassifiers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeltaTarget")]
        public virtual void ResetDeltaTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbTarget")]
        public virtual void ResetDynamodbTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHudiTarget")]
        public virtual void ResetHudiTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcebergTarget")]
        public virtual void ResetIcebergTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJdbcTarget")]
        public virtual void ResetJdbcTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLakeFormationConfiguration")]
        public virtual void ResetLakeFormationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLineageConfiguration")]
        public virtual void ResetLineageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongodbTarget")]
        public virtual void ResetMongodbTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecrawlPolicy")]
        public virtual void ResetRecrawlPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Target")]
        public virtual void ResetS3Target()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaChangePolicy")]
        public virtual void ResetSchemaChangePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablePrefix")]
        public virtual void ResetTablePrefix()
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
        = GetStaticProperty<string>(typeof(aws.GlueCrawler.GlueCrawler))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "catalogTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerCatalogTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerCatalogTargetList CatalogTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerCatalogTargetList>()!;
        }

        [JsiiProperty(name: "deltaTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerDeltaTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerDeltaTargetList DeltaTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerDeltaTargetList>()!;
        }

        [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerDynamodbTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerDynamodbTargetList DynamodbTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerDynamodbTargetList>()!;
        }

        [JsiiProperty(name: "hudiTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerHudiTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerHudiTargetList HudiTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerHudiTargetList>()!;
        }

        [JsiiProperty(name: "icebergTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerIcebergTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerIcebergTargetList IcebergTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerIcebergTargetList>()!;
        }

        [JsiiProperty(name: "jdbcTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerJdbcTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerJdbcTargetList JdbcTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerJdbcTargetList>()!;
        }

        [JsiiProperty(name: "lakeFormationConfiguration", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerLakeFormationConfigurationOutputReference\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerLakeFormationConfigurationOutputReference LakeFormationConfiguration
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerLakeFormationConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "lineageConfiguration", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerLineageConfigurationOutputReference\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerLineageConfigurationOutputReference LineageConfiguration
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerLineageConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "mongodbTarget", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerMongodbTargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerMongodbTargetList MongodbTarget
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerMongodbTargetList>()!;
        }

        [JsiiProperty(name: "recrawlPolicy", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerRecrawlPolicyOutputReference\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerRecrawlPolicyOutputReference RecrawlPolicy
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerRecrawlPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "s3Target", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerS3TargetList\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerS3TargetList S3Target
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerS3TargetList>()!;
        }

        [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerSchemaChangePolicyOutputReference\"}")]
        public virtual aws.GlueCrawler.GlueCrawlerSchemaChangePolicyOutputReference SchemaChangePolicy
        {
            get => GetInstanceProperty<aws.GlueCrawler.GlueCrawlerSchemaChangePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CatalogTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "classifiersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClassifiersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deltaTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerDeltaTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DeltaTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DynamodbTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hudiTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerHudiTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HudiTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icebergTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerIcebergTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IcebergTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jdbcTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JdbcTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lakeFormationConfigurationInput", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerLakeFormationConfiguration\"}", isOptional: true)]
        public virtual aws.GlueCrawler.IGlueCrawlerLakeFormationConfiguration? LakeFormationConfigurationInput
        {
            get => GetInstanceProperty<aws.GlueCrawler.IGlueCrawlerLakeFormationConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lineageConfigurationInput", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerLineageConfiguration\"}", isOptional: true)]
        public virtual aws.GlueCrawler.IGlueCrawlerLineageConfiguration? LineageConfigurationInput
        {
            get => GetInstanceProperty<aws.GlueCrawler.IGlueCrawlerLineageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongodbTargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerMongodbTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MongodbTargetInput
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
        [JsiiProperty(name: "recrawlPolicyInput", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerRecrawlPolicy\"}", isOptional: true)]
        public virtual aws.GlueCrawler.IGlueCrawlerRecrawlPolicy? RecrawlPolicyInput
        {
            get => GetInstanceProperty<aws.GlueCrawler.IGlueCrawlerRecrawlPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3TargetInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCrawler.GlueCrawlerS3Target\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? S3TargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaChangePolicyInput", typeJson: "{\"fqn\":\"aws.glueCrawler.GlueCrawlerSchemaChangePolicy\"}", isOptional: true)]
        public virtual aws.GlueCrawler.IGlueCrawlerSchemaChangePolicy? SchemaChangePolicyInput
        {
            get => GetInstanceProperty<aws.GlueCrawler.IGlueCrawlerSchemaChangePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TablePrefixInput
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

        [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Classifiers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
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

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TablePrefix
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
