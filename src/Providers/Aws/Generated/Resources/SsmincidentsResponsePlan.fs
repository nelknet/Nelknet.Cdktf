namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> = { assignments: ResizeArray<aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan">aws_ssmincidents_response_plan</a>.
    /// </summary>
    type SsmincidentsResponsePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmincidentsResponsePlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmincidentsResponsePlanState<Missing, Missing>)

        member _.Zero(()) : SsmincidentsResponsePlanState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmincidentsResponsePlanState<Missing, Missing>)

        /// <summary>
        /// incident_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#incident_template-1">SsmincidentsResponsePlan#incident_template</a>
        /// </summary>
        [<CustomOperation "incident_template">]
        member _.IncidentTemplate(state: SsmincidentsResponsePlanState<Missing, 'Name>, value: aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanIncidentTemplate) : SsmincidentsResponsePlanState<Present, 'Name> =
            state.assignments.Add(fun config -> config.IncidentTemplate <- value)
            ({ assignments = state.assignments } : SsmincidentsResponsePlanState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#name-1">SsmincidentsResponsePlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmincidentsResponsePlanState<'IncidentTemplate, Missing>, value: string) : SsmincidentsResponsePlanState<'IncidentTemplate, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmincidentsResponsePlanState<'IncidentTemplate, Present>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#action-1">SsmincidentsResponsePlan#action</a>
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanAction) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#chat_channel-1">SsmincidentsResponsePlan#chat_channel</a>.
        /// </summary>
        [<CustomOperation "chat_channel">]
        member _.ChatChannel(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: seq<string>) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.ChatChannel <- (value |> Seq.toArray))
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#display_name-1">SsmincidentsResponsePlan#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: string) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#engagements-1">SsmincidentsResponsePlan#engagements</a>.
        /// </summary>
        [<CustomOperation "engagements">]
        member _.Engagements(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: seq<string>) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.Engagements <- (value |> Seq.toArray))
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#id-1">SsmincidentsResponsePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: string) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// integration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#integration-1">SsmincidentsResponsePlan#integration</a>
        /// </summary>
        [<CustomOperation "integration">]
        member _.Integration(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanIntegration) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.Integration <- value)
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#tags-1">SsmincidentsResponsePlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: seq<string * string>) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmincidents_response_plan#tags_all-1">SsmincidentsResponsePlan#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>, value: seq<string * string>) : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmincidentsResponsePlanState<'IncidentTemplate, 'Name>

        member _.Run(state: SsmincidentsResponsePlanState<Present, Present>) : aws.SsmincidentsResponsePlan.SsmincidentsResponsePlan =
            let config = aws.SsmincidentsResponsePlan.SsmincidentsResponsePlanConfig()
            for setter in state.assignments do
                setter config
            aws.SsmincidentsResponsePlan.SsmincidentsResponsePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmincidentsResponsePlan: missing required arguments. Must call: incident_template, name.", 9999, IsError = true)>]
        member _.Run(_: SsmincidentsResponsePlanState<_, _>) : aws.SsmincidentsResponsePlan.SsmincidentsResponsePlan =
            Unchecked.defaultof<aws.SsmincidentsResponsePlan.SsmincidentsResponsePlan>
