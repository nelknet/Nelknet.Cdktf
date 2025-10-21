using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheReservedCacheNode
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node aws_elasticache_reserved_cache_node}.</summary>
    [JsiiClass(nativeType: typeof(aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode), fullyQualifiedName: "aws.elasticacheReservedCacheNode.ElasticacheReservedCacheNode", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elasticacheReservedCacheNode.ElasticacheReservedCacheNodeConfig\"}}]")]
    public class ElasticacheReservedCacheNode : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node aws_elasticache_reserved_cache_node} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ElasticacheReservedCacheNode(Constructs.Construct scope, string id, aws.ElasticacheReservedCacheNode.IElasticacheReservedCacheNodeConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ElasticacheReservedCacheNode.IElasticacheReservedCacheNodeConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheReservedCacheNode(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticacheReservedCacheNode(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ElasticacheReservedCacheNode resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ElasticacheReservedCacheNode to import.</param>
        /// <param name="importFromId">The id of the existing ElasticacheReservedCacheNode that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ElasticacheReservedCacheNode to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ElasticacheReservedCacheNode to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_reserved_cache_node#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ElasticacheReservedCacheNode that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ElasticacheReservedCacheNode to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticacheReservedCacheNode.ElasticacheReservedCacheNodeTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.ElasticacheReservedCacheNode.IElasticacheReservedCacheNodeTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ElasticacheReservedCacheNode.IElasticacheReservedCacheNodeTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCacheNodeCount")]
        public virtual void ResetCacheNodeCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNode))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cacheNodeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CacheNodeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Duration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fixedPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FixedPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "offeringType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OfferingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recurringCharges", typeJson: "{\"fqn\":\"aws.elasticacheReservedCacheNode.ElasticacheReservedCacheNodeRecurringChargesList\"}")]
        public virtual aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeRecurringChargesList RecurringCharges
        {
            get => GetInstanceProperty<aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeRecurringChargesList>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap TagsAll
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elasticacheReservedCacheNode.ElasticacheReservedCacheNodeTimeoutsOutputReference\"}")]
        public virtual aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.ElasticacheReservedCacheNode.ElasticacheReservedCacheNodeTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "usagePrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UsagePrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cacheNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CacheNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reservedCacheNodesOfferingIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReservedCacheNodesOfferingIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.elasticacheReservedCacheNode.ElasticacheReservedCacheNodeTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cacheNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CacheNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "reservedCacheNodesOfferingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReservedCacheNodesOfferingId
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
    }
}
