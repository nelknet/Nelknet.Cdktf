namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName> = { assignments: ResizeArray<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route">aws_appmesh_route</a>.
    /// </summary>
    type DataAwsAppmeshRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshRouteState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsAppmeshRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshRouteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route#mesh_name-1">DataAwsAppmeshRoute#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: DataAwsAppmeshRouteState<Missing, 'Name, 'VirtualRouterName>, value: string) : DataAwsAppmeshRouteState<Present, 'Name, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshRouteState<Present, 'Name, 'VirtualRouterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route#name-1">DataAwsAppmeshRoute#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshRouteState<'MeshName, Missing, 'VirtualRouterName>, value: string) : DataAwsAppmeshRouteState<'MeshName, Present, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshRouteState<'MeshName, Present, 'VirtualRouterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route#virtual_router_name-1">DataAwsAppmeshRoute#virtual_router_name</a>.
        /// </summary>
        [<CustomOperation "virtual_router_name">]
        member _.VirtualRouterName(state: DataAwsAppmeshRouteState<'MeshName, 'Name, Missing>, value: string) : DataAwsAppmeshRouteState<'MeshName, 'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualRouterName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshRouteState<'MeshName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route#id-1">DataAwsAppmeshRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName>, value: string) : DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route#mesh_owner-1">DataAwsAppmeshRoute#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName>, value: string) : DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_route#tags-1">DataAwsAppmeshRoute#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName>, value: seq<string * string>) : DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshRouteState<'MeshName, 'Name, 'VirtualRouterName>

        member _.Run(state: DataAwsAppmeshRouteState<Present, Present, Present>) : aws.DataAwsAppmeshRoute.DataAwsAppmeshRoute =
            let config = aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshRoute.DataAwsAppmeshRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshRoute: missing required arguments. Must call: mesh_name, name, virtual_router_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshRouteState<_, _, _>) : aws.DataAwsAppmeshRoute.DataAwsAppmeshRoute =
            Unchecked.defaultof<aws.DataAwsAppmeshRoute.DataAwsAppmeshRoute>
