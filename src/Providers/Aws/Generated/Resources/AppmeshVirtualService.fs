namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec> = { assignments: ResizeArray<aws.AppmeshVirtualService.AppmeshVirtualServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service">aws_appmesh_virtual_service</a>.
    /// </summary>
    type AppmeshVirtualServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshVirtualServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : AppmeshVirtualServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppmeshVirtualServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#mesh_name-1">AppmeshVirtualService#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: AppmeshVirtualServiceState<Missing, 'Name, 'Spec>, value: string) : AppmeshVirtualServiceState<Present, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : AppmeshVirtualServiceState<Present, 'Name, 'Spec>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#name-1">AppmeshVirtualService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshVirtualServiceState<'MeshName, Missing, 'Spec>, value: string) : AppmeshVirtualServiceState<'MeshName, Present, 'Spec> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshVirtualServiceState<'MeshName, Present, 'Spec>)

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#spec-1">AppmeshVirtualService#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshVirtualServiceState<'MeshName, 'Name, Missing>, value: aws.AppmeshVirtualService.AppmeshVirtualServiceSpec) : AppmeshVirtualServiceState<'MeshName, 'Name, Present> =
            state.assignments.Add(fun config -> config.Spec <- value)
            ({ assignments = state.assignments } : AppmeshVirtualServiceState<'MeshName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#id-1">AppmeshVirtualService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#mesh_owner-1">AppmeshVirtualService#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>, value: string) : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#tags-1">AppmeshVirtualService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_service#tags_all-1">AppmeshVirtualService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>, value: seq<string * string>) : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshVirtualServiceState<'MeshName, 'Name, 'Spec>

        member _.Run(state: AppmeshVirtualServiceState<Present, Present, Present>) : aws.AppmeshVirtualService.AppmeshVirtualService =
            let config = aws.AppmeshVirtualService.AppmeshVirtualServiceConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshVirtualService.AppmeshVirtualService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshVirtualService: missing required arguments. Must call: mesh_name, name, spec.", 9999, IsError = true)>]
        member _.Run(_: AppmeshVirtualServiceState<_, _, _>) : aws.AppmeshVirtualService.AppmeshVirtualService =
            Unchecked.defaultof<aws.AppmeshVirtualService.AppmeshVirtualService>
