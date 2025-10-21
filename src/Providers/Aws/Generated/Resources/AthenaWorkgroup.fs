namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AthenaWorkgroupState<'Name> = { assignments: ResizeArray<aws.AthenaWorkgroup.AthenaWorkgroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup">aws_athena_workgroup</a>.
    /// </summary>
    type AthenaWorkgroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : AthenaWorkgroupState<Missing> =
            ({ assignments = ResizeArray() } : AthenaWorkgroupState<Missing>)

        member _.Zero(()) : AthenaWorkgroupState<Missing> =
            ({ assignments = ResizeArray() } : AthenaWorkgroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#name-1">AthenaWorkgroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AthenaWorkgroupState<Missing>, value: string) : AthenaWorkgroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AthenaWorkgroupState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#configuration-1">AthenaWorkgroup#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: AthenaWorkgroupState<'Name>, value: aws.AthenaWorkgroup.AthenaWorkgroupConfiguration) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#description-1">AthenaWorkgroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AthenaWorkgroupState<'Name>, value: string) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#force_destroy-1">AthenaWorkgroup#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: AthenaWorkgroupState<'Name>, value: bool) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#force_destroy-1">AthenaWorkgroup#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: AthenaWorkgroupState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#id-1">AthenaWorkgroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AthenaWorkgroupState<'Name>, value: string) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#state-1">AthenaWorkgroup#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: AthenaWorkgroupState<'Name>, value: string) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.State <- value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#tags-1">AthenaWorkgroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AthenaWorkgroupState<'Name>, value: seq<string * string>) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AthenaWorkgroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_workgroup#tags_all-1">AthenaWorkgroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AthenaWorkgroupState<'Name>, value: seq<string * string>) : AthenaWorkgroupState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AthenaWorkgroupState<'Name>

        member _.Run(state: AthenaWorkgroupState<Present>) : aws.AthenaWorkgroup.AthenaWorkgroup =
            let config = aws.AthenaWorkgroup.AthenaWorkgroupConfig()
            for setter in state.assignments do
                setter config
            aws.AthenaWorkgroup.AthenaWorkgroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.athenaWorkgroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AthenaWorkgroupState<_>) : aws.AthenaWorkgroup.AthenaWorkgroup =
            Unchecked.defaultof<aws.AthenaWorkgroup.AthenaWorkgroup>
