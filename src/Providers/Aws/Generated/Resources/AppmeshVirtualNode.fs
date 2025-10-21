namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec> = { assignments: ResizeArray<aws.AppmeshVirtualNode.AppmeshVirtualNodeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node">aws_appmesh_virtual_node</a>.
    /// </summary>
    type AppmeshVirtualNodeBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshVirtualNodeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualNodeState<Missing, Missing, Missing>)

        member _.Zero(()) : AppmeshVirtualNodeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualNodeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#mesh_name-1">AppmeshVirtualNode#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: AppmeshVirtualNodeState<Missing, 'Name, 'Spec>, value: string) : AppmeshVirtualNodeState<Present, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : AppmeshVirtualNodeState<Present, 'Name, 'Spec>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#name-1">AppmeshVirtualNode#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshVirtualNodeState<'MeshName, Missing, 'Spec>, value: string) : AppmeshVirtualNodeState<'MeshName, Present, 'Spec> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshVirtualNodeState<'MeshName, Present, 'Spec>)

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#spec-1">AppmeshVirtualNode#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshVirtualNodeState<'MeshName, 'Name, Missing>, value: aws.AppmeshVirtualNode.AppmeshVirtualNodeSpec) : AppmeshVirtualNodeState<'MeshName, 'Name, Present> =
            state.assignments.Add(fun config -> config.Spec <- value)
            ({ assignments = state.assignments } : AppmeshVirtualNodeState<'MeshName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#id-1">AppmeshVirtualNode#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#mesh_owner-1">AppmeshVirtualNode#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#tags-1">AppmeshVirtualNode#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#tags_all-1">AppmeshVirtualNode#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshVirtualNodeState<'MeshName, 'Name, 'Spec>

        member _.Run(state: AppmeshVirtualNodeState<Present, Present, Present>) : aws.AppmeshVirtualNode.AppmeshVirtualNode =
            let config = aws.AppmeshVirtualNode.AppmeshVirtualNodeConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshVirtualNode.AppmeshVirtualNode(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshVirtualNode: missing required arguments. Must call: mesh_name, name, spec.", 9999, IsError = true)>]
        member _.Run(_: AppmeshVirtualNodeState<_, _, _>) : aws.AppmeshVirtualNode.AppmeshVirtualNode =
            Unchecked.defaultof<aws.AppmeshVirtualNode.AppmeshVirtualNode>
