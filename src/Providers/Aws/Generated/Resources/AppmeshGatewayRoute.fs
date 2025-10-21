namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName> = { assignments: ResizeArray<aws.AppmeshGatewayRoute.AppmeshGatewayRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route">aws_appmesh_gateway_route</a>.
    /// </summary>
    type AppmeshGatewayRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshGatewayRouteState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshGatewayRouteState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppmeshGatewayRouteState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshGatewayRouteState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#mesh_name-1">AppmeshGatewayRoute#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: AppmeshGatewayRouteState<Missing, 'Name, 'Spec, 'VirtualGatewayName>, value: string) : AppmeshGatewayRouteState<Present, 'Name, 'Spec, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : AppmeshGatewayRouteState<Present, 'Name, 'Spec, 'VirtualGatewayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#name-1">AppmeshGatewayRoute#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshGatewayRouteState<'MeshName, Missing, 'Spec, 'VirtualGatewayName>, value: string) : AppmeshGatewayRouteState<'MeshName, Present, 'Spec, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshGatewayRouteState<'MeshName, Present, 'Spec, 'VirtualGatewayName>)

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#spec-1">AppmeshGatewayRoute#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshGatewayRouteState<'MeshName, 'Name, Missing, 'VirtualGatewayName>, value: aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpec) : AppmeshGatewayRouteState<'MeshName, 'Name, Present, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Spec <- value)
            ({ assignments = state.assignments } : AppmeshGatewayRouteState<'MeshName, 'Name, Present, 'VirtualGatewayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#virtual_gateway_name-1">AppmeshGatewayRoute#virtual_gateway_name</a>.
        /// </summary>
        [<CustomOperation "virtual_gateway_name">]
        member _.VirtualGatewayName(state: AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, Missing>, value: string) : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, Present> =
            state.assignments.Add(fun config -> config.VirtualGatewayName <- value)
            ({ assignments = state.assignments } : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#id-1">AppmeshGatewayRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>, value: string) : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#mesh_owner-1">AppmeshGatewayRoute#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>, value: string) : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#tags-1">AppmeshGatewayRoute#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>, value: seq<string * string>) : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_gateway_route#tags_all-1">AppmeshGatewayRoute#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>, value: seq<string * string>) : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshGatewayRouteState<'MeshName, 'Name, 'Spec, 'VirtualGatewayName>

        member _.Run(state: AppmeshGatewayRouteState<Present, Present, Present, Present>) : aws.AppmeshGatewayRoute.AppmeshGatewayRoute =
            let config = aws.AppmeshGatewayRoute.AppmeshGatewayRouteConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshGatewayRoute.AppmeshGatewayRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshGatewayRoute: missing required arguments. Must call: mesh_name, name, spec, virtual_gateway_name.", 9999, IsError = true)>]
        member _.Run(_: AppmeshGatewayRouteState<_, _, _, _>) : aws.AppmeshGatewayRoute.AppmeshGatewayRoute =
            Unchecked.defaultof<aws.AppmeshGatewayRoute.AppmeshGatewayRoute>
