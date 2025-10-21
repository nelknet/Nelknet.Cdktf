using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbProxyDefaultTargetGroup
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group aws_db_proxy_default_target_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup), fullyQualifiedName: "aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConfig\"}}]")]
    public class DbProxyDefaultTargetGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group aws_db_proxy_default_target_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DbProxyDefaultTargetGroup(Constructs.Construct scope, string id, aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbProxyDefaultTargetGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbProxyDefaultTargetGroup(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DbProxyDefaultTargetGroup resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DbProxyDefaultTargetGroup to import.</param>
        /// <param name="importFromId">The id of the existing DbProxyDefaultTargetGroup that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DbProxyDefaultTargetGroup to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DbProxyDefaultTargetGroup to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy_default_target_group#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DbProxyDefaultTargetGroup that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DbProxyDefaultTargetGroup to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putConnectionPoolConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfig\"}}]")]
        public virtual void PutConnectionPoolConfig(aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionPoolConfig")]
        public virtual void ResetConnectionPoolConfig()
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
        = GetStaticProperty<string>(typeof(aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionPoolConfig", typeJson: "{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference\"}")]
        public virtual aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference ConnectionPoolConfig
        {
            get => GetInstanceProperty<aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeoutsOutputReference\"}")]
        public virtual aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPoolConfigInput", typeJson: "{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupConnectionPoolConfig\"}", isOptional: true)]
        public virtual aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig? ConnectionPoolConfigInput
        {
            get => GetInstanceProperty<aws.DbProxyDefaultTargetGroup.IDbProxyDefaultTargetGroupConnectionPoolConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbProxyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbProxyNameInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dbProxyDefaultTargetGroup.DbProxyDefaultTargetGroupTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "dbProxyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbProxyName
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
    }
}
