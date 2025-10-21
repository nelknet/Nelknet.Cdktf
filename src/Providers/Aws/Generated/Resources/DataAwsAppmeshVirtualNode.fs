namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshVirtualNodeState<'MeshName, 'Name> = { assignments: ResizeArray<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_node">aws_appmesh_virtual_node</a>.
    /// </summary>
    type DataAwsAppmeshVirtualNodeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshVirtualNodeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualNodeState<Missing, Missing>)

        member _.Zero(()) : DataAwsAppmeshVirtualNodeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualNodeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_node#mesh_name-1">DataAwsAppmeshVirtualNode#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: DataAwsAppmeshVirtualNodeState<Missing, 'Name>, value: string) : DataAwsAppmeshVirtualNodeState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualNodeState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_node#name-1">DataAwsAppmeshVirtualNode#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshVirtualNodeState<'MeshName, Missing>, value: string) : DataAwsAppmeshVirtualNodeState<'MeshName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualNodeState<'MeshName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_node#id-1">DataAwsAppmeshVirtualNode#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshVirtualNodeState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualNodeState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshVirtualNodeState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_node#mesh_owner-1">DataAwsAppmeshVirtualNode#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: DataAwsAppmeshVirtualNodeState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualNodeState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : DataAwsAppmeshVirtualNodeState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_node#tags-1">DataAwsAppmeshVirtualNode#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshVirtualNodeState<'MeshName, 'Name>, value: seq<string * string>) : DataAwsAppmeshVirtualNodeState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshVirtualNodeState<'MeshName, 'Name>

        member _.Run(state: DataAwsAppmeshVirtualNodeState<Present, Present>) : aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNode =
            let config = aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNode(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshVirtualNode: missing required arguments. Must call: mesh_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshVirtualNodeState<_, _>) : aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNode =
            Unchecked.defaultof<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNode>
