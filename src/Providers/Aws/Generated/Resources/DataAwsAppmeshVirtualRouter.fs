namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshVirtualRouterState<'MeshName, 'Name> = { assignments: ResizeArray<aws.DataAwsAppmeshVirtualRouter.DataAwsAppmeshVirtualRouterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_router">aws_appmesh_virtual_router</a>.
    /// </summary>
    type DataAwsAppmeshVirtualRouterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshVirtualRouterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualRouterState<Missing, Missing>)

        member _.Zero(()) : DataAwsAppmeshVirtualRouterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualRouterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_router#mesh_name-1">DataAwsAppmeshVirtualRouter#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: DataAwsAppmeshVirtualRouterState<Missing, 'Name>, value: string) : DataAwsAppmeshVirtualRouterState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualRouterState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_router#name-1">DataAwsAppmeshVirtualRouter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshVirtualRouterState<'MeshName, Missing>, value: string) : DataAwsAppmeshVirtualRouterState<'MeshName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualRouterState<'MeshName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_router#id-1">DataAwsAppmeshVirtualRouter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshVirtualRouterState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualRouterState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshVirtualRouterState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_router#mesh_owner-1">DataAwsAppmeshVirtualRouter#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: DataAwsAppmeshVirtualRouterState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualRouterState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : DataAwsAppmeshVirtualRouterState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_router#tags-1">DataAwsAppmeshVirtualRouter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshVirtualRouterState<'MeshName, 'Name>, value: seq<string * string>) : DataAwsAppmeshVirtualRouterState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshVirtualRouterState<'MeshName, 'Name>

        member _.Run(state: DataAwsAppmeshVirtualRouterState<Present, Present>) : aws.DataAwsAppmeshVirtualRouter.DataAwsAppmeshVirtualRouter =
            let config = aws.DataAwsAppmeshVirtualRouter.DataAwsAppmeshVirtualRouterConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshVirtualRouter.DataAwsAppmeshVirtualRouter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshVirtualRouter: missing required arguments. Must call: mesh_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshVirtualRouterState<_, _>) : aws.DataAwsAppmeshVirtualRouter.DataAwsAppmeshVirtualRouter =
            Unchecked.defaultof<aws.DataAwsAppmeshVirtualRouter.DataAwsAppmeshVirtualRouter>
