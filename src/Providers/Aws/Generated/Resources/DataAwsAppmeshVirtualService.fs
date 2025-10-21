namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppmeshVirtualServiceState<'MeshName, 'Name> = { assignments: ResizeArray<aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_service">aws_appmesh_virtual_service</a>.
    /// </summary>
    type DataAwsAppmeshVirtualServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppmeshVirtualServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualServiceState<Missing, Missing>)

        member _.Zero(()) : DataAwsAppmeshVirtualServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppmeshVirtualServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_service#mesh_name-1">DataAwsAppmeshVirtualService#mesh_name</a>.
        /// </summary>
        [<CustomOperation "mesh_name">]
        member _.MeshName(state: DataAwsAppmeshVirtualServiceState<Missing, 'Name>, value: string) : DataAwsAppmeshVirtualServiceState<Present, 'Name> =
            state.assignments.Add(fun config -> config.MeshName <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualServiceState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_service#name-1">DataAwsAppmeshVirtualService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppmeshVirtualServiceState<'MeshName, Missing>, value: string) : DataAwsAppmeshVirtualServiceState<'MeshName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAppmeshVirtualServiceState<'MeshName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_service#id-1">DataAwsAppmeshVirtualService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppmeshVirtualServiceState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualServiceState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppmeshVirtualServiceState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_service#mesh_owner-1">DataAwsAppmeshVirtualService#mesh_owner</a>.
        /// </summary>
        [<CustomOperation "mesh_owner">]
        member _.MeshOwner(state: DataAwsAppmeshVirtualServiceState<'MeshName, 'Name>, value: string) : DataAwsAppmeshVirtualServiceState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.MeshOwner <- value)
            state : DataAwsAppmeshVirtualServiceState<'MeshName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appmesh_virtual_service#tags-1">DataAwsAppmeshVirtualService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppmeshVirtualServiceState<'MeshName, 'Name>, value: seq<string * string>) : DataAwsAppmeshVirtualServiceState<'MeshName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppmeshVirtualServiceState<'MeshName, 'Name>

        member _.Run(state: DataAwsAppmeshVirtualServiceState<Present, Present>) : aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualService =
            let config = aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppmeshVirtualService: missing required arguments. Must call: mesh_name, name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppmeshVirtualServiceState<_, _>) : aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualService =
            Unchecked.defaultof<aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualService>
