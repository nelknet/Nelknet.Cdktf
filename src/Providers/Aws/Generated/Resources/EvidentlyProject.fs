namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EvidentlyProjectState<'Name> = { assignments: ResizeArray<aws.EvidentlyProject.EvidentlyProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project">aws_evidently_project</a>.
    /// </summary>
    type EvidentlyProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : EvidentlyProjectState<Missing> =
            ({ assignments = ResizeArray() } : EvidentlyProjectState<Missing>)

        member _.Zero(()) : EvidentlyProjectState<Missing> =
            ({ assignments = ResizeArray() } : EvidentlyProjectState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#name-1">EvidentlyProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EvidentlyProjectState<Missing>, value: string) : EvidentlyProjectState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EvidentlyProjectState<Present>)

        /// <summary>
        /// data_delivery block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#data_delivery-1">EvidentlyProject#data_delivery</a>
        /// </summary>
        [<CustomOperation "data_delivery">]
        member _.DataDelivery(state: EvidentlyProjectState<'Name>, value: aws.EvidentlyProject.EvidentlyProjectDataDelivery) : EvidentlyProjectState<'Name> =
            state.assignments.Add(fun config -> config.DataDelivery <- value)
            state : EvidentlyProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#description-1">EvidentlyProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EvidentlyProjectState<'Name>, value: string) : EvidentlyProjectState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EvidentlyProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#id-1">EvidentlyProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EvidentlyProjectState<'Name>, value: string) : EvidentlyProjectState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EvidentlyProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#tags-1">EvidentlyProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EvidentlyProjectState<'Name>, value: seq<string * string>) : EvidentlyProjectState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EvidentlyProjectState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#tags_all-1">EvidentlyProject#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EvidentlyProjectState<'Name>, value: seq<string * string>) : EvidentlyProjectState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EvidentlyProjectState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#timeouts-1">EvidentlyProject#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EvidentlyProjectState<'Name>, value: aws.EvidentlyProject.EvidentlyProjectTimeouts) : EvidentlyProjectState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EvidentlyProjectState<'Name>

        member _.Run(state: EvidentlyProjectState<Present>) : aws.EvidentlyProject.EvidentlyProject =
            let config = aws.EvidentlyProject.EvidentlyProjectConfig()
            for setter in state.assignments do
                setter config
            aws.EvidentlyProject.EvidentlyProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.evidentlyProject: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: EvidentlyProjectState<_>) : aws.EvidentlyProject.EvidentlyProject =
            Unchecked.defaultof<aws.EvidentlyProject.EvidentlyProject>
