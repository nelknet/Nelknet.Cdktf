namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName> = { assignments: ResizeArray<aws.AppmeshRoute.AppmeshRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route">aws_appmesh_route</a>.
    /// </summary>
    type AppmeshRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshRouteState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshRouteState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppmeshRouteState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshRouteState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#mesh_name-1">AppmeshRoute#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: AppmeshRouteState<Missing, 'Name, 'Spec, 'VirtualRouterName>, value: string) : AppmeshRouteState<Present, 'Name, 'Spec, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : AppmeshRouteState<Present, 'Name, 'Spec, 'VirtualRouterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#name-1">AppmeshRoute#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshRouteState<'MeshName, Missing, 'Spec, 'VirtualRouterName>, value: string) : AppmeshRouteState<'MeshName, Present, 'Spec, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshRouteState<'MeshName, Present, 'Spec, 'VirtualRouterName>)

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#spec-1">AppmeshRoute#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshRouteState<'MeshName, 'Name, Missing, 'VirtualRouterName>, value: aws.AppmeshRoute.AppmeshRouteSpec) : AppmeshRouteState<'MeshName, 'Name, Present, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Spec <- value)
            ({ assignments = state.assignments } : AppmeshRouteState<'MeshName, 'Name, Present, 'VirtualRouterName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#virtual_router_name-1">AppmeshRoute#virtual_router_name</a>.
        /// </summary>
        [<CustomOperation "virtual_router_name">]
        member _.VirtualRouterName(state: AppmeshRouteState<'MeshName, 'Name, 'Spec, Missing>, value: string) : AppmeshRouteState<'MeshName, 'Name, 'Spec, Present> =
            state.assignments.Add(fun config -> config.VirtualRouterName <- value)
            ({ assignments = state.assignments } : AppmeshRouteState<'MeshName, 'Name, 'Spec, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#id-1">AppmeshRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>, value: string) : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#mesh_owner-1">AppmeshRoute#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>, value: string) : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tags-1">AppmeshRoute#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>, value: seq<string * string>) : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_route#tags_all-1">AppmeshRoute#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>, value: seq<string * string>) : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshRouteState<'MeshName, 'Name, 'Spec, 'VirtualRouterName>

        member _.Run(state: AppmeshRouteState<Present, Present, Present, Present>) : aws.AppmeshRoute.AppmeshRoute =
            let config = aws.AppmeshRoute.AppmeshRouteConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshRoute.AppmeshRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshRoute: missing required arguments. Must call: mesh_name, name, spec, virtual_router_name.", 9999, IsError = true)>]
        member _.Run(_: AppmeshRouteState<_, _, _, _>) : aws.AppmeshRoute.AppmeshRoute =
            Unchecked.defaultof<aws.AppmeshRoute.AppmeshRoute>
