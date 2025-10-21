namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevicefarmProjectState<'Name> = { assignments: ResizeArray<aws.DevicefarmProject.DevicefarmProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_project">aws_devicefarm_project</a>.
    /// </summary>
    type DevicefarmProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevicefarmProjectState<Missing> =
            ({ assignments = ResizeArray() } : DevicefarmProjectState<Missing>)

        member _.Zero(()) : DevicefarmProjectState<Missing> =
            ({ assignments = ResizeArray() } : DevicefarmProjectState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_project#name-1">DevicefarmProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevicefarmProjectState<Missing>, value: string) : DevicefarmProjectState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevicefarmProjectState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_project#default_job_timeout_minutes-1">DevicefarmProject#default_job_timeout_minutes</a>.
        /// </summary>
        [<CustomOperation "default_job_timeout_minutes">]
        member _.DefaultJobTimeoutMinutes(state: DevicefarmProjectState<'Name>, value: double) : DevicefarmProjectState<'Name> =
            state.assignments.Add(fun config -> config.DefaultJobTimeoutMinutes <- value)
            state : DevicefarmProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_project#id-1">DevicefarmProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevicefarmProjectState<'Name>, value: string) : DevicefarmProjectState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevicefarmProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_project#tags-1">DevicefarmProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DevicefarmProjectState<'Name>, value: seq<string * string>) : DevicefarmProjectState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DevicefarmProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_project#tags_all-1">DevicefarmProject#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DevicefarmProjectState<'Name>, value: seq<string * string>) : DevicefarmProjectState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DevicefarmProjectState<'Name>

        member _.Run(state: DevicefarmProjectState<Present>) : aws.DevicefarmProject.DevicefarmProject =
            let config = aws.DevicefarmProject.DevicefarmProjectConfig()
            for setter in state.assignments do
                setter config
            aws.DevicefarmProject.DevicefarmProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devicefarmProject: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DevicefarmProjectState<_>) : aws.DevicefarmProject.DevicefarmProject =
            Unchecked.defaultof<aws.DevicefarmProject.DevicefarmProject>
