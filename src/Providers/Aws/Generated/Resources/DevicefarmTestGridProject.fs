namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevicefarmTestGridProjectState<'Name> = { assignments: ResizeArray<aws.DevicefarmTestGridProject.DevicefarmTestGridProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project">aws_devicefarm_test_grid_project</a>.
    /// </summary>
    type DevicefarmTestGridProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevicefarmTestGridProjectState<Missing> =
            ({ assignments = ResizeArray() } : DevicefarmTestGridProjectState<Missing>)

        member _.Zero(()) : DevicefarmTestGridProjectState<Missing> =
            ({ assignments = ResizeArray() } : DevicefarmTestGridProjectState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project#name-1">DevicefarmTestGridProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevicefarmTestGridProjectState<Missing>, value: string) : DevicefarmTestGridProjectState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevicefarmTestGridProjectState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project#description-1">DevicefarmTestGridProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DevicefarmTestGridProjectState<'Name>, value: string) : DevicefarmTestGridProjectState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DevicefarmTestGridProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project#id-1">DevicefarmTestGridProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevicefarmTestGridProjectState<'Name>, value: string) : DevicefarmTestGridProjectState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevicefarmTestGridProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project#tags-1">DevicefarmTestGridProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevicefarmTestGridProjectState<'Name>, value: seq<string * string>) : DevicefarmTestGridProjectState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevicefarmTestGridProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project#tags_all-1">DevicefarmTestGridProject#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DevicefarmTestGridProjectState<'Name>, value: seq<string * string>) : DevicefarmTestGridProjectState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DevicefarmTestGridProjectState<'Name>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_test_grid_project#vpc_config-1">DevicefarmTestGridProject#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: DevicefarmTestGridProjectState<'Name>, value: aws.DevicefarmTestGridProject.DevicefarmTestGridProjectVpcConfig) : DevicefarmTestGridProjectState<'Name> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : DevicefarmTestGridProjectState<'Name>

        member _.Run(state: DevicefarmTestGridProjectState<Present>) : aws.DevicefarmTestGridProject.DevicefarmTestGridProject =
            let config = aws.DevicefarmTestGridProject.DevicefarmTestGridProjectConfig()
            for setter in state.assignments do
                setter config
            aws.DevicefarmTestGridProject.DevicefarmTestGridProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devicefarmTestGridProject: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DevicefarmTestGridProjectState<_>) : aws.DevicefarmTestGridProject.DevicefarmTestGridProject =
            Unchecked.defaultof<aws.DevicefarmTestGridProject.DevicefarmTestGridProject>
