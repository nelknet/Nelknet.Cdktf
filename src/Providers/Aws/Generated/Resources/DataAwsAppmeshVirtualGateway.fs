namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name> = { assignments: ResizeArray<aws.DataAwsAppmeshVirtualGateway.DataAwsAppmeshVirtualGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_gateway">aws_appmesh_virtual_gateway</a>.
    /// </summary>
    type DataAwsAppmeshVirtualGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshVirtualGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAwsAppmeshVirtualGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_gateway#mesh_name-1">DataAwsAppmeshVirtualGateway#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: DataAwsAppmeshVirtualGatewayState<Missing, 'Name>, value: string) : DataAwsAppmeshVirtualGatewayState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualGatewayState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_gateway#name-1">DataAwsAppmeshVirtualGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshVirtualGatewayState<'MeshName, Missing>, value: string) : DataAwsAppmeshVirtualGatewayState<'MeshName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualGatewayState<'MeshName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_gateway#id-1">DataAwsAppmeshVirtualGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_gateway#tags-1">DataAwsAppmeshVirtualGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name>, value: seq<string * string>) : DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshVirtualGatewayState<'MeshName, 'Name>

        member _.Run(state: DataAwsAppmeshVirtualGatewayState<Present, Present>) : aws.DataAwsAppmeshVirtualGateway.DataAwsAppmeshVirtualGateway =
            let config = aws.DataAwsAppmeshVirtualGateway.DataAwsAppmeshVirtualGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshVirtualGateway.DataAwsAppmeshVirtualGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshVirtualGateway: missing required arguments. Must call: mesh_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshVirtualGatewayState<_, _>) : aws.DataAwsAppmeshVirtualGateway.DataAwsAppmeshVirtualGateway =
            Unchecked.defaultof<aws.DataAwsAppmeshVirtualGateway.DataAwsAppmeshVirtualGateway>
