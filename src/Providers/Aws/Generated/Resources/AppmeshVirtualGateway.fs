namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec> = { assignments: ResizeArray<aws.AppmeshVirtualGateway.AppmeshVirtualGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway">aws_appmesh_virtual_gateway</a>.
    /// </summary>
    type AppmeshVirtualGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshVirtualGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualGatewayState<Missing, Missing, Missing>)

        member _.Zero(()) : AppmeshVirtualGatewayState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualGatewayState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#mesh_name-1">AppmeshVirtualGateway#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: AppmeshVirtualGatewayState<Missing, 'Name, 'Spec>, value: string) : AppmeshVirtualGatewayState<Present, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : AppmeshVirtualGatewayState<Present, 'Name, 'Spec>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#name-1">AppmeshVirtualGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshVirtualGatewayState<'MeshName, Missing, 'Spec>, value: string) : AppmeshVirtualGatewayState<'MeshName, Present, 'Spec> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshVirtualGatewayState<'MeshName, Present, 'Spec>)

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#spec-1">AppmeshVirtualGateway#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshVirtualGatewayState<'MeshName, 'Name, Missing>, value: aws.AppmeshVirtualGateway.AppmeshVirtualGatewaySpec) : AppmeshVirtualGatewayState<'MeshName, 'Name, Present> =
            state.assignments.Add(fun config -> config.Spec <- value)
            ({ assignments = state.assignments } : AppmeshVirtualGatewayState<'MeshName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#id-1">AppmeshVirtualGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#mesh_owner-1">AppmeshVirtualGateway#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#tags-1">AppmeshVirtualGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_gateway#tags_all-1">AppmeshVirtualGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshVirtualGatewayState<'MeshName, 'Name, 'Spec>

        member _.Run(state: AppmeshVirtualGatewayState<Present, Present, Present>) : aws.AppmeshVirtualGateway.AppmeshVirtualGateway =
            let config = aws.AppmeshVirtualGateway.AppmeshVirtualGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshVirtualGateway.AppmeshVirtualGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshVirtualGateway: missing required arguments. Must call: mesh_name, name, spec.", 9999, IsError = true)>]
        member _.Run(_: AppmeshVirtualGatewayState<_, _, _>) : aws.AppmeshVirtualGateway.AppmeshVirtualGateway =
            Unchecked.defaultof<aws.AppmeshVirtualGateway.AppmeshVirtualGateway>
