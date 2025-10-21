using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NeptunegraphGraph
{
    [JsiiInterface(nativeType: typeof(INeptunegraphGraphConfig), fullyQualifiedName: "aws.neptunegraphGraph.NeptunegraphGraphConfig")]
    public interface INeptunegraphGraphConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#provisioned_memory NeptunegraphGraph#provisioned_memory}
        /// </remarks>
        [JsiiProperty(name: "provisionedMemory", typeJson: "{\"primitive\":\"number\"}")]
        double ProvisionedMemory
        {
            get;
        }

        /// <summary>A value that indicates whether the graph has deletion protection enabled.</summary>
        /// <remarks>
        /// The graph can't be deleted when deletion protection is enabled.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#deletion_protection NeptunegraphGraph#deletion_protection}
        /// </remarks>
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DeletionProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>The graph name.</summary>
        /// <remarks>
        /// For example: my-graph-1.
        /// The name must contain from 1 to 63 letters, numbers, or hyphens,
        /// and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
        /// If you don't specify a graph name, a unique graph name is generated for you using the prefix graph-for,
        /// followed by a combination of Stack Name and a UUID.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#graph_name NeptunegraphGraph#graph_name}
        /// </remarks>
        [JsiiProperty(name: "graphName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GraphName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Allows user to specify name prefix and have remainder of name automatically generated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#graph_name_prefix NeptunegraphGraph#graph_name_prefix}
        /// </remarks>
        [JsiiProperty(name: "graphNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GraphNamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies a KMS key to use to encrypt data in the new graph.</summary>
        /// <remarks>
        /// Value must be ARN of KMS Key.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#kms_key_identifier NeptunegraphGraph#kms_key_identifier}
        /// </remarks>
        [JsiiProperty(name: "kmsKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies whether or not the graph can be reachable over the internet.</summary>
        /// <remarks>
        /// All access to graphs is IAM authenticated.
        /// When the graph is publicly available, its domain name system (DNS) endpoint resolves to
        /// the public IP address from the internet. When the graph isn't publicly available, you need
        /// to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private
        /// IP address that is reachable from the VPC.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#public_connectivity NeptunegraphGraph#public_connectivity}
        /// </remarks>
        [JsiiProperty(name: "publicConnectivity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicConnectivity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of replicas in other AZs.  Value must be between 0 and 2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#replica_count NeptunegraphGraph#replica_count}
        /// </remarks>
        [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicaCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#tags NeptunegraphGraph#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#timeouts NeptunegraphGraph#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptunegraphGraph.NeptunegraphGraphTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.NeptunegraphGraph.INeptunegraphGraphTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>vector_search_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#vector_search_configuration NeptunegraphGraph#vector_search_configuration}
        /// </remarks>
        [JsiiProperty(name: "vectorSearchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.neptunegraphGraph.NeptunegraphGraphVectorSearchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VectorSearchConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INeptunegraphGraphConfig), fullyQualifiedName: "aws.neptunegraphGraph.NeptunegraphGraphConfig")]
        internal sealed class _Proxy : DeputyBase, aws.NeptunegraphGraph.INeptunegraphGraphConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#provisioned_memory NeptunegraphGraph#provisioned_memory}
            /// </remarks>
            [JsiiProperty(name: "provisionedMemory", typeJson: "{\"primitive\":\"number\"}")]
            public double ProvisionedMemory
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>A value that indicates whether the graph has deletion protection enabled.</summary>
            /// <remarks>
            /// The graph can't be deleted when deletion protection is enabled.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#deletion_protection NeptunegraphGraph#deletion_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DeletionProtection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The graph name.</summary>
            /// <remarks>
            /// For example: my-graph-1.
            /// The name must contain from 1 to 63 letters, numbers, or hyphens,
            /// and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens.
            /// If you don't specify a graph name, a unique graph name is generated for you using the prefix graph-for,
            /// followed by a combination of Stack Name and a UUID.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#graph_name NeptunegraphGraph#graph_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "graphName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GraphName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Allows user to specify name prefix and have remainder of name automatically generated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#graph_name_prefix NeptunegraphGraph#graph_name_prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "graphNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GraphNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies a KMS key to use to encrypt data in the new graph.</summary>
            /// <remarks>
            /// Value must be ARN of KMS Key.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#kms_key_identifier NeptunegraphGraph#kms_key_identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies whether or not the graph can be reachable over the internet.</summary>
            /// <remarks>
            /// All access to graphs is IAM authenticated.
            /// When the graph is publicly available, its domain name system (DNS) endpoint resolves to
            /// the public IP address from the internet. When the graph isn't publicly available, you need
            /// to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private
            /// IP address that is reachable from the VPC.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#public_connectivity NeptunegraphGraph#public_connectivity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicConnectivity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublicConnectivity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The number of replicas in other AZs.  Value must be between 0 and 2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#replica_count NeptunegraphGraph#replica_count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicaCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#tags NeptunegraphGraph#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#timeouts NeptunegraphGraph#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.neptunegraphGraph.NeptunegraphGraphTimeouts\"}", isOptional: true)]
            public aws.NeptunegraphGraph.INeptunegraphGraphTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.NeptunegraphGraph.INeptunegraphGraphTimeouts?>();
            }

            /// <summary>vector_search_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#vector_search_configuration NeptunegraphGraph#vector_search_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vectorSearchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.neptunegraphGraph.NeptunegraphGraphVectorSearchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VectorSearchConfiguration
            {
                get => GetInstanceProperty<object?>();
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
