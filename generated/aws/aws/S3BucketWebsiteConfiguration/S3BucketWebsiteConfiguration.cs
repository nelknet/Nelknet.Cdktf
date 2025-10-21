using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration aws_s3_bucket_website_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationConfig\"}}]")]
    public class S3BucketWebsiteConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration aws_s3_bucket_website_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketWebsiteConfiguration(Constructs.Construct scope, string id, aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketWebsiteConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketWebsiteConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a S3BucketWebsiteConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the S3BucketWebsiteConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing S3BucketWebsiteConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the S3BucketWebsiteConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the S3BucketWebsiteConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing S3BucketWebsiteConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the S3BucketWebsiteConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putErrorDocument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument\"}}]")]
        public virtual void PutErrorDocument(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndexDocument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument\"}}]")]
        public virtual void PutIndexDocument(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirectAllRequestsTo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsTo\"}}]")]
        public virtual void PutRedirectAllRequestsTo(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutingRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutingRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetErrorDocument")]
        public virtual void ResetErrorDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpectedBucketOwner")]
        public virtual void ResetExpectedBucketOwner()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexDocument")]
        public virtual void ResetIndexDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectAllRequestsTo")]
        public virtual void ResetRedirectAllRequestsTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingRule")]
        public virtual void ResetRoutingRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingRules")]
        public virtual void ResetRoutingRules()
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
        = GetStaticProperty<string>(typeof(aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration))!;

        [JsiiProperty(name: "errorDocument", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocumentOutputReference\"}")]
        public virtual aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocumentOutputReference ErrorDocument
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocumentOutputReference>()!;
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocumentOutputReference\"}")]
        public virtual aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocumentOutputReference IndexDocument
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocumentOutputReference>()!;
        }

        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsToOutputReference\"}")]
        public virtual aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsToOutputReference RedirectAllRequestsTo
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsToOutputReference>()!;
        }

        [JsiiProperty(name: "routingRule", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleList\"}")]
        public virtual aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleList RoutingRule
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleList>()!;
        }

        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorDocumentInput", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument\"}", isOptional: true)]
        public virtual aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument? ErrorDocumentInput
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationErrorDocument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expectedBucketOwnerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpectedBucketOwnerInput
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
        [JsiiProperty(name: "indexDocumentInput", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument\"}", isOptional: true)]
        public virtual aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument? IndexDocumentInput
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationIndexDocument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectAllRequestsToInput", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsTo\"}", isOptional: true)]
        public virtual aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo? RedirectAllRequestsToInput
        {
            get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRedirectAllRequestsTo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutingRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingRulesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingRulesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expectedBucketOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedBucketOwner
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

        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingRules
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
