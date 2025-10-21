using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagementGroupPolicyRemediation
{
    [JsiiInterface(nativeType: typeof(IManagementGroupPolicyRemediationConfig), fullyQualifiedName: "azurerm.managementGroupPolicyRemediation.ManagementGroupPolicyRemediationConfig")]
    public interface IManagementGroupPolicyRemediationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#management_group_id ManagementGroupPolicyRemediation#management_group_id}.</summary>
        [JsiiProperty(name: "managementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string ManagementGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#name ManagementGroupPolicyRemediation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#policy_assignment_id ManagementGroupPolicyRemediation#policy_assignment_id}.</summary>
        [JsiiProperty(name: "policyAssignmentId", typeJson: "{\"primitive\":\"string\"}")]
        string PolicyAssignmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#failure_percentage ManagementGroupPolicyRemediation#failure_percentage}.</summary>
        [JsiiProperty(name: "failurePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailurePercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#id ManagementGroupPolicyRemediation#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#location_filters ManagementGroupPolicyRemediation#location_filters}.</summary>
        [JsiiProperty(name: "locationFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LocationFilters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#parallel_deployments ManagementGroupPolicyRemediation#parallel_deployments}.</summary>
        [JsiiProperty(name: "parallelDeployments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ParallelDeployments
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#policy_definition_reference_id ManagementGroupPolicyRemediation#policy_definition_reference_id}.</summary>
        [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyDefinitionReferenceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#resource_count ManagementGroupPolicyRemediation#resource_count}.</summary>
        [JsiiProperty(name: "resourceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResourceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#timeouts ManagementGroupPolicyRemediation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managementGroupPolicyRemediation.ManagementGroupPolicyRemediationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagementGroupPolicyRemediation.IManagementGroupPolicyRemediationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementGroupPolicyRemediationConfig), fullyQualifiedName: "azurerm.managementGroupPolicyRemediation.ManagementGroupPolicyRemediationConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagementGroupPolicyRemediation.IManagementGroupPolicyRemediationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#management_group_id ManagementGroupPolicyRemediation#management_group_id}.</summary>
            [JsiiProperty(name: "managementGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string ManagementGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#name ManagementGroupPolicyRemediation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#policy_assignment_id ManagementGroupPolicyRemediation#policy_assignment_id}.</summary>
            [JsiiProperty(name: "policyAssignmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string PolicyAssignmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#failure_percentage ManagementGroupPolicyRemediation#failure_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failurePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailurePercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#id ManagementGroupPolicyRemediation#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#location_filters ManagementGroupPolicyRemediation#location_filters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "locationFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LocationFilters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#parallel_deployments ManagementGroupPolicyRemediation#parallel_deployments}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parallelDeployments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ParallelDeployments
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#policy_definition_reference_id ManagementGroupPolicyRemediation#policy_definition_reference_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyDefinitionReferenceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyDefinitionReferenceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#resource_count ManagementGroupPolicyRemediation#resource_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResourceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#timeouts ManagementGroupPolicyRemediation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.managementGroupPolicyRemediation.ManagementGroupPolicyRemediationTimeouts\"}", isOptional: true)]
            public azurerm.ManagementGroupPolicyRemediation.IManagementGroupPolicyRemediationTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ManagementGroupPolicyRemediation.IManagementGroupPolicyRemediationTimeouts?>();
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
