namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppmeshMeshState<'Name> = { assignments: ResizeArray<aws.AppmeshMesh.AppmeshMeshConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh">aws_appmesh_mesh</a>.
    /// </summary>
    type AppmeshMeshBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppmeshMeshState<Missing> =
            ({ assignments = ResizeArray() } : AppmeshMeshState<Missing>)

        member _.Zero(()) : AppmeshMeshState<Missing> =
            ({ assignments = ResizeArray() } : AppmeshMeshState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#name-1">AppmeshMesh#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppmeshMeshState<Missing>, value: string) : AppmeshMeshState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppmeshMeshState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#id-1">AppmeshMesh#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppmeshMeshState<'Name>, value: string) : AppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppmeshMeshState<'Name>

        /// <summary>
        /// spec block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#spec-1">AppmeshMesh#spec</a>
        /// </summary>
        [<CustomOperation "spec">]
        member _.Spec(state: AppmeshMeshState<'Name>, value: aws.AppmeshMesh.AppmeshMeshSpec) : AppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.Spec <- value)
            state : AppmeshMeshState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#tags-1">AppmeshMesh#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppmeshMeshState<'Name>, value: seq<string * string>) : AppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppmeshMeshState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_mesh#tags_all-1">AppmeshMesh#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppmeshMeshState<'Name>, value: seq<string * string>) : AppmeshMeshState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppmeshMeshState<'Name>

        member _.Run(state: AppmeshMeshState<Present>) : aws.AppmeshMesh.AppmeshMesh =
            let config = aws.AppmeshMesh.AppmeshMeshConfig()
            for setter in state.assignments do
                setter config
            aws.AppmeshMesh.AppmeshMesh(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appmeshMesh: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AppmeshMeshState<_>) : aws.AppmeshMesh.AppmeshMesh =
            Unchecked.defaultof<aws.AppmeshMesh.AppmeshMesh>
