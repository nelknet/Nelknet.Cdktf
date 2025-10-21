namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshMeshState<'Name> = { assignments: ResizeArray<aws.DataAwsAppmeshMesh.DataAwsAppmeshMeshConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_mesh">aws_appmesh_mesh</a>.
    /// </summary>
    type DataAwsAppmeshMeshBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshMeshState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshMeshState<Missing>)

        member _.Zero(()) : DataAwsAppmeshMeshState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshMeshState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_mesh#name-1">DataAwsAppmeshMesh#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshMeshState<Missing>, value: string) : DataAwsAppmeshMeshState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshMeshState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_mesh#id-1">DataAwsAppmeshMesh#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshMeshState<'Name>, value: string) : DataAwsAppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshMeshState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_mesh#mesh_owner-1">DataAwsAppmeshMesh#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: DataAwsAppmeshMeshState<'Name>, value: string) : DataAwsAppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : DataAwsAppmeshMeshState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_mesh#tags-1">DataAwsAppmeshMesh#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshMeshState<'Name>, value: seq<string * string>) : DataAwsAppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshMeshState<'Name>

        member _.Run(state: DataAwsAppmeshMeshState<Present>) : aws.DataAwsAppmeshMesh.DataAwsAppmeshMesh =
            let config = aws.DataAwsAppmeshMesh.DataAwsAppmeshMeshConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshMesh.DataAwsAppmeshMesh(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshMesh: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshMeshState<_>) : aws.DataAwsAppmeshMesh.DataAwsAppmeshMesh =
            Unchecked.defaultof<aws.DataAwsAppmeshMesh.DataAwsAppmeshMesh>
