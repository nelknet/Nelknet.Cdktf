namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NeptunegraphGraphState<'ProvisionedMemory> = { assignments: ResizeArray<aws.NeptunegraphGraph.NeptunegraphGraphConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph">aws_neptunegraph_graph</a>.
    /// </summary>
    type NeptunegraphGraphBuilder(logicalId: string) =
        member _.Yield(_: unit) : NeptunegraphGraphState<Missing> =
            ({ assignments = ResizeArray() } : NeptunegraphGraphState<Missing>)

        member _.Zero(()) : NeptunegraphGraphState<Missing> =
            ({ assignments = ResizeArray() } : NeptunegraphGraphState<Missing>)

        /// <summary>
        /// The provisioned memory-optimized Neptune Capacity Units (m-NCUs) to use for the graph. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#provisioned_memory-1">NeptunegraphGraph#provisioned_memory</a>
        /// </summary>
        [<CustomOperation "provisioned_memory">]
        member _.ProvisionedMemory(state: NeptunegraphGraphState<Missing>, value: double) : NeptunegraphGraphState<Present> =
            state.assignments.Add(fun config -> config.ProvisionedMemory <- value)
            ({ assignments = state.assignments } : NeptunegraphGraphState<Present>)

        /// <summary>
        /// A value that indicates whether the graph has deletion protection enabled. The graph can't be deleted when deletion protection is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#deletion_protection-1">NeptunegraphGraph#deletion_protection</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: NeptunegraphGraphState<'ProvisionedMemory>, value: bool) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// A value that indicates whether the graph has deletion protection enabled. The graph can't be deleted when deletion protection is enabled. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#deletion_protection-1">NeptunegraphGraph#deletion_protection</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: NeptunegraphGraphState<'ProvisionedMemory>, value: HashiCorp.Cdktf.IResolvable) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// The graph name. For example: my-graph-1. The name must contain from 1 to 63 letters, numbers, or hyphens, and its first character must be a letter. It cannot end with a hyphen or contain two consecutive hyphens. If you don't specify a graph name, a unique graph name is generated for you using the prefix graph-for, followed by a combination of Stack Name and a UUID. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#graph_name-1">NeptunegraphGraph#graph_name</a>
        /// </summary>
        [<CustomOperation "graph_name">]
        member _.GraphName(state: NeptunegraphGraphState<'ProvisionedMemory>, value: string) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.GraphName <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// Allows user to specify name prefix and have remainder of name automatically generated. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#graph_name_prefix-1">NeptunegraphGraph#graph_name_prefix</a>
        /// </summary>
        [<CustomOperation "graph_name_prefix">]
        member _.GraphNamePrefix(state: NeptunegraphGraphState<'ProvisionedMemory>, value: string) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.GraphNamePrefix <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// Specifies a KMS key to use to encrypt data in the new graph. Value must be ARN of KMS Key. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#kms_key_identifier-1">NeptunegraphGraph#kms_key_identifier</a>
        /// </summary>
        [<CustomOperation "kms_key_identifier">]
        member _.KmsKeyIdentifier(state: NeptunegraphGraphState<'ProvisionedMemory>, value: string) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.KmsKeyIdentifier <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// Specifies whether or not the graph can be reachable over the internet. All access to graphs is IAM authenticated. When the graph is publicly available, its domain name system (DNS) endpoint resolves to the public IP address from the internet. When the graph isn't publicly available, you need to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private IP address that is reachable from the VPC. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#public_connectivity-1">NeptunegraphGraph#public_connectivity</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "public_connectivity">]
        member _.PublicConnectivity(state: NeptunegraphGraphState<'ProvisionedMemory>, value: bool) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.PublicConnectivity <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// Specifies whether or not the graph can be reachable over the internet. All access to graphs is IAM authenticated. When the graph is publicly available, its domain name system (DNS) endpoint resolves to the public IP address from the internet. When the graph isn't publicly available, you need to create a PrivateGraphEndpoint in a given VPC to ensure the DNS name resolves to a private IP address that is reachable from the VPC. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#public_connectivity-1">NeptunegraphGraph#public_connectivity</a> Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "public_connectivity">]
        member _.PublicConnectivity(state: NeptunegraphGraphState<'ProvisionedMemory>, value: HashiCorp.Cdktf.IResolvable) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.PublicConnectivity <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// The number of replicas in other AZs.  Value must be between 0 and 2. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#replica_count-1">NeptunegraphGraph#replica_count</a>
        /// </summary>
        [<CustomOperation "replica_count">]
        member _.ReplicaCount(state: NeptunegraphGraphState<'ProvisionedMemory>, value: double) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.ReplicaCount <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#tags-1">NeptunegraphGraph#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NeptunegraphGraphState<'ProvisionedMemory>, value: seq<string * string>) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#timeouts-1">NeptunegraphGraph#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NeptunegraphGraphState<'ProvisionedMemory>, value: aws.NeptunegraphGraph.NeptunegraphGraphTimeouts) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        /// <summary>
        /// vector_search_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptunegraph_graph#vector_search_configuration-1">NeptunegraphGraph#vector_search_configuration</a> Accepts: aws.IResolvable | aws.NeptunegraphGraph.NeptunegraphGraphVectorSearchConfiguration[]
        /// </summary>
        [<CustomOperation "vector_search_configuration">]
        member _.VectorSearchConfiguration(state: NeptunegraphGraphState<'ProvisionedMemory>, value: HashiCorp.Cdktf.IResolvable) : NeptunegraphGraphState<'ProvisionedMemory> =
            state.assignments.Add(fun config -> config.VectorSearchConfiguration <- value)
            state : NeptunegraphGraphState<'ProvisionedMemory>

        member _.Run(state: NeptunegraphGraphState<Present>) : aws.NeptunegraphGraph.NeptunegraphGraph =
            let config = aws.NeptunegraphGraph.NeptunegraphGraphConfig()
            for setter in state.assignments do
                setter config
            aws.NeptunegraphGraph.NeptunegraphGraph(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.neptunegraphGraph: missing required arguments. Must call: provisioned_memory.", 9999, IsError = true)>]
        member _.Run(_: NeptunegraphGraphState<_>) : aws.NeptunegraphGraph.NeptunegraphGraph =
            Unchecked.defaultof<aws.NeptunegraphGraph.NeptunegraphGraph>
