namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchserverlessCollectionState<'Name> = { assignments: ResizeArray<aws.OpensearchserverlessCollection.OpensearchserverlessCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection">aws_opensearchserverless_collection</a>.
    /// </summary>
    type OpensearchserverlessCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchserverlessCollectionState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessCollectionState<Missing>)

        member _.Zero(()) : OpensearchserverlessCollectionState<Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessCollectionState<Missing>)

        /// <summary>
        /// Name of the collection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection#name-1">OpensearchserverlessCollection#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpensearchserverlessCollectionState<Missing>, value: string) : OpensearchserverlessCollectionState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpensearchserverlessCollectionState<Present>)

        /// <summary>
        /// Description of the collection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection#description-1">OpensearchserverlessCollection#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OpensearchserverlessCollectionState<'Name>, value: string) : OpensearchserverlessCollectionState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OpensearchserverlessCollectionState<'Name>

        /// <summary>
        /// Indicates whether standby replicas should be used for a collection. One of `ENABLED` or `DISABLED`. Defaults to `ENABLED`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection#standby_replicas-1">OpensearchserverlessCollection#standby_replicas</a>
        /// </summary>
        [<CustomOperation "standby_replicas">]
        member _.StandbyReplicas(state: OpensearchserverlessCollectionState<'Name>, value: string) : OpensearchserverlessCollectionState<'Name> =
            state.assignments.Add(fun config -> config.StandbyReplicas <- value)
            state : OpensearchserverlessCollectionState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection#tags-1">OpensearchserverlessCollection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OpensearchserverlessCollectionState<'Name>, value: seq<string * string>) : OpensearchserverlessCollectionState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OpensearchserverlessCollectionState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection#timeouts-1">OpensearchserverlessCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OpensearchserverlessCollectionState<'Name>, value: aws.OpensearchserverlessCollection.OpensearchserverlessCollectionTimeouts) : OpensearchserverlessCollectionState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OpensearchserverlessCollectionState<'Name>

        /// <summary>
        /// Type of collection. One of `SEARCH`, `TIMESERIES`, or `VECTORSEARCH`. Defaults to `TIMESERIES`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_collection#type-1">OpensearchserverlessCollection#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OpensearchserverlessCollectionState<'Name>, value: string) : OpensearchserverlessCollectionState<'Name> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : OpensearchserverlessCollectionState<'Name>

        member _.Run(state: OpensearchserverlessCollectionState<Present>) : aws.OpensearchserverlessCollection.OpensearchserverlessCollection =
            let config = aws.OpensearchserverlessCollection.OpensearchserverlessCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchserverlessCollection.OpensearchserverlessCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchserverlessCollection: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: OpensearchserverlessCollectionState<_>) : aws.OpensearchserverlessCollection.OpensearchserverlessCollection =
            Unchecked.defaultof<aws.OpensearchserverlessCollection.OpensearchserverlessCollection>
