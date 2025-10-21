using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsSchema
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsSchemaConfig), fullyQualifiedName: "aws.verifiedpermissionsSchema.VerifiedpermissionsSchemaConfig")]
    public interface IVerifiedpermissionsSchemaConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#definition VerifiedpermissionsSchema#definition}
        /// </remarks>
        [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.verifiedpermissionsSchema.VerifiedpermissionsSchemaDefinition\"}")]
        aws.VerifiedpermissionsSchema.IVerifiedpermissionsSchemaDefinition Definition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#policy_store_id VerifiedpermissionsSchema#policy_store_id}.</summary>
        [JsiiProperty(name: "policyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyStoreId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsSchemaConfig), fullyQualifiedName: "aws.verifiedpermissionsSchema.VerifiedpermissionsSchemaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsSchema.IVerifiedpermissionsSchemaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#definition VerifiedpermissionsSchema#definition}
            /// </remarks>
            [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.verifiedpermissionsSchema.VerifiedpermissionsSchemaDefinition\"}")]
            public aws.VerifiedpermissionsSchema.IVerifiedpermissionsSchemaDefinition Definition
            {
                get => GetInstanceProperty<aws.VerifiedpermissionsSchema.IVerifiedpermissionsSchemaDefinition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#policy_store_id VerifiedpermissionsSchema#policy_store_id}.</summary>
            [JsiiProperty(name: "policyStoreId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyStoreId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
