using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIamPrincipalPolicySimulation
{
    [JsiiInterface(nativeType: typeof(IDataAwsIamPrincipalPolicySimulationConfig), fullyQualifiedName: "aws.dataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationConfig")]
    public interface IDataAwsIamPrincipalPolicySimulationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>One or more names of actions, like "iam:CreateUser", that should be included in the simulation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#action_names DataAwsIamPrincipalPolicySimulation#action_names}
        /// </remarks>
        [JsiiProperty(name: "actionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ActionNames
        {
            get;
        }

        /// <summary>ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#policy_source_arn DataAwsIamPrincipalPolicySimulation#policy_source_arn}
        /// </remarks>
        [JsiiProperty(name: "policySourceArn", typeJson: "{\"primitive\":\"string\"}")]
        string PolicySourceArn
        {
            get;
        }

        /// <summary>Additional principal-based policies to use in the simulation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#additional_policies_json DataAwsIamPrincipalPolicySimulation#additional_policies_json}
        /// </remarks>
        [JsiiProperty(name: "additionalPoliciesJson", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalPoliciesJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>ARN of a user to use as the caller of the simulated requests.</summary>
        /// <remarks>
        /// If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#caller_arn DataAwsIamPrincipalPolicySimulation#caller_arn}
        /// </remarks>
        [JsiiProperty(name: "callerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CallerArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#context DataAwsIamPrincipalPolicySimulation#context}
        /// </remarks>
        [JsiiProperty(name: "context", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationContext\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Context
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional permission boundary policies to use in the simulation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#permissions_boundary_policies_json DataAwsIamPrincipalPolicySimulation#permissions_boundary_policies_json}
        /// </remarks>
        [JsiiProperty(name: "permissionsBoundaryPoliciesJson", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PermissionsBoundaryPoliciesJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>ARNs of specific resources to use as the targets of the specified actions during simulation.</summary>
        /// <remarks>
        /// If not specified, the simulator assumes "*" which represents general access across all resources.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_arns DataAwsIamPrincipalPolicySimulation#resource_arns}
        /// </remarks>
        [JsiiProperty(name: "resourceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the type of simulation to run.</summary>
        /// <remarks>
        /// Some API operations need a particular resource handling option in order to produce a correct reesult.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_handling_option DataAwsIamPrincipalPolicySimulation#resource_handling_option}
        /// </remarks>
        [JsiiProperty(name: "resourceHandlingOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceHandlingOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID.</summary>
        /// <remarks>
        /// Defaults to the account given as part of caller_arn.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_owner_account_id DataAwsIamPrincipalPolicySimulation#resource_owner_account_id}
        /// </remarks>
        [JsiiProperty(name: "resourceOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceOwnerAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>A resource policy to associate with all of the target resources for simulation purposes.</summary>
        /// <remarks>
        /// The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_policy_json DataAwsIamPrincipalPolicySimulation#resource_policy_json}
        /// </remarks>
        [JsiiProperty(name: "resourcePolicyJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourcePolicyJson
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIamPrincipalPolicySimulationConfig), fullyQualifiedName: "aws.dataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsIamPrincipalPolicySimulation.IDataAwsIamPrincipalPolicySimulationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>One or more names of actions, like "iam:CreateUser", that should be included in the simulation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#action_names DataAwsIamPrincipalPolicySimulation#action_names}
            /// </remarks>
            [JsiiProperty(name: "actionNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ActionNames
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>ARN of the principal (e.g. user, role) whose existing configured access policies will be used as the basis for the simulation. If you specify a role ARN here, you can also set caller_arn to simulate a particular user acting with the given role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#policy_source_arn DataAwsIamPrincipalPolicySimulation#policy_source_arn}
            /// </remarks>
            [JsiiProperty(name: "policySourceArn", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicySourceArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Additional principal-based policies to use in the simulation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#additional_policies_json DataAwsIamPrincipalPolicySimulation#additional_policies_json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalPoliciesJson", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalPoliciesJson
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ARN of a user to use as the caller of the simulated requests.</summary>
            /// <remarks>
            /// If not specified, defaults to the principal specified in policy_source_arn, if it is a user ARN.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#caller_arn DataAwsIamPrincipalPolicySimulation#caller_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "callerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CallerArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>context block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#context DataAwsIamPrincipalPolicySimulation#context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "context", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsIamPrincipalPolicySimulation.DataAwsIamPrincipalPolicySimulationContext\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Context
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Additional permission boundary policies to use in the simulation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#permissions_boundary_policies_json DataAwsIamPrincipalPolicySimulation#permissions_boundary_policies_json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permissionsBoundaryPoliciesJson", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PermissionsBoundaryPoliciesJson
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ARNs of specific resources to use as the targets of the specified actions during simulation.</summary>
            /// <remarks>
            /// If not specified, the simulator assumes "*" which represents general access across all resources.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_arns DataAwsIamPrincipalPolicySimulation#resource_arns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Specifies the type of simulation to run.</summary>
            /// <remarks>
            /// Some API operations need a particular resource handling option in order to produce a correct reesult.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_handling_option DataAwsIamPrincipalPolicySimulation#resource_handling_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceHandlingOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceHandlingOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>An AWS account ID to use as the simulated owner for any resource whose ARN does not include a specific owner account ID.</summary>
            /// <remarks>
            /// Defaults to the account given as part of caller_arn.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_owner_account_id DataAwsIamPrincipalPolicySimulation#resource_owner_account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceOwnerAccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A resource policy to associate with all of the target resources for simulation purposes.</summary>
            /// <remarks>
            /// The policy simulator does not automatically retrieve resource-level policies, so if a resource policy is crucial to your test then you must specify here the same policy document associated with your target resource(s).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_principal_policy_simulation#resource_policy_json DataAwsIamPrincipalPolicySimulation#resource_policy_json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePolicyJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourcePolicyJson
            {
                get => GetInstanceProperty<string?>();
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
