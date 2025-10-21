namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec> = { assignments: ResizeArray<aws.AppmeshVirtualRouter.AppmeshVirtualRouterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router">aws_appmesh_virtual_router</a>.
    /// </summary>
    type AppmeshVirtualRouterBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshVirtualRouterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualRouterState<Missing, Missing, Missing>)

        member _.Zero(()) : AppmeshVirtualRouterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualRouterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#mesh_name-1">AppmeshVirtualRouter#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: AppmeshVirtualRouterState<Missing, 'Name, 'Spec>, value: string) : AppmeshVirtualRouterState<Present, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : AppmeshVirtualRouterState<Present, 'Name, 'Spec>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#name-1">AppmeshVirtualRouter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshVirtualRouterState<'MeshName, Missing, 'Spec>, value: string) : AppmeshVirtualRouterState<'MeshName, Present, 'Spec> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshVirtualRouterState<'MeshName, Present, 'Spec>)

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#spec-1">AppmeshVirtualRouter#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshVirtualRouterState<'MeshName, 'Name, Missing>, value: aws.AppmeshVirtualRouter.AppmeshVirtualRouterSpec) : AppmeshVirtualRouterState<'MeshName, 'Name, Present> =
            state.assignments.Add(fun config -> config.Spec <- value)
            ({ assignments = state.assignments } : AppmeshVirtualRouterState<'MeshName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#id-1">AppmeshVirtualRouter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#mesh_owner-1">AppmeshVirtualRouter#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#tags-1">AppmeshVirtualRouter#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_router#tags_all-1">AppmeshVirtualRouter#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshVirtualRouterState<'MeshName, 'Name, 'Spec>

        member _.Run(state: AppmeshVirtualRouterState<Present, Present, Present>) : aws.AppmeshVirtualRouter.AppmeshVirtualRouter =
            let config = aws.AppmeshVirtualRouter.AppmeshVirtualRouterConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshVirtualRouter.AppmeshVirtualRouter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshVirtualRouter: missing required arguments. Must call: mesh_name, name, spec.", 9999, IsError = true)>]
        member _.Run(_: AppmeshVirtualRouterState<_, _, _>) : aws.AppmeshVirtualRouter.AppmeshVirtualRouter =
            Unchecked.defaultof<aws.AppmeshVirtualRouter.AppmeshVirtualRouter>
