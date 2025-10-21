using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksAccessPolicyAssociation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association aws_eks_access_policy_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation), fullyQualifiedName: "aws.eksAccessPolicyAssociation.EksAccessPolicyAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationConfig\"}}]")]
    public class EksAccessPolicyAssociation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association aws_eks_access_policy_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EksAccessPolicyAssociation(Constructs.Construct scope, string id, aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksAccessPolicyAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksAccessPolicyAssociation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a EksAccessPolicyAssociation resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the EksAccessPolicyAssociation to import.</param>
        /// <param name="importFromId">The id of the existing EksAccessPolicyAssociation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the EksAccessPolicyAssociation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the EksAccessPolicyAssociation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_access_policy_association#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing EksAccessPolicyAssociation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the EksAccessPolicyAssociation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccessScope", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScope\"}}]")]
        public virtual void PutAccessScope(aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationAccessScope @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationAccessScope)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.EksAccessPolicyAssociation.EksAccessPolicyAssociation))!;

        [JsiiProperty(name: "accessScope", typeJson: "{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScopeOutputReference\"}")]
        public virtual aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScopeOutputReference AccessScope
        {
            get => GetInstanceProperty<aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScopeOutputReference>()!;
        }

        [JsiiProperty(name: "associatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationTimeoutsOutputReference\"}")]
        public virtual aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.EksAccessPolicyAssociation.EksAccessPolicyAssociationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessScopeInput", typeJson: "{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationAccessScope\"}", isOptional: true)]
        public virtual aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationAccessScope? AccessScopeInput
        {
            get => GetInstanceProperty<aws.EksAccessPolicyAssociation.IEksAccessPolicyAssociationAccessScope?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
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
        [JsiiProperty(name: "policyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.eksAccessPolicyAssociation.EksAccessPolicyAssociationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
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

        [JsiiProperty(name: "policyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "principalArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
