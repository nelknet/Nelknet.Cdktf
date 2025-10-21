namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName> = { assignments: ResizeArray<aws.DataAwsAppmeshGatewayRoute.DataAwsAppmeshGatewayRouteConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route">aws_appmesh_gateway_route</a>.
    /// </summary>
    type DataAwsAppmeshGatewayRouteBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshGatewayRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshGatewayRouteState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsAppmeshGatewayRouteState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshGatewayRouteState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route#mesh_name-1">DataAwsAppmeshGatewayRoute#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: DataAwsAppmeshGatewayRouteState<Missing, 'Name, 'VirtualGatewayName>, value: string) : DataAwsAppmeshGatewayRouteState<Present, 'Name, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshGatewayRouteState<Present, 'Name, 'VirtualGatewayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route#name-1">DataAwsAppmeshGatewayRoute#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshGatewayRouteState<'MeshName, Missing, 'VirtualGatewayName>, value: string) : DataAwsAppmeshGatewayRouteState<'MeshName, Present, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshGatewayRouteState<'MeshName, Present, 'VirtualGatewayName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route#virtual_gateway_name-1">DataAwsAppmeshGatewayRoute#virtual_gateway_name</a>.
        /// </summary>
        [<CustomOperation "virtual_gateway_name">]
        member _.VirtualGatewayName(state: DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, Missing>, value: string) : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, Present> =
            state.assignments.Add(fun config -> config.VirtualGatewayName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route#id-1">DataAwsAppmeshGatewayRoute#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName>, value: string) : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route#mesh_owner-1">DataAwsAppmeshGatewayRoute#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName>, value: string) : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_gateway_route#tags-1">DataAwsAppmeshGatewayRoute#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName>, value: seq<string * string>) : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshGatewayRouteState<'MeshName, 'Name, 'VirtualGatewayName>

        member _.Run(state: DataAwsAppmeshGatewayRouteState<Present, Present, Present>) : aws.DataAwsAppmeshGatewayRoute.DataAwsAppmeshGatewayRoute =
            let config = aws.DataAwsAppmeshGatewayRoute.DataAwsAppmeshGatewayRouteConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshGatewayRoute.DataAwsAppmeshGatewayRoute(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshGatewayRoute: missing required arguments. Must call: mesh_name, name, virtual_gateway_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshGatewayRouteState<_, _, _>) : aws.DataAwsAppmeshGatewayRoute.DataAwsAppmeshGatewayRoute =
            Unchecked.defaultof<aws.DataAwsAppmeshGatewayRoute.DataAwsAppmeshGatewayRoute>
