using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectUserHierarchyStructure
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure aws_connect_user_hierarchy_structure}.</summary>
    [JsiiClass(nativeType: typeof(aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure), fullyQualifiedName: "aws.connectUserHierarchyStructure.ConnectUserHierarchyStructure", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureConfig\"}}]")]
    public class ConnectUserHierarchyStructure : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure aws_connect_user_hierarchy_structure} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConnectUserHierarchyStructure(Constructs.Construct scope, string id, aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectUserHierarchyStructure(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectUserHierarchyStructure(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ConnectUserHierarchyStructure resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ConnectUserHierarchyStructure to import.</param>
        /// <param name="importFromId">The id of the existing ConnectUserHierarchyStructure that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ConnectUserHierarchyStructure to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ConnectUserHierarchyStructure to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user_hierarchy_structure#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ConnectUserHierarchyStructure that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ConnectUserHierarchyStructure to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putHierarchyStructure", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructure\"}}]")]
        public virtual void PutHierarchyStructure(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructure @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructure)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructure))!;

        [JsiiProperty(name: "hierarchyStructure", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureOutputReference\"}")]
        public virtual aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureOutputReference HierarchyStructure
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructureOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hierarchyStructureInput", typeJson: "{\"fqn\":\"aws.connectUserHierarchyStructure.ConnectUserHierarchyStructureHierarchyStructure\"}", isOptional: true)]
        public virtual aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructure? HierarchyStructureInput
        {
            get => GetInstanceProperty<aws.ConnectUserHierarchyStructure.IConnectUserHierarchyStructureHierarchyStructure?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
